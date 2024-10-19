using EOS_SDK._Data;
using EOS_SDK._log;
using EOS_SDK._Networking.Packets;
using LiteNetLib;
using LiteNetLib.Utils;
using System.Net;

namespace EOS_SDK._Networking
{
    public class NetworkMaster
    {
        public NetManager? NetManager;
        public BiNet? BiNet;
        public bool Start()
        {
            BiNet = new BiNet();
            NetManager = new NetManager(BiNet)
            {
                UnconnectedMessagesEnabled = true,
                BroadcastReceiveEnabled = true,
                IPv6Enabled = EOS_Main.GetConfig().Networking.UseIPV6,
                ChannelsCount = 32 // EOS using 32 channel, we using 32 here too.
            };
            Logger.WriteDebug("Networking Starting...");
            if (!NetManager.Start())
            {
                Logger.WriteDebug("Networking Starting failed!");
                return false;
            }
            Logger.WriteDebug("Networking Started!");
            SendBroadcast();
            return true;
        }

        public void Update()
        {
            if (NetManager != null && NetManager.IsRunning)
            {
                NetManager.PollEvents();
                /*
                if (BiNet.Net.FirstPeer != null)
                {
                    var fpeer = BiNet.Net.FirstPeer;
                    BiNet.Net.ConnectedPeerList.ForEach(peer => { Logger.WriteDebug($"NetManager.Test: FirstPeer {PrintDetailedPeer(fpeer)}, ConnectedPeers: {BiNet.Net.ConnectedPeersCount} ConnectedPeer: {PrintDetailedPeer(peer)}"); });
                }*/
            }
        }

        public void Stop()
        {
            Logger.WriteDebug("Networking Stopping...");
            NetManager?.Stop();
            NetManager = null;
            BiNet = null;
            Logger.WriteDebug("Networking Stopped!");
        }

        public static string PrintDetailedPeer(NetPeer peer)
        {
            return $" IpPort: {peer.ToString()}, PeerId: {peer.Id}, PeerRemoteId: {peer.RemoteId}";
        }

        public bool IsUserExists(string AccountId)
        {
            if (BiNet != null)
                return false;
            return BiNet!.AccountId_To_PeerId.ContainsKey(AccountId);
        }

        public bool IsNull()
        {
            return BiNet == null || NetManager == null;
        }
        #region Send Releated Actions
        public void SendBroadcast()
        {
            if (BiNet == null)
                return;
            if (NetManager == null)
                return;
            DiscoveryRequestPacket discovery = new()
            {
                AccountId = EOS_Main.GetConfig().AccountId,
                AppId = EOS_Main.GetConfig().AppId,
            };
            NetDataWriter writer = new NetDataWriter();
            BiNet.NetPacketProcessor.WriteNetSerializable(writer, ref discovery);
            Logger.WriteDebug("Sending Broadcast");
            NetManager.SendBroadcast(writer, 5555);
        }

        public void SendNetPacketToAll(INetSerializable netSerializable)
        {
            if (BiNet == null)
                return;
            if (NetManager == null)
                return;
            NetDataWriter writer = new NetDataWriter();
            BiNet.NetPacketProcessor.WriteNetSerializable(writer, ref netSerializable);
            Logger.WriteDebug($"Sending NetPacket to All");
            NetManager.SendToAll(writer, DeliveryMethod.ReliableOrdered);
        }

        public void SendNetPacketToUser(INetSerializable netSerializable, string AccountId, DeliveryMethod delivery = DeliveryMethod.ReliableOrdered)
        {
            if (BiNet == null)
                return;
            if (NetManager == null)
                return;
            NetDataWriter writer = new NetDataWriter();
            BiNet.NetPacketProcessor.WriteNetSerializable(writer, ref netSerializable);
            Logger.WriteDebug($"Sending NetPacket to {AccountId}");
            if (BiNet.AccountId_To_PeerId.TryGetValue(AccountId, out int PeerId))
            {
                var peer = NetManager.GetPeerById(PeerId);
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
            }
        }
        #endregion



    }
}
