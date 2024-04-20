using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace EOS_SDK.ActiveSession
{
    public unsafe class ActiveSession_Exports
    {
        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int _EOS_ActiveSession_CopyInfo(IntPtr handle, IntPtr options, IntPtr outActiveSessionInfo)
        {
            var _ActiveSessionCopyInfoOptions = Marshal.PtrToStructure<ActiveSessionCopyInfoOptions>(options);
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr _EOS_ActiveSession_GetRegisteredPlayerByIndex(IntPtr handle, IntPtr options)
        {
            var _ActiveSessionGetRegisteredPlayerByIndexOptions = Marshal.PtrToStructure<ActiveSessionGetRegisteredPlayerByIndexOptions>(options);
            return IntPtr.Zero;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static uint _EOS_ActiveSession_GetRegisteredPlayerCount(IntPtr handle, IntPtr options)
        {
            var _ActiveSessionGetRegisteredPlayerCountOptions = Marshal.PtrToStructure<ActiveSessionGetRegisteredPlayerCountOptions>(options);
            return 0;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void _EOS_ActiveSession_Info_Release(IntPtr activeSessionInfo)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void _EOS_ActiveSession_Release(IntPtr activeSessionHandle)
        {
        }
    }
}
