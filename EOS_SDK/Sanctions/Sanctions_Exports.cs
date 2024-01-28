using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOS_SDK.Sanctions
{
    public unsafe class Sanctions_Exports
    {
#if false

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Sanctions_CopyPlayerSanctionByIndex(IntPtr handle, IntPtr options, IntPtr outSanction)
		{
			var _CopyPlayerSanctionByIndexOptions = Marshal.PtrToStructure<CopyPlayerSanctionByIndexOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static uint EOS_Sanctions_GetPlayerSanctionCount(IntPtr handle, IntPtr options)
		{
			var _GetPlayerSanctionCountOptions = Marshal.PtrToStructure<GetPlayerSanctionCountOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Sanctions_PlayerSanction_Release(IntPtr sanction)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Sanctions_QueryActivePlayerSanctions(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _QueryActivePlayerSanctionsOptions = Marshal.PtrToStructure<QueryActivePlayerSanctionsOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: Sanctions.OnQueryActivePlayerSanctionsCallback
        }
#endif
    }
}
