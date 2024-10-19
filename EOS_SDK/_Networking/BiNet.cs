using LiteNetLib;
using LiteNetLib.Utils;
using System.Net.Sockets;
using System.Net;
using EOS_SDK._Networking.Packets;
using EOS_SDK._Data;
using EOS_SDK._log;
using EOS_SDK._Networking.Packets.ResponsePackets;
using EOS_SDK._Networking.PacketWorkers;

namespace EOS_SDK._Networking
{
    /// <summary>
    /// bidirectional net (server AND client)
    /// </summary>
    public class BiNet : INetEventListener
    {
        public NetPacketProcessor NetPacketProcessor = new();
        public Dictionary<int, /* PeerId */ string /* AccountId */> PeerId_To_AccountId = [];
        public Dictionary<string /* IPEndPoint */, string /* AccountId */> NetUsers = [];
        public Dictionary<string /* AccountId */, int /* PeerId */> AccountId_To_PeerId = [];

        public BiNet()
        {
            NetPacketProcessor.RegisterNestedType<DiscoveryRequestPacket>();
            NetPacketProcessor.RegisterNestedType<DiscoveryResponsePacket>();

            NetPacketProcessor.RegisterNestedType<UserConnectedPacket>();
            NetPacketProcessor.RegisterNestedType<UserDisconnectedPacket>();

            NetPacketProcessor.RegisterNestedType<PingPongPacket>();
            NetPacketProcessor.RegisterNestedType<ReqPacket>();
            NetPacketProcessor.RegisterNestedType<AchResponsePacket>();

            NetPacketProcessor.RegisterNestedType<PlayerPacket<ReqPacket>>();
            NetPacketProcessor.RegisterNestedType<PlayerPacket<PingPongPacket>>();
            NetPacketProcessor.RegisterNestedType<PlayerPacket<AchResponsePacket>>();

            NetPacketProcessor.SubscribeNetSerializable<DiscoveryResponsePacket, IPEndPoint>(UserNetWorker.DiscoveryResponse);
            NetPacketProcessor.SubscribeNetSerializable<UserConnectedPacket, IPEndPoint>(UserNetWorker.UserConnected);
            NetPacketProcessor.SubscribeNetSerializable<UserDisconnectedPacket, IPEndPoint>(UserNetWorker.UserDisconnected);

            NetPacketProcessor.SubscribeNetSerializable<PlayerPacket<ReqPacket>, IPEndPoint>(PlayerPacketWorker.ReqPacket);
            NetPacketProcessor.SubscribeNetSerializable<PlayerPacket<PingPongPacket>, IPEndPoint>(PlayerPacketWorker.PingPacket);
            NetPacketProcessor.SubscribeNetSerializable<PlayerPacket<AchResponsePacket>, IPEndPoint>(PlayerPacketWorker.AchResponsePacket);
        }

        #region Interface Implementation
        public void OnPeerConnected(NetPeer peer)
        {
            
            Logger.WriteDebug($"[BiNet] Peer Id: {peer.Id} Peer RemoteId: {peer.RemoteId}");
            Logger.WriteDebug($"[BiNet {peer.NetManager.LocalPort}] ({peer.NetManager}) connected to: {peer}");

            if (!NetUsers.TryGetValue(peer.ToString(), out var accountId))
            {
                NetUsers.Add(peer.ToString(), string.Empty);
                return;
            }
            PeerId_To_AccountId.Add(peer.Id, accountId);
            AccountId_To_PeerId.Add(accountId, peer.Id);
        }

        public void OnPeerDisconnected(NetPeer peer, DisconnectInfo disconnectInfo)
        {
            Logger.WriteDebug("Disconnect! " + disconnectInfo.Reason + " " + disconnectInfo.SocketErrorCode);
            Logger.WriteDebug("Is peer null? " + (peer == null));
            if (peer == null)
                return;
            Logger.WriteDebug($"[BiNet] Peer Id: {peer.Id} disconnected: {disconnectInfo.Reason}");
            if (!PeerId_To_AccountId.TryGetValue(peer.Id, out var accountId))
                return;
            PeerId_To_AccountId.Remove(peer.Id);
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
    }
}
