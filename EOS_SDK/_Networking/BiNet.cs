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

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public BiNet()
        {
            NetPacketProcessor.RegisterNestedType<DiscoveryRequestPacket>();
            NetPacketProcessor.RegisterNestedType<DiscoveryResponsePacket>();
            NetPacketProcessor.RegisterNestedType<GetPlayerAchReqPacket>();
            NetPacketProcessor.RegisterNestedType<GetPlayerAchRspPacket>();
            NetPacketProcessor.RegisterNestedType<UserConnectedPacket>();
            NetPacketProcessor.RegisterNestedType<UserDisconnectedPacket>();
            NetPacketProcessor.SubscribeNetSerializable<DiscoveryResponsePacket, IPEndPoint>(DiscoveryResponse);
            NetPacketProcessor.SubscribeNetSerializable<GetPlayerAchReqPacket, IPEndPoint>(AchPacketWorker.PlayerAchGet_Send);
            NetPacketProcessor.SubscribeNetSerializable<GetPlayerAchRspPacket, IPEndPoint>(AchPacketWorker.PlayerAchGet_Recv);
        }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

        //  TODO: Add LobbyPacket implementation. (Check LocalLobby) 

        #region Interface Implementation
        public void OnPeerConnected(NetPeer peer)
        {
            Logger.WriteDebug($"[BiNet] Peer Id: {peer.Id} Peer RemoteId: {peer.RemoteId}");
            Logger.WriteDebug($"[BiNet {Net.LocalPort}] connected to: {peer.Address}:{peer.Port}");
        }

        public void OnPeerDisconnected(NetPeer peer, DisconnectInfo disconnectInfo)
        {
            Logger.WriteDebug("[BiNet] disconnected: " + disconnectInfo.Reason);
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
