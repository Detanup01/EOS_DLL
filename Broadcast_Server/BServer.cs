using EOS_SDK._Networking.Packets;
using LiteNetLib;
using LiteNetLib.Utils;
using System.Net;
using System.Net.Sockets;

namespace Broadcast_Server
{
    public class BServer : INetEventListener
    {
        public NetManager Server;
        public NetPacketProcessor NetPacketProcessor = new();

        public Dictionary<IPAddress, (string UserId, string AppId)> NetUsers = new();
        public Dictionary<string /* AppId */, List<IPAddress>> AppIdAddresses = new();

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public BServer()
        {
            NetPacketProcessor.RegisterNestedType<DiscoveryRequestPacket>();
            NetPacketProcessor.RegisterNestedType<DiscoveryResponsePacket>();
            NetPacketProcessor.RegisterNestedType<UserConnectedPacket>();
            NetPacketProcessor.RegisterNestedType<UserDisconnectedPacket>();
            NetPacketProcessor.SubscribeNetSerializable<DiscoveryRequestPacket, IPEndPoint>(DiscoveryRequest);
        }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

        private void DiscoveryRequest(DiscoveryRequestPacket packet, IPEndPoint point)
        {
            Console.WriteLine(packet);
            if (!AppIdAddresses.ContainsKey(packet.AppId))
                AppIdAddresses.Add(packet.AppId, new());
            AppIdAddresses[packet.AppId].Add(point.Address);
            NetUsers.Add(point.Address, (packet.AccountId, packet.AppId));
            DiscoveryResponsePacket discoveryResponsePacket = new()
            { 
                CanConnect = true
            };
            NetDataWriter writer = new();
            NetPacketProcessor.WriteNetSerializable(writer, ref discoveryResponsePacket);
            Server.SendUnconnectedMessage(writer, point);
        }

        public void OnConnectionRequest(ConnectionRequest request)
        {
            request.AcceptIfKey("EOS_BroadCast");
        }

        public void OnNetworkError(IPEndPoint endPoint, SocketError socketError)
        {
            
        }

        public void OnNetworkLatencyUpdate(NetPeer peer, int latency)
        {
            
        }

        public void OnNetworkReceive(NetPeer peer, NetPacketReader reader, byte channelNumber, DeliveryMethod deliveryMethod)
        {
            //  handle more thing than just connecting two players? 
        }

        public void OnNetworkReceiveUnconnected(IPEndPoint remoteEndPoint, NetPacketReader reader, UnconnectedMessageType messageType)
        {
            Console.WriteLine("[Server] ReceiveUnconnected {0}. From: {1}", messageType, remoteEndPoint);
            NetPacketProcessor.ReadPacket(reader, remoteEndPoint);
        }

        public void OnPeerConnected(NetPeer peer)
        {
            Console.WriteLine("[Server] Peer connected: " + peer);

            var peers = GetPeersFromSameAddress(peer.Address);

            foreach (var item in peers)
            {
                if (item == null)
                    continue;
                var user = NetUsers[item.Address];
                UserConnectedPacket newUserConnectedPacket = new()
                { 
                    AccountId = user.UserId,
                    AppId = user.AppId,
                    IP = item
                };
                NetDataWriter writer = new();
                NetPacketProcessor.WriteNetSerializable(writer, ref newUserConnectedPacket);
                peer.Send(writer, DeliveryMethod.ReliableOrdered);
            }
        }

        public void OnPeerDisconnected(NetPeer peer, DisconnectInfo disconnectInfo)
        {
            Console.WriteLine("[Server] Peer disconnected: " + peer);
            var user = NetUsers[peer.Address];
            var peers = GetPeersFromSameAddress(peer.Address);

            foreach (var item in peers)
            {
                if (item == null)
                    continue;
                UserDisconnectedPacket userDisconnectedPacket = new()
                {
                    AccountId = user.UserId,
                    AppId = user.AppId,
                    IP = peer
                };
                NetDataWriter writer = new();
                NetPacketProcessor.WriteNetSerializable(writer, ref userDisconnectedPacket);
                item.Send(writer, DeliveryMethod.ReliableOrdered);
            }
            peers.Clear();
            NetUsers.Remove(peer.Address);
            AppIdAddresses[user.AppId].Remove(peer.Address);
        }

        public List<NetPeer> GetPeersFromAppID(string AppId)
        {
            if (!AppIdAddresses.TryGetValue(AppId, out var iPAddresses))
                return new();
            return this.Server.ConnectedPeerList.Where(x => iPAddresses.Contains(x.Address)).ToList();
        }

        public List<NetPeer> GetPeersFromSameAddress(IPAddress address)
        {
            var iPAddresses = AppIdAddresses.Values.Where(x => x.Contains(address)).FirstOrDefault();
            if (iPAddresses == null)
                return new();
            return this.Server.ConnectedPeerList.Where(x => iPAddresses.Contains(x.Address)).ToList();
        }
    }
}
