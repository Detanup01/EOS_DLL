using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace EOS_SDK.Sessions
{
    public unsafe class ActiveSession_Exports
    {
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static int EOS_ActiveSession_CopyInfo(nint handle, nint options, nint outActiveSessionInfo)
        {
            var _ActiveSessionCopyInfoOptions = Marshal.PtrToStructure<ActiveSessionCopyInfoOptions>(options);
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static nint EOS_ActiveSession_GetRegisteredPlayerByIndex(nint handle, nint options)
        {
            var _ActiveSessionGetRegisteredPlayerByIndexOptions = Marshal.PtrToStructure<ActiveSessionGetRegisteredPlayerByIndexOptions>(options);
            return nint.Zero;
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static uint EOS_ActiveSession_GetRegisteredPlayerCount(nint handle, nint options)
        {
            var _ActiveSessionGetRegisteredPlayerCountOptions = Marshal.PtrToStructure<ActiveSessionGetRegisteredPlayerCountOptions>(options);
            return 0;
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static void EOS_ActiveSession_Info_Release(nint activeSessionInfo)
        {
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static void EOS_ActiveSession_Release(nint activeSessionHandle)
        {
        }
    }
}
