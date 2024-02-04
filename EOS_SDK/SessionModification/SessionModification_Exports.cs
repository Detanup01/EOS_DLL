using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOS_SDK.SessionModification
{
    internal unsafe class SessionModification_Exports
    {
#if false


        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_SessionModification_AddAttribute(IntPtr handle, IntPtr options)
		{
			var _SessionModificationAddAttributeOptions = Marshal.PtrToStructure<SessionModificationAddAttributeOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_SessionModification_Release(IntPtr sessionModificationHandle)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_SessionModification_RemoveAttribute(IntPtr handle, IntPtr options)
		{
			var _SessionModificationRemoveAttributeOptions = Marshal.PtrToStructure<SessionModificationRemoveAttributeOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_SessionModification_SetAllowedPlatformIds(IntPtr handle, IntPtr options)
		{
			var _SessionModificationSetAllowedPlatformIdsOptions = Marshal.PtrToStructure<SessionModificationSetAllowedPlatformIdsOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_SessionModification_SetBucketId(IntPtr handle, IntPtr options)
		{
			var _SessionModificationSetBucketIdOptions = Marshal.PtrToStructure<SessionModificationSetBucketIdOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_SessionModification_SetHostAddress(IntPtr handle, IntPtr options)
		{
			var _SessionModificationSetHostAddressOptions = Marshal.PtrToStructure<SessionModificationSetHostAddressOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_SessionModification_SetInvitesAllowed(IntPtr handle, IntPtr options)
		{
			var _SessionModificationSetInvitesAllowedOptions = Marshal.PtrToStructure<SessionModificationSetInvitesAllowedOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_SessionModification_SetJoinInProgressAllowed(IntPtr handle, IntPtr options)
		{
			var _SessionModificationSetJoinInProgressAllowedOptions = Marshal.PtrToStructure<SessionModificationSetJoinInProgressAllowedOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_SessionModification_SetMaxPlayers(IntPtr handle, IntPtr options)
		{
			var _SessionModificationSetMaxPlayersOptions = Marshal.PtrToStructure<SessionModificationSetMaxPlayersOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_SessionModification_SetPermissionLevel(IntPtr handle, IntPtr options)
		{
			var _SessionModificationSetPermissionLevelOptions = Marshal.PtrToStructure<SessionModificationSetPermissionLevelOptions>(options);
        }

#endif
    }
}
