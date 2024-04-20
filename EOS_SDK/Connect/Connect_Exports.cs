using EOS_SDK._Data;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace EOS_SDK.Connect
{
    public unsafe class Connect_Exports
    {
        #region Notify
        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong _EOS_Connect_AddNotifyAuthExpiration(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notification)
        {
            _log.Logger.WriteDebug($"{nameof(_EOS_Connect_AddNotifyAuthExpiration)} Called", Logging.LogCategory.Connect);
            AuthExpirationCallbackInfo authExpirationCallbackInfo = new()
            { 
                ClientData = clientData
            };
            return NotifyManager.AddNotify(nameof(_EOS_Connect_AddNotifyAuthExpiration), notification, authExpirationCallbackInfo);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void _EOS_Connect_RemoveNotifyAuthExpiration(IntPtr handle, ulong inId)
        {
            _log.Logger.WriteDebug($"{nameof(_EOS_Connect_RemoveNotifyAuthExpiration)} Called", Logging.LogCategory.Connect);
            NotifyManager.RemoveNotify(inId);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong _EOS_Connect_AddNotifyLoginStatusChanged(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notification)
        {
            _log.Logger.WriteDebug($"{nameof(_EOS_Connect_AddNotifyLoginStatusChanged)} Called", Logging.LogCategory.Connect);
            LoginStatusChangedCallbackInfo loginStatusChangedCallbackInfo = new()
            { 
                ClientData = clientData
            };
            return NotifyManager.AddNotify(nameof(_EOS_Connect_AddNotifyLoginStatusChanged), notification, loginStatusChangedCallbackInfo);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void _EOS_Connect_RemoveNotifyLoginStatusChanged(IntPtr handle, ulong inId)
        {
            _log.Logger.WriteDebug($"{nameof(_EOS_Connect_RemoveNotifyLoginStatusChanged)} Called", Logging.LogCategory.Connect);
            NotifyManager.RemoveNotify(inId);
        }
        #endregion
        #region IdToken
        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int _EOS_Connect_CopyIdToken(IntPtr handle, IntPtr options, IntPtr outIdToken)
        {
            var _CopyIdTokenOptions = Marshal.PtrToStructure<CopyIdTokenOptions>(options);
            IdToken idToken = new()
            { 
                ApiVersion = 1,
                
            };
            return (int)Result.Success;
        }
        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void _EOS_Connect_IdToken_Release(IntPtr idToken)
        {
            Helpers.Destroy<IdToken>(idToken);
        }
        #endregion
        #region ExternalAccountInfo
        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int _EOS_Connect_CopyProductUserExternalAccountByAccountId(IntPtr handle, IntPtr options, IntPtr outExternalAccountInfo)
        {
            var _CopyProductUserExternalAccountByAccountIdOptions = Marshal.PtrToStructure<CopyProductUserExternalAccountByAccountIdOptions>(options);
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int _EOS_Connect_CopyProductUserExternalAccountByAccountType(IntPtr handle, IntPtr options, IntPtr outExternalAccountInfo)
        {
            var _CopyProductUserExternalAccountByAccountTypeOptions = Marshal.PtrToStructure<CopyProductUserExternalAccountByAccountTypeOptions>(options);
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int _EOS_Connect_CopyProductUserExternalAccountByIndex(IntPtr handle, IntPtr options, IntPtr outExternalAccountInfo)
        {
            var _CopyProductUserExternalAccountByIndexOptions = Marshal.PtrToStructure<CopyProductUserExternalAccountByIndexOptions>(options);
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int _EOS_Connect_CopyProductUserInfo(IntPtr handle, IntPtr options, IntPtr outExternalAccountInfo)
        {
            var _CopyProductUserInfoOptions = Marshal.PtrToStructure<CopyProductUserInfoOptions>(options);
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void _EOS_Connect_ExternalAccountInfo_Release(IntPtr externalAccountInfo)
        {
        }

        #endregion
        #region DeviceId
        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void _EOS_Connect_CreateDeviceId(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
        {
            var _CreateDeviceIdOptions = Marshal.PtrToStructure<CreateDeviceIdOptions>(options);
            delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: Connect.OnCreateDeviceIdCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void _EOS_Connect_DeleteDeviceId(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
        {
            var _DeleteDeviceIdOptions = Marshal.PtrToStructure<DeleteDeviceIdOptions>(options);
            delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: Connect.OnDeleteDeviceIdCallback
        }

        #endregion
        #region Getters
        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr _EOS_Connect_GetExternalAccountMapping(IntPtr handle, IntPtr options)
        {
            var _GetExternalAccountMappingsOptions = Marshal.PtrToStructure<GetExternalAccountMappingsOptions>(options);
            return 0;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr _EOS_Connect_GetLoggedInUserByIndex(IntPtr handle, int index)
        {
            return 0;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int _EOS_Connect_GetLoggedInUsersCount(IntPtr handle)
        {
            return 0;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int _EOS_Connect_GetLoginStatus(IntPtr handle, IntPtr localUserId)
        {
            return (int)LoginStatus.NotLoggedIn;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static uint _EOS_Connect_GetProductUserExternalAccountCount(IntPtr handle, IntPtr options)
        {
            var _GetProductUserExternalAccountCountOptions = Marshal.PtrToStructure<GetProductUserExternalAccountCountOptions>(options);
            return 0;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int _EOS_Connect_GetProductUserIdMapping(IntPtr handle, IntPtr options, IntPtr outBuffer, int inOutBufferLength)
        {
            var _GetProductUserIdMappingOptions = Marshal.PtrToStructure<GetProductUserIdMappingOptions>(options);
            return (int)Result.Success;
        }
        #endregion
        #region Query
        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void _EOS_Connect_QueryExternalAccountMappings(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
        {
            var _QueryExternalAccountMappingsOptions = Marshal.PtrToStructure<QueryExternalAccountMappingsOptions>(options);
            delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: Connect.OnQueryExternalAccountMappingsCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void _EOS_Connect_QueryProductUserIdMappings(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
        {
            var _QueryProductUserIdMappingsOptions = Marshal.PtrToStructure<QueryProductUserIdMappingsOptions>(options);
            delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: Connect.OnQueryProductUserIdMappingsCallback
        }
        #endregion
        #region Un/Link
        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void _EOS_Connect_LinkAccount(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
        {
            var _LinkAccountOptions = Marshal.PtrToStructure<LinkAccountOptions>(options);
            delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: Connect.OnLinkAccountCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void _EOS_Connect_UnlinkAccount(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
        {
            var _UnlinkAccountOptions = Marshal.PtrToStructure<UnlinkAccountOptions>(options);
            delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: Connect.OnUnlinkAccountCallback
        }
        #endregion
        #region Create/Login
        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void _EOS_Connect_CreateUser(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
        {
            var _CreateUserOptions = Marshal.PtrToStructure<CreateUserOptions>(options);
            delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: Connect.OnCreateUserCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void _EOS_Connect_Login(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
        {
            var _LoginOptions = Marshal.PtrToStructure<LoginOptions>(options);
            delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: Connect.OnLoginCallback
        }
        #endregion
        #region Transfer
        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void _EOS_Connect_TransferDeviceIdAccount(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
        {
            var _TransferDeviceIdAccountOptions = Marshal.PtrToStructure<TransferDeviceIdAccountOptions>(options);
            delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: Connect.OnTransferDeviceIdAccountCallback
        }
        #endregion
        #region Verify
        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void _EOS_Connect_VerifyIdToken(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
        {
            var _VerifyIdTokenOptions = Marshal.PtrToStructure<VerifyIdTokenOptions>(options);
            delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: Connect.OnVerifyIdTokenCallback
        }
        #endregion
    }
}
