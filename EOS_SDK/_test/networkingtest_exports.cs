using EOS_SDK._Networking;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace EOS_SDK._test
{
    public unsafe class networkingtest_exports
    {
        static NetworkMaster? Master;

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void _NetTest_Ping(IntPtr ptr_UserId)
        {
            var UserId = Helpers.ToString(ptr_UserId);
            Master?.BiNet?.SendPingPacket(UserId.Remove(UserId.Length - 1, 1));
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void _NetTest_ConnectBroadcast()
        {
            Master?.ConnectToBroadCastServer();
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr _NetTest_GetAccountIds()
        {
            if (Master == null)
                return 0;
            if (Master.BiNet == null)
                return 0;
            var keys = Master.BiNet.AccountId_To_PeerId.Keys;
            if (keys == null)
                return 0;
            var array = Helpers.StringListToPtr(keys.ToList());
            var list = new LIST()
            { 
                Len = keys.ToArray().Length,
                Ptr = array
            };
            var ptr = Helpers.StructToPtr(list);
            return ptr;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int _NetTest_Start()
        {
            Master = new();
            Master.Start();
            return 1;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int _NetTest_Stop()
        {
            if (Master == null)
                return 1;
            Master.Stop();
            Master = null;
            return 1;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void _NetTest_Update()
        {
            Master?.Update();
        }

        public struct LIST
        {
            public int Len;
            public IntPtr Ptr;
        }
    }
}
