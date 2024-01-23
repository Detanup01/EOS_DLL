using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace EOS_SDK.ActiveSession
{
    public unsafe class ActiveSession_Exports
    {
        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_ActiveSession_CopyInfo(IntPtr handle, IntPtr options, IntPtr outActiveSessionInfo)
        {
            var _ActiveSessionCopyInfoOptionspublic = Marshal.PtrToStructure<ActiveSessionCopyInfoOptionspublic>(options);
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_ActiveSession_GetRegisteredPlayerByIndex(IntPtr handle, IntPtr options)
        {
            var _ActiveSessionGetRegisteredPlayerByIndexOptionspublic = Marshal.PtrToStructure<ActiveSessionGetRegisteredPlayerByIndexOptionspublic>(options);
            return IntPtr.Zero;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static uint EOS_ActiveSession_GetRegisteredPlayerCount(IntPtr handle, IntPtr options)
        {
            var _ActiveSessionGetRegisteredPlayerCountOptionspublic = Marshal.PtrToStructure<ActiveSessionGetRegisteredPlayerCountOptionspublic>(options);
            return 0;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_ActiveSession_Info_Release(IntPtr activeSessionInfo)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_ActiveSession_Release(IntPtr activeSessionHandle)
        {
        }
    }
}
