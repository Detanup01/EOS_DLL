using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace EOS_SDK.Connect
{
    public unsafe class Connect_Exports
    {

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_Connect_AddNotifyAuthExpiration(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notification)
        {
            var _AddNotifyAuthExpirationOptions = Marshal.PtrToStructure<AddNotifyAuthExpirationOptions>(options);
            delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)notification; //Delegate Class was: Connect.OnAuthExpirationCallback
            return 0;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_Connect_AddNotifyLoginStatusChanged(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notification)
        {
            var _AddNotifyLoginStatusChangedOptions = Marshal.PtrToStructure<AddNotifyLoginStatusChangedOptions>(options);
            delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)notification; //Delegate Class was: Connect.OnLoginStatusChangedCallback
            return 0;
        }



        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_Connect_CopyIdToken(IntPtr handle, IntPtr options, IntPtr outIdToken)
        {
            var _CopyIdTokenOptions = Marshal.PtrToStructure<CopyIdTokenOptions>(options);
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_Connect_CopyProductUserExternalAccountByAccountId(IntPtr handle, IntPtr options, IntPtr outExternalAccountInfo)
        {
            var _CopyProductUserExternalAccountByAccountIdOptions = Marshal.PtrToStructure<CopyProductUserExternalAccountByAccountIdOptions>(options);
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_Connect_CopyProductUserExternalAccountByAccountType(IntPtr handle, IntPtr options, IntPtr outExternalAccountInfo)
        {
            var _CopyProductUserExternalAccountByAccountTypeOptions = Marshal.PtrToStructure<CopyProductUserExternalAccountByAccountTypeOptions>(options);
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_Connect_CopyProductUserExternalAccountByIndex(IntPtr handle, IntPtr options, IntPtr outExternalAccountInfo)
        {
            var _CopyProductUserExternalAccountByIndexOptions = Marshal.PtrToStructure<CopyProductUserExternalAccountByIndexOptions>(options);
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_Connect_CopyProductUserInfo(IntPtr handle, IntPtr options, IntPtr outExternalAccountInfo)
        {
            var _CopyProductUserInfoOptions = Marshal.PtrToStructure<CopyProductUserInfoOptions>(options);
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Connect_CreateDeviceId(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
        {
            var _CreateDeviceIdOptions = Marshal.PtrToStructure<CreateDeviceIdOptions>(options);
            delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: Connect.OnCreateDeviceIdCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Connect_CreateUser(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
        {
            var _CreateUserOptions = Marshal.PtrToStructure<CreateUserOptions>(options);
            delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: Connect.OnCreateUserCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Connect_DeleteDeviceId(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
        {
            var _DeleteDeviceIdOptions = Marshal.PtrToStructure<DeleteDeviceIdOptions>(options);
            delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: Connect.OnDeleteDeviceIdCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Connect_ExternalAccountInfo_Release(IntPtr externalAccountInfo)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_Connect_GetExternalAccountMapping(IntPtr handle, IntPtr options)
        {
            var _GetExternalAccountMappingsOptions = Marshal.PtrToStructure<GetExternalAccountMappingsOptions>(options);
            return 0;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_Connect_GetLoggedInUserByIndex(IntPtr handle, int index)
        {
            return 0;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_Connect_GetLoggedInUsersCount(IntPtr handle)
        {
            return 0;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_Connect_GetLoginStatus(IntPtr handle, IntPtr localUserId)
        {
            return (int)LoginStatus.NotLoggedIn;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static uint EOS_Connect_GetProductUserExternalAccountCount(IntPtr handle, IntPtr options)
        {
            var _GetProductUserExternalAccountCountOptions = Marshal.PtrToStructure<GetProductUserExternalAccountCountOptions>(options);
            return 0;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_Connect_GetProductUserIdMapping(IntPtr handle, IntPtr options, IntPtr outBuffer, int inOutBufferLength)
        {
            var _GetProductUserIdMappingOptions = Marshal.PtrToStructure<GetProductUserIdMappingOptions>(options);
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Connect_IdToken_Release(IntPtr idToken)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Connect_LinkAccount(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
        {
            var _LinkAccountOptions = Marshal.PtrToStructure<LinkAccountOptions>(options);
            delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: Connect.OnLinkAccountCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Connect_Login(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
        {
            var _LoginOptions = Marshal.PtrToStructure<LoginOptions>(options);
            delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: Connect.OnLoginCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Connect_QueryExternalAccountMappings(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
        {
            var _QueryExternalAccountMappingsOptions = Marshal.PtrToStructure<QueryExternalAccountMappingsOptions>(options);
            delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: Connect.OnQueryExternalAccountMappingsCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Connect_QueryProductUserIdMappings(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
        {
            var _QueryProductUserIdMappingsOptions = Marshal.PtrToStructure<QueryProductUserIdMappingsOptions>(options);
            delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: Connect.OnQueryProductUserIdMappingsCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Connect_RemoveNotifyAuthExpiration(IntPtr handle, ulong inId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Connect_RemoveNotifyLoginStatusChanged(IntPtr handle, ulong inId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Connect_TransferDeviceIdAccount(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
        {
            var _TransferDeviceIdAccountOptions = Marshal.PtrToStructure<TransferDeviceIdAccountOptions>(options);
            delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: Connect.OnTransferDeviceIdAccountCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Connect_UnlinkAccount(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
        {
            var _UnlinkAccountOptions = Marshal.PtrToStructure<UnlinkAccountOptions>(options);
            delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: Connect.OnUnlinkAccountCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Connect_VerifyIdToken(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
        {
            var _VerifyIdTokenOptions = Marshal.PtrToStructure<VerifyIdTokenOptions>(options);
            delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: Connect.OnVerifyIdTokenCallback
        }
    }
}
