using EOS_SDK._Networking.Packets;
using LiteNetLib;
using LiteNetLib.Utils;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;

namespace Broadcast_Server
{
    public class BServer : INetEventListener
    {
        public NetManager Server;
        public NetPacketProcessor NetPacketProcessor = new();

        public Dictionary<string /* IPEndPoint.String */, (string UserId, string AppId)> NetUsers = new();
        public Dictionary<string /* AppId */, List<string /* IPEndPoint.String */>> AppIdAddresses = new();
        public List<string> AppIds = new();

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
                AppIdAddresses.TryAdd(packet.AppId, new() { point.ToString() });
            else
                AppIdAddresses[packet.AppId].Add(point.ToString());   
            NetUsers.TryAdd(point.ToString(), (packet.AccountId, packet.AppId));
            AppIds.Add(packet.AppId);
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
            Console.WriteLine("[Server] OnNetworkError: " + endPoint + " " + socketError);
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
            if (!NetUsers.TryGetValue(peer.ToString(), out var peer_user))
            {
                Console.WriteLine("[Server] Peer " + peer + " not found in NetUsers!!!");
                return;
            }

            Console.WriteLine("[Server] Peer connected: " + peer + " " + peer_user.UserId);

            var peers = GetPeersFromSameAddress(peer);

            foreach (var item in peers)
            {
                if (item == null)
                    continue;
                if (!NetUsers.TryGetValue(item.ToString(), out var user))
                {
                    Console.WriteLine("[Server] Peer " + item + " not found in NetUsers!!!");
                    continue;
                }
                UserConnectedPacket newUserConnectedPacket = new()
                { 
                    AccountId = user.UserId,
                    AppId = user.AppId,
                    IP = item.ToString()
                };
                NetDataWriter writer = new();
                NetPacketProcessor.WriteNetSerializable(writer, ref newUserConnectedPacket);
                peer.Send(writer, DeliveryMethod.ReliableOrdered);
                writer.Reset();
                newUserConnectedPacket = new()
                {
                    AccountId = peer_user.UserId,
                    AppId = peer_user.AppId,
                    IP = peer.ToString()
                };
                NetPacketProcessor.WriteNetSerializable(writer, ref newUserConnectedPacket);
                item.Send(writer, DeliveryMethod.ReliableOrdered);
            }
        }

        public void OnPeerDisconnected(NetPeer peer, DisconnectInfo disconnectInfo)
        {

            if (!NetUsers.TryGetValue(peer.ToString(), out var user))
            {
                Console.WriteLine("[Server] Peer " + peer + " not found in NetUsers!!!");
                return;
            }
            Console.WriteLine("[Server] Peer disconnected: " + peer + " " + user.UserId);

            var peers = GetPeersFromSameAddress(peer);

            foreach (var item in peers)
            {
                if (item == null)
                    continue;
                UserDisconnectedPacket userDisconnectedPacket = new()
                {
                    AccountId = user.UserId,
                    AppId = user.AppId,
                    IP = peer.ToString()
                };
                NetDataWriter writer = new();
                NetPacketProcessor.WriteNetSerializable(writer, ref userDisconnectedPacket);
                item.Send(writer, DeliveryMethod.ReliableOrdered);
            }
            peers.Clear();
            NetUsers.Remove(peer.ToString());
            AppIdAddresses[user.AppId].Remove(peer.ToString());

            if (AppIdAddresses[user.AppId].Count == 0)
            {
                Console.WriteLine("AppId To Addressses cleaned  " + user.AppId);
                AppIdAddresses.Remove(user.AppId);
            }
        }

        public List<NetPeer> GetPeersFromAppID(string AppId)
        {
            if (!AppIdAddresses.TryGetValue(AppId, out var iPAddresses))
                return new();
            return this.Server.ConnectedPeerList.Where(x => iPAddresses.Contains(x.ToString())).ToList();
        }

        public List<NetPeer> GetPeersFromSameAddress(IPEndPoint address)
        {
            var iPAddresses = AppIdAddresses.Values.Where(x => x.Contains(address.ToString())).FirstOrDefault();
            if (iPAddresses == null)
                return new();
            List<NetPeer> ret = new();
            foreach (var peer in this.Server.ConnectedPeerList)
            {
                if (address == (IPEndPoint)peer)
                {
                    continue;
                }
                if (iPAddresses.Contains(peer.ToString()))
                {
                    ret.Add(peer);
                }
                else
                {
                    Console.WriteLine("Not contains: " + peer + " " + (IPEndPoint)peer);
                }
            }
            return ret;
        }
    }
}
