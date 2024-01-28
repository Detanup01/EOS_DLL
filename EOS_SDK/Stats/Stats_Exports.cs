using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOS_SDK.Stats
{
    public unsafe class Stats_Exports
    {
#if false

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Stats_CopyStatByIndex(IntPtr handle, IntPtr options, IntPtr outStat)
		{
			var _CopyStatByIndexOptions = Marshal.PtrToStructure<CopyStatByIndexOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Stats_CopyStatByName(IntPtr handle, IntPtr options, IntPtr outStat)
		{
			var _CopyStatByNameOptions = Marshal.PtrToStructure<CopyStatByNameOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static uint EOS_Stats_GetStatsCount(IntPtr handle, IntPtr options)
		{
			var _GetStatCountOptions = Marshal.PtrToStructure<GetStatCountOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Stats_IngestStat(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _IngestStatOptions = Marshal.PtrToStructure<IngestStatOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: Stats.OnIngestStatCompleteCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Stats_QueryStats(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _QueryStatsOptions = Marshal.PtrToStructure<QueryStatsOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: Stats.OnQueryStatsCompleteCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Stats_Stat_Release(IntPtr stat)
        {
        }
#endif
    }
}
