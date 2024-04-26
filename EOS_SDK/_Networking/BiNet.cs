using LiteNetLib;
using LiteNetLib.Utils;
using System.Net.Sockets;
using System.Net;
using EOS_SDK._Networking.Packets;
using EOS_SDK._Data;
using EOS_SDK._log;
using EOS_SDK._Networking.Packets.Ach;

namespace EOS_SDK._Networking
{
    /// <summary>
    /// bidirectional net (server AND client)
    /// </summary>
    public class BiNet : INetEventListener
    {
        public NetPacketProcessor NetPacketProcessor = new();
        public NetManager Net;
        public Dictionary<int, string> NetPeerToUser = new();
        public Dictionary<IPAddress, string> NetUsers;
        public Dictionary<string, int> AccountId_To_PeerId;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public BiNet()
        {
            NetPacketProcessor.RegisterNestedType<DiscoveryRequestPacket>();
            NetPacketProcessor.RegisterNestedType<DiscoveryResponsePacket>();

            NetPacketProcessor.RegisterNestedType<UserConnectedPacket>();
            NetPacketProcessor.RegisterNestedType<UserDisconnectedPacket>();

            NetPacketProcessor.RegisterNestedType<PingPacket>();
            NetPacketProcessor.RegisterNestedType<GetPlayerAchReqPacket>();
            NetPacketProcessor.RegisterNestedType<GetPlayerAchRspPacket>();

            NetPacketProcessor.SubscribeNetSerializable<DiscoveryResponsePacket, IPEndPoint>(DiscoveryResponse);
            NetPacketProcessor.SubscribeNetSerializable<UserConnectedPacket, IPEndPoint>(UserConnected);
            NetPacketProcessor.SubscribeNetSerializable<UserDisconnectedPacket, IPEndPoint>(UserDisconnected);
            NetPacketProcessor.SubscribeNetSerializable<GetPlayerAchReqPacket, IPEndPoint>(AchPacketWorker.PlayerAchGet_Send);
            NetPacketProcessor.SubscribeNetSerializable<GetPlayerAchRspPacket, IPEndPoint>(AchPacketWorker.PlayerAchGet_Recv);

            NetPacketProcessor.SubscribeNetSerializable<PingPacket, IPEndPoint>(PingProcess);
        }


#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.


        #region Interface Implementation
        public void OnPeerConnected(NetPeer peer)
        {
            Logger.WriteDebug($"[BiNet] Peer Id: {peer.Id} Peer RemoteId: {peer.RemoteId}");
            Logger.WriteDebug($"[BiNet {Net.LocalPort}] connected to: {peer.Address}:{peer.Port}");

            if (!NetUsers.TryGetValue(peer.Address, out var str))
                return;
            NetPeerToUser.Add(peer.Id, str);
            AccountId_To_PeerId.Add(str, peer.Id);
        }

        public void OnPeerDisconnected(NetPeer peer, DisconnectInfo disconnectInfo)
        {
            Logger.WriteDebug($"[BiNet] Peer Id: {peer.Id} ({peer.Address}:{peer.Port}) disconnected: {disconnectInfo.Reason}");
            var accountId = NetPeerToUser[peer.Id];
            NetPeerToUser.Remove(peer.Id);
            AccountId_To_PeerId.Remove(accountId);
        }

        public void OnNetworkError(IPEndPoint endPoint, SocketError error)
        {
            Logger.WriteDebug("[BiNet] error! " + error);
        }

        public void OnNetworkReceive(NetPeer peer, NetPacketReader reader, byte channel, DeliveryMethod deliveryMethod)
        {
            NetPacketProcessor.ReadAllPackets(reader, (peer, channel));
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
            request.AcceptIfKey(EOS_Main.GetConfig().AppId);
        }
        #endregion

        #region Packet Stuff
        private void DiscoveryResponse(DiscoveryResponsePacket packet, IPEndPoint remoteEndPoint)
        {
            Logger.WriteDebug($"DiscoveryResponsePacket: {packet} from: {remoteEndPoint.Address}");
            if (packet.CanConnect)
                Net.Connect(remoteEndPoint, "EOS_BroadCast");
        }

        private void UserDisconnected(UserDisconnectedPacket packet, IPEndPoint point)
        {
            if (packet.AppId != EOS_Main.GetConfig().AppId)
                return;
            NetUsers.Remove(packet.IP.Address);
            // Do we really need to send disconnect? (they automactly disconnect so no, I guess)
        }

        private void UserConnected(UserConnectedPacket packet, IPEndPoint point)
        {
            if (packet.AppId != EOS_Main.GetConfig().AppId)
                return;
            NetUsers.Add(packet.IP.Address, packet.AppId);
            Net.Connect(packet.IP, EOS_Main.GetConfig().AppId);
        }

        private void PingProcess(PingPacket packet, IPEndPoint point)
        {
            Logger.WriteDebug($"Ping! {packet}");
            if (EOS_Main.GetConfig().AccountId != packet.AccountId)
            {
                //todo: check safely
                var id = AccountId_To_PeerId[packet.AccountId];
                NetDataWriter writer = new NetDataWriter();
                NetPacketProcessor.WriteNetSerializable(writer, ref packet);
                Net.GetPeerById(id).Send(writer, DeliveryMethod.ReliableOrdered);
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
            Logger.WriteDebug("sending broadcast");
            Net.SendBroadcast(writer, 5555);
        }
        #endregion

    }
}
