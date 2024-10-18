using EOS_SDK._log;
using LiteNetLib;
using System.Net;

namespace EOS_SDK._Networking
{
    public class NetworkMaster
    {
        public BiNet? BiNet;
        public bool Start()
        {
            BiNet = new BiNet();

            NetManager _net = new NetManager(BiNet)
            {
                UnconnectedMessagesEnabled = true,
                BroadcastReceiveEnabled = true,
                IPv6Enabled = false,
                ChannelsCount = 32
            };
            BiNet.Net = _net;
            Logger.WriteDebug("BiNet Starting...");
            if (!_net.Start())
            {
                Logger.WriteDebug("BiNet Starting failed!");
                return false;
            }
            Logger.WriteDebug("BiNet Started!");
            return true;
        }

        public void ConnectToBroadCastServer()
        {
            BiNet?.SendBroadcast();
        }

        public void Update()
        {
            if (BiNet != null && BiNet.Net.IsRunning)
            {
                BiNet.Net.PollEvents();
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
            Logger.WriteDebug("BiNet Stopping...");
            BiNet?.Net.Stop();
            Logger.WriteDebug("BiNet Stopped!");
        }

        public static string PrintDetailedPeer(NetPeer peer)
        {
            return $" IpPort: {peer.ToString()}, PeerId: {peer.Id}, PeerRemoteId: {peer.RemoteId}";
        }
    }
}
