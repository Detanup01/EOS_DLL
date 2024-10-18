using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOS_SDK.Reports
{
    public unsafe class Reports_Exports
    {
#if false
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static void EOS_Reports_SendPlayerBehaviorReport(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _SendPlayerBehaviorReportOptions = Marshal.PtrToStructure<SendPlayerBehaviorReportOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: Reports.OnSendPlayerBehaviorReportCompleteCallback
        }
#endif
    }
}
