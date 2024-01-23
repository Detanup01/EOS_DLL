using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EOS_SDK.Others
{
    public unsafe class Common
    {
#if false
        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_ByteArray_ToString(IntPtr byteArray, uint length, IntPtr outBuffer, [Out] uint inOutBufferLength)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_ContinuanceToken_ToString(IntPtr continuanceToken, IntPtr outBuffer, [Out] int inOutBufferLength)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_EApplicationStatus_ToString(Platform.ApplicationStatus applicationStatus)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_ENetworkStatus_ToString(Platform.NetworkStatus networkStatus)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_EResult_IsOperationComplete(Result result)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_EResult_ToString(Result result)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_GetVersion()
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Initialize(IntPtr options)
        {
			var _InitializeOptions = Marshal.PtrToStructure<InitializeOptions>(options);
        }
#endif
    }
}
