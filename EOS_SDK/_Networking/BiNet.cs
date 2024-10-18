using LiteNetLib;
using LiteNetLib.Utils;
using System.Net.Sockets;
using System.Net;
using EOS_SDK._Networking.Packets;
using EOS_SDK._Data;
using EOS_SDK._log;
using EOS_SDK._Networking.Packets.ResponsePackets;

namespace EOS_SDK._Networking
{
    /// <summary>
    /// bidirectional net (server AND client)
    /// </summary>
    public class BiNet : INetEventListener
    {
        public NetPacketProcessor NetPacketProcessor = new();
        public NetManager Net;
        public Dictionary<int, /* PeerId */ string /* AccountId */> NetPeerToUser = new();
        public Dictionary<string /* IPEndPoint */, string /* AccountId */> NetUsers = new();
        public Dictionary<string /* AccountId */, int /* PeerId */> AccountId_To_PeerId = new();

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public BiNet()
        {
            NetPacketProcessor.RegisterNestedType<DiscoveryRequestPacket>();
            NetPacketProcessor.RegisterNestedType<DiscoveryResponsePacket>();

            NetPacketProcessor.RegisterNestedType<UserConnectedPacket>();
            NetPacketProcessor.RegisterNestedType<UserDisconnectedPacket>();

            NetPacketProcessor.RegisterNestedType<PingPacket>();
            NetPacketProcessor.RegisterNestedType<ReqPacket>();
            NetPacketProcessor.RegisterNestedType<AchResponsePacket>();

            NetPacketProcessor.RegisterNestedType<PlayerPacket<ReqPacket>>();
            NetPacketProcessor.RegisterNestedType<PlayerPacket<PingPacket>>();
            NetPacketProcessor.RegisterNestedType<PlayerPacket<AchResponsePacket>>();


            NetPacketProcessor.SubscribeNetSerializable<DiscoveryResponsePacket, IPEndPoint>(DiscoveryResponse);
            NetPacketProcessor.SubscribeNetSerializable<UserConnectedPacket, IPEndPoint>(UserConnected);
            NetPacketProcessor.SubscribeNetSerializable<UserDisconnectedPacket, IPEndPoint>(UserDisconnected);

            NetPacketProcessor.SubscribeNetSerializable<PlayerPacket<ReqPacket>, IPEndPoint>(PlayerPacketWorker.ReqPacket);
            NetPacketProcessor.SubscribeNetSerializable<PlayerPacket<PingPacket>, IPEndPoint>(PlayerPacketWorker.PingPacket);
            NetPacketProcessor.SubscribeNetSerializable<PlayerPacket<AchResponsePacket>, IPEndPoint>(PlayerPacketWorker.AchResponsePacket);
        }


#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.


        #region Interface Implementation
        public void OnPeerConnected(NetPeer peer)
        {
            Logger.WriteDebug($"[BiNet] Peer Id: {peer.Id} Peer RemoteId: {peer.RemoteId}");
            Logger.WriteDebug($"[BiNet {Net.LocalPort}] ({Net}) connected to: {peer}");

            if (!NetUsers.TryGetValue(peer.ToString(), out var accountId))
            {
                NetUsers.Add(peer.ToString(), string.Empty);
                return;
            }
            NetPeerToUser.Add(peer.Id, accountId);
            AccountId_To_PeerId.Add(accountId, peer.Id);
        }

        public void OnPeerDisconnected(NetPeer peer, DisconnectInfo disconnectInfo)
        {
            Logger.WriteDebug("Disconnect! " + disconnectInfo.Reason + " " + disconnectInfo.SocketErrorCode);
            Logger.WriteDebug("Is peer null? " + (peer == null));
            if (peer == null)
                return;
            Logger.WriteDebug($"[BiNet] Peer Id: {peer.Id} disconnected: {disconnectInfo.Reason}");
            if (!NetPeerToUser.TryGetValue(peer.Id, out var accountId))
                return;
            NetPeerToUser.Remove(peer.Id);
            AccountId_To_PeerId.Remove(accountId);
        }

        public void OnNetworkError(IPEndPoint endPoint, SocketError error)
        {
            Logger.WriteDebug("[BiNet] error! " + error);
        }

        public void OnNetworkReceive(NetPeer peer, NetPacketReader reader, byte channel, DeliveryMethod deliveryMethod)
        {
            NetPacketProcessor.ReadAllPackets(reader, (IPEndPoint)peer);
        }

        public void OnNetworkReceiveUnconnected(IPEndPoint remoteEndPoint, NetPacketReader reader, UnconnectedMessageType messageType)
        {
            NetPacketProcessor.ReadAllPackets(reader, remoteEndPoint);
        }

        public void OnNetworkLatencyUpdate(NetPeer peer, int latency)
        {

        }

        public void OnConnectionRequest(ConnectionRequest request)
        {
            Logger.WriteDebug($"OnConnectionRequest: {request.RemoteEndPoint}");
            request.AcceptIfKey(EOS_Main.GetConfig().AppId);
        }
        #endregion

        #region Packet Stuff
        private void DiscoveryResponse(DiscoveryResponsePacket packet, IPEndPoint remoteEndPoint)
        {
            Logger.WriteDebug($"DiscoveryResponsePacket: {packet} from: {remoteEndPoint}");
            if (packet.CanConnect)
                Net.Connect(remoteEndPoint, "EOS_BroadCast");
        }

        private void UserDisconnected(UserDisconnectedPacket packet, IPEndPoint point)
        {
            Logger.WriteDebug($"UserDisconnectedPacket: {packet} from: {point}");
            if (packet.AppId != EOS_Main.GetConfig().AppId)
                return;
            NetUsers.Remove(packet.IP);
            // Do we really need to send disconnect? (they automactly disconnect so no, I guess)
        }

        private void UserConnected(UserConnectedPacket packet, IPEndPoint point)
        {
            Logger.WriteDebug($"UserConnectedPacket: {packet} from: {point}");
            if (packet.AppId != EOS_Main.GetConfig().AppId)
            {
                Logger.WriteDebug($"AppId is not the same as in our config ({packet.AppId})!=({EOS_Main.GetConfig().AppId})");
                return;
            }

            if (NetUsers.TryGetValue(packet.IP, out var id))
            {
                Logger.WriteDebug($"User already connected. IP: {packet.IP}");
                if (id == string.Empty)
                {
                    NetUsers[packet.IP] = packet.AccountId;
                    var peer = this.Net.ConnectedPeerList.Where(x => x.ToString() == packet.IP).FirstOrDefault();
                    if (peer == null)
                    {
                        Logger.WriteDebug($"Peer NULL!");
                        return;
                    }
                    NetPeerToUser.Add(peer.Id, packet.AccountId);
                    AccountId_To_PeerId.Add(packet.AccountId, peer.Id);
                    Logger.WriteDebug($"Everything set!");
                }
                else
                {
                    Logger.WriteDebug("Client Already connected before. Skipping connection sending.");
                }
                return;
            }

            NetUsers.Add(packet.IP, packet.AccountId);
            var port = int.Parse(packet.IP.Split(":")[1]);
            var ip = IPAddress.Parse(packet.IP.Split(":")[0]);
            IPEndPoint endPoint = new(ip, port);
            Net.Connect(endPoint, EOS_Main.GetConfig().AppId);
            Logger.WriteDebug($"Connection Request send to: {endPoint.ToString()} ({packet.AccountId})");
        }

        private void PingProcess(PingPacket packet, IPEndPoint point)
        {
            Logger.WriteDebug($"Ping! {packet}");
            if (EOS_Main.GetConfig().AccountId != packet.AccountId)
            {
                //todo: check safely
                if (AccountId_To_PeerId.TryGetValue(packet.AccountId, out int id))
                {
                    NetDataWriter writer = new NetDataWriter();
                    NetPacketProcessor.WriteNetSerializable(writer, ref packet);
                    Net.GetPeerById(id).Send(writer, DeliveryMethod.ReliableOrdered);
                    Logger.WriteDebug("Resent packet");
                }
                else
                    Logger.WriteDebug($"AccountId not exist in AID_2_PeerId ({packet.AccountId})");
            }
        }

        #endregion

        #region Custom functions
        public void SendBroadcast()
        {
            DiscoveryRequestPacket discovery = new()
            {
                AccountId = EOS_Main.GetConfig().AccountId,
                AppId = EOS_Main.GetConfig().AppId,
            };
            NetDataWriter writer = new NetDataWriter();
            NetPacketProcessor.WriteNetSerializable(writer, ref discovery);
            Logger.WriteDebug("Sending Broadcast");
            Net.SendBroadcast(writer, 5555);
        }

        public void SendNetPacketToAll(INetSerializable netSerializable)
        {
            NetDataWriter writer = new NetDataWriter();
            NetPacketProcessor.WriteNetSerializable(writer, ref netSerializable);
            Logger.WriteDebug($"Sending NetPacket to All");
            Net.SendToAll(writer, DeliveryMethod.ReliableOrdered);
        }

        public void SendNetPacketToUser(INetSerializable netSerializable, string AccountId, DeliveryMethod delivery = DeliveryMethod.ReliableOrdered)
        {
            NetDataWriter writer = new NetDataWriter();
            NetPacketProcessor.WriteNetSerializable(writer, ref netSerializable);
            Logger.WriteDebug($"Sending NetPacket to {AccountId}");
            if (AccountId_To_PeerId.TryGetValue(AccountId, out int PeerId))
            {
                var peer = Net.GetPeerById(PeerId);
                if (peer == null)
                {
                    Logger.WriteError($"Net Peer for AccountId {AccountId} is null!");
                    return;
                }
                peer.Send(writer, delivery);
            }
            else
            {
                Logger.WriteError($"Net Peer for AccountId {AccountId} not exist!");
                return;
            }
        }
        #endregion

    }
}
