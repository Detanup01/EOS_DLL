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
            NetPacketProcessor.SubscribeNetSerializable<DiscoveryResponsePacket, IPEndPoint>(DiscoveryResponse);
            NetPacketProcessor.SubscribeNetSerializable<DiscoveryRequestPacket, IPEndPoint>(DiscoveryRequest);
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
            Logger.WriteDebug($"[BiNet] Peer connected: {peer}");
            var peers = Net.ConnectedPeerList;
            foreach (var netPeer in peers)
            {
                Logger.WriteDebug($"ConnectedPeersList: id={netPeer.Id}, ep={netPeer}");
            }
            /*
            UserPacket userPacket = GetMyUserPacket();
            NetDataWriter writer = new NetDataWriter();
            NetPacketProcessor.WriteNetSerializable(writer, ref userPacket);
            peer.Send(writer, 1, DeliveryMethod.ReliableOrdered);
            Logger.WriteDebug("[BiNet] Sending My UserPacket " + userPacket.UserId);*/
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
                Net.Connect(remoteEndPoint, EOS_Main.GetConfig().AppId);
        }

        private void DiscoveryRequest(DiscoveryRequestPacket packet, IPEndPoint endPoint)
        {
            DiscoveryResponsePacket discoveryResponsePacket = new()
            {
                CanConnect = true,
                DenyReason =  DiscoveryDenyEnums.None
            };
            Logger.WriteDebug($"{packet} from: {endPoint.Address}");
            if (packet.AppId != EOS_Main.GetConfig().AppId)
            {
                discoveryResponsePacket.CanConnect = false;
                discoveryResponsePacket.DenyReason = DiscoveryDenyEnums.AppIdMissmatch;
            }
            if (AddressHelper.GetIPs().Contains(endPoint.Address))
            {
                discoveryResponsePacket.CanConnect = false;
                discoveryResponsePacket.DenyReason = DiscoveryDenyEnums.SelfConnection;
            }
            NetDataWriter writer = new();
            NetPacketProcessor.WriteNetSerializable(writer, ref discoveryResponsePacket);
            Net.SendUnconnectedMessage(writer, endPoint);
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
