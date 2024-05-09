using EOS_SDK;
using System.Runtime.InteropServices;

namespace test
{
    internal class NetTest
    {
        public struct LIST
        {
            public int Len;
            public IntPtr Ptr;
        }

        [DllImport("EOSSDK-Win64-Shipping")]
        public static extern int _NetTest_Start();

        [DllImport("EOSSDK-Win64-Shipping")]
        public static extern int _NetTest_Stop();

        [DllImport("EOSSDK-Win64-Shipping")]
        public static extern void _NetTest_Update();

        [DllImport("EOSSDK-Win64-Shipping")]
        public static extern IntPtr _NetTest_GetAccountIds();

        [DllImport("EOSSDK-Win64-Shipping")]
        public static extern int _NetTest_Ping(IntPtr userId);

        [DllImport("EOSSDK-Win64-Shipping")]
        public static extern void _NetTest_ConnectBroadcast();

        public static void StartTest()
        {
            Console.WriteLine(_NetTest_Start());
            bool Stop = false;
            Thread thread = new Thread(() =>
            {
                while (!Stop)
                {
                    _NetTest_Update();
                    Thread.Sleep(10);
                }
                    

            });
            thread.Start();
            _NetTest_ConnectBroadcast();
            sendping();
            string ret = "ret";
            while (ret != "q")
            {
                ret = Console.ReadLine().ToLower();
                if (ret == "ping")
                {
                    sendping();
                }
            }
            
            

            Console.WriteLine(_NetTest_Stop());
            Stop = true;
        }

        static void sendping()
        {
            var acs = _NetTest_GetAccountIds();
            Console.WriteLine("_NetTest_GetAccountIds:" + acs);
            if (acs != 0)
            {
                var list = Marshal.PtrToStructure<LIST>(acs);
                Console.WriteLine(list.Ptr + " " + list.Len);
                var accs = Helpers.ToStructArray<string>(list.Ptr, list.Len);
                foreach (var item in accs)
                {
                    Console.WriteLine(item);
                    _NetTest_Ping(Helpers.FromString(item));
                }
                Thread.Sleep(10);
            }
        }
    }
}
