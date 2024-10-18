using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOS_SDK.Metrics
{
    public unsafe class Metrics_Exports
    {
#if false
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static Result EOS_Metrics_BeginPlayerSession(IntPtr handle, IntPtr options)
		{
			var _BeginPlayerSessionOptions = Marshal.PtrToStructure<BeginPlayerSessionOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static Result EOS_Metrics_EndPlayerSession(IntPtr handle, IntPtr options)
		{
			var _EndPlayerSessionOptions = Marshal.PtrToStructure<EndPlayerSessionOptions>(options);
        }
#endif
    }
}
