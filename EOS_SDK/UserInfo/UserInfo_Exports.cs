using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOS_SDK.UserInfo
{
    public unsafe class UserInfo_Exports
    {
#if false
        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_UserInfo_BestDisplayName_Release(IntPtr bestDisplayName)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_UserInfo_CopyBestDisplayName(IntPtr handle, IntPtr options, IntPtr outBestDisplayName)
		{
			var _CopyBestDisplayNameOptions = Marshal.PtrToStructure<CopyBestDisplayNameOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_UserInfo_CopyBestDisplayNameWithPlatform(IntPtr handle, IntPtr options, IntPtr outBestDisplayName)
		{
			var _CopyBestDisplayNameWithPlatformOptions = Marshal.PtrToStructure<CopyBestDisplayNameWithPlatformOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_UserInfo_CopyExternalUserInfoByAccountId(IntPtr handle, IntPtr options, IntPtr outExternalUserInfo)
		{
			var _CopyExternalUserInfoByAccountIdOptions = Marshal.PtrToStructure<CopyExternalUserInfoByAccountIdOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_UserInfo_CopyExternalUserInfoByAccountType(IntPtr handle, IntPtr options, IntPtr outExternalUserInfo)
		{
			var _CopyExternalUserInfoByAccountTypeOptions = Marshal.PtrToStructure<CopyExternalUserInfoByAccountTypeOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_UserInfo_CopyExternalUserInfoByIndex(IntPtr handle, IntPtr options, IntPtr outExternalUserInfo)
		{
			var _CopyExternalUserInfoByIndexOptions = Marshal.PtrToStructure<CopyExternalUserInfoByIndexOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_UserInfo_CopyUserInfo(IntPtr handle, IntPtr options, IntPtr outUserInfo)
		{
			var _CopyUserInfoOptions = Marshal.PtrToStructure<CopyUserInfoOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_UserInfo_ExternalUserInfo_Release(IntPtr externalUserInfo)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static uint EOS_UserInfo_GetExternalUserInfoCount(IntPtr handle, IntPtr options)
		{
			var _GetExternalUserInfoCountOptions = Marshal.PtrToStructure<GetExternalUserInfoCountOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static uint EOS_UserInfo_GetLocalPlatformType(IntPtr handle, IntPtr options)
		{
			var _GetLocalPlatformTypeOptions = Marshal.PtrToStructure<GetLocalPlatformTypeOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_UserInfo_QueryUserInfo(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _QueryUserInfoOptions = Marshal.PtrToStructure<QueryUserInfoOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: UserInfo.OnQueryUserInfoCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_UserInfo_QueryUserInfoByDisplayName(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _QueryUserInfoByDisplayNameOptions = Marshal.PtrToStructure<QueryUserInfoByDisplayNameOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: UserInfo.OnQueryUserInfoByDisplayNameCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_UserInfo_QueryUserInfoByExternalAccount(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _QueryUserInfoByExternalAccountOptions = Marshal.PtrToStructure<QueryUserInfoByExternalAccountOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: UserInfo.OnQueryUserInfoByExternalAccountCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_UserInfo_Release(IntPtr userInfo)
        {
        }
#endif
    }
}
