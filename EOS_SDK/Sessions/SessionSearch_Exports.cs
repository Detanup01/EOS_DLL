using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOS_SDK.Sessions
{
    internal unsafe class SessionSearch_Exports
    {
#if false


        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static Result EOS_SessionSearch_CopySearchResultByIndex(IntPtr handle, IntPtr options, IntPtr outSessionHandle)
		{
			var _SessionSearchCopySearchResultByIndexOptions = Marshal.PtrToStructure<SessionSearchCopySearchResultByIndexOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static void EOS_SessionSearch_Find(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _SessionSearchFindOptions = Marshal.PtrToStructure<SessionSearchFindOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: Sessions.SessionSearchOnFindCallback
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static uint EOS_SessionSearch_GetSearchResultCount(IntPtr handle, IntPtr options)
		{
			var _SessionSearchGetSearchResultCountOptions = Marshal.PtrToStructure<SessionSearchGetSearchResultCountOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static void EOS_SessionSearch_Release(IntPtr sessionSearchHandle)
        {
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static Result EOS_SessionSearch_RemoveParameter(IntPtr handle, IntPtr options)
		{
			var _SessionSearchRemoveParameterOptions = Marshal.PtrToStructure<SessionSearchRemoveParameterOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static Result EOS_SessionSearch_SetMaxResults(IntPtr handle, IntPtr options)
		{
			var _SessionSearchSetMaxResultsOptions = Marshal.PtrToStructure<SessionSearchSetMaxResultsOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static Result EOS_SessionSearch_SetParameter(IntPtr handle, IntPtr options)
		{
			var _SessionSearchSetParameterOptions = Marshal.PtrToStructure<SessionSearchSetParameterOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static Result EOS_SessionSearch_SetSessionId(IntPtr handle, IntPtr options)
		{
			var _SessionSearchSetSessionIdOptions = Marshal.PtrToStructure<SessionSearchSetSessionIdOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static Result EOS_SessionSearch_SetTargetUserId(IntPtr handle, IntPtr options)
		{
			var _SessionSearchSetTargetUserIdOptions = Marshal.PtrToStructure<SessionSearchSetTargetUserIdOptions>(options);
        }

#endif
    }
}
