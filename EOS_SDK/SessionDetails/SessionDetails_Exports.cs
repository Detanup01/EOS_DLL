using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOS_SDK.SessionDetails
{
    internal unsafe class SessionDetails_Exports
    {
#if false

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static void EOS_SessionDetails_Attribute_Release(IntPtr sessionAttribute)
        {
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static Result EOS_SessionDetails_CopyInfo(IntPtr handle, IntPtr options, IntPtr outSessionInfo)
		{
			var _SessionDetailsCopyInfoOptions = Marshal.PtrToStructure<SessionDetailsCopyInfoOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static Result EOS_SessionDetails_CopySessionAttributeByIndex(IntPtr handle, IntPtr options, IntPtr outSessionAttribute)
		{
			var _SessionDetailsCopySessionAttributeByIndexOptions = Marshal.PtrToStructure<SessionDetailsCopySessionAttributeByIndexOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static Result EOS_SessionDetails_CopySessionAttributeByKey(IntPtr handle, IntPtr options, IntPtr outSessionAttribute)
		{
			var _SessionDetailsCopySessionAttributeByKeyOptions = Marshal.PtrToStructure<SessionDetailsCopySessionAttributeByKeyOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static uint EOS_SessionDetails_GetSessionAttributeCount(IntPtr handle, IntPtr options)
		{
			var _SessionDetailsGetSessionAttributeCountOptions = Marshal.PtrToStructure<SessionDetailsGetSessionAttributeCountOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static void EOS_SessionDetails_Info_Release(IntPtr sessionInfo)
        {
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static void EOS_SessionDetails_Release(IntPtr sessionHandle)
        {
        }


#endif
    }
}
