using LiteNetLib;

namespace Broadcast_Server
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var BServer = new BServer();

            NetManager _net = new NetManager(BServer)
            {
                UnconnectedMessagesEnabled = true,
                BroadcastReceiveEnabled = true,
                IPv6Enabled = false,
                ChannelsCount = 32
            };
            BServer.Server = _net;
            Console.WriteLine("BServer start");
            if (!_net.Start())
            {
                Console.WriteLine("BServer start failed");
                return;
            }
            bool Stop = false;
            Thread thread = new Thread(() => 
            { 
                if (!Stop)
                    BServer.Server.PollEvents(); 
                
            });
            thread.Start();
            while (Console.ReadLine().ToLower() != "q")
            {
            }
            Stop = true;
            thread.Join(10);
            BServer.Server.Stop();
            Console.WriteLine("BServer stopped");
        }
    }
}
