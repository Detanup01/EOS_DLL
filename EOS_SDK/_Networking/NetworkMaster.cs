using LiteNetLib;
using System.Net;

namespace EOS_SDK._Networking
{
    internal class NetworkMaster
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
            Console.WriteLine("BiNet start");
            if (!_net.Start())
            {
                Console.WriteLine("BiNet start failed");
                return false;
            }

            return true;
        }

        public void ConnectToBroadCastServer()
        {
            BiNet?.SendBroadcast();
        }

        public List<IPAddress> GetAddresses()
        {
            List<IPAddress> addresses = new();
            BiNet?.Net.ConnectedPeerList.ForEach(x => addresses.Add(x.Address));
            Console.WriteLine("client addresses");
            foreach (var item in addresses)
            {
                Console.WriteLine(item.ToString());
            }
            return addresses;
        }

        public void Update()
        {
            if (BiNet != null && BiNet.Net.IsRunning)
            {
                BiNet.Net.PollEvents();
            }
        }

        public void Stop()
        {
            BiNet?.Net.Stop();
        }
    }
}
