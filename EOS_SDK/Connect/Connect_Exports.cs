using EOS_SDK._Data;
using EOS_SDK.Enums;
using EOS_SDK.Version;
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
            return NotifyManager.AddNotify("Connect_AuthExpiration", notification, authExpirationCallbackInfo);
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
            _log.Logger.WriteDebug($"{nameof(_EOS_Connect_CopyIdToken)} Called", Logging.LogCategory.Connect);
            var _CopyIdTokenOptions = Marshal.PtrToStructure<CopyIdTokenOptions>(options);
            IdToken idToken = new()
            { 
                ApiVersion = Versions.CopyidtokenApiLatest_Connect,
                ProductUserId = Helpers.FromString(Config.GetConfig().EpicProductUserId),
                JsonWebToken = 0,
            };
            Helpers.StructWriteOut(idToken, outIdToken);
            return (int)Result.Success;
        }
        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void _EOS_Connect_IdToken_Release(IntPtr idToken)
        {
            _log.Logger.WriteDebug($"{nameof(_EOS_Connect_IdToken_Release)} Called", Logging.LogCategory.Connect);
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
            _log.Logger.WriteDebug($"{nameof(_EOS_Connect_CreateDeviceId)} Called", Logging.LogCategory.Connect);
            var _CreateDeviceIdOptions = Marshal.PtrToStructure<CreateDeviceIdOptions>(options);
            delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: Connect.OnCreateDeviceIdCallback
            CreateDeviceIdCallbackInfo createDeviceIdCallbackInfo = new()
            {
                ClientData = clientData,
                ResultCode = Result.Success
            };
            CallbackManager.AddCallback(completionDelegate, createDeviceIdCallbackInfo, nameof(_EOS_Connect_CreateDeviceId));
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void _EOS_Connect_DeleteDeviceId(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
        {
            _log.Logger.WriteDebug($"{nameof(_EOS_Connect_DeleteDeviceId)} Called", Logging.LogCategory.Connect);
            var _DeleteDeviceIdOptions = Marshal.PtrToStructure<DeleteDeviceIdOptions>(options);
            delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: Connect.OnDeleteDeviceIdCallback
            DeleteDeviceIdCallbackInfo deleteDeviceIdCallbackInfo = new()
            { 
                ClientData = clientData,
                ResultCode = Result.Success
            };
            CallbackManager.AddCallback(completionDelegate, deleteDeviceIdCallbackInfo, nameof(_EOS_Connect_DeleteDeviceId));
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
            _log.Logger.WriteDebug($"{nameof(_EOS_Connect_CreateUser)} Called", Logging.LogCategory.Connect);
            //var _CreateUserOptions = Marshal.PtrToStructure<CreateUserOptions>(options);
            delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: Connect.OnCreateUserCallback
            CreateUserCallbackInfo createUserCallbackInfo = new()
            { 
                ClientData = clientData,
                ResultCode = Result.Success,
                LocalUserId = Helpers.FromString(Config.GetConfig().EpicProductUserId)
            }; 
            @delegate(Helpers.StructToPtr(createUserCallbackInfo));
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void _EOS_Connect_Login(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
        {
            _log.Logger.WriteDebug($"{nameof(_EOS_Connect_Login)} Called", Logging.LogCategory.Connect);
            //var _LoginOptions = Marshal.PtrToStructure<LoginOptions>(options);
            delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: Connect.OnLoginCallback
            LoginCallbackInfo loginCallbackInfo = new()
            { 
                ClientData = clientData,
                ContinuanceToken = 0,
                ResultCode = Result.Success,
                LocalUserId = Helpers.FromString(Config.GetConfig().EpicProductUserId)
            };
            @delegate(Helpers.StructToPtr(loginCallbackInfo));
        }
        #endregion
        #region Transfer
        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void _EOS_Connect_TransferDeviceIdAccount(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
        {
            _log.Logger.WriteDebug($"{nameof(_EOS_Connect_TransferDeviceIdAccount)} Called", Logging.LogCategory.Connect);
            //var _TransferDeviceIdAccountOptions = Marshal.PtrToStructure<TransferDeviceIdAccountOptions>(options);
            delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: Connect.OnTransferDeviceIdAccountCallback
            TransferDeviceIdAccountCallbackInfo transferDeviceIdAccountCallbackInfo = new()
            { 
                ClientData = clientData,
                LocalUserId = Helpers.FromString(Config.GetConfig().EpicProductUserId),
                ResultCode = Result.Success
            };
            @delegate(Helpers.StructToPtr(transferDeviceIdAccountCallbackInfo));
        }
        #endregion
        #region Verify
        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void _EOS_Connect_VerifyIdToken(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
        {
            var _VerifyIdTokenOptions = Marshal.PtrToStructure<VerifyIdTokenOptions>(options);
            var token = Marshal.PtrToStructure<IdToken>(_VerifyIdTokenOptions.IdToken);
            var str = Helpers.ToString(token.JsonWebToken);
            var jwtToken = JWTHelper.GetToken(str);
            delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: Connect.OnVerifyIdTokenCallback
            VerifyIdTokenCallbackInfo verifyIdTokenCallbackInfo = new() 
            { 
                AccountId = Helpers.FromString(jwtToken.sub),
                AccountIdType = ExternalAccountType.Epic,
                DeploymentId = Helpers.FromString(jwtToken.pfdid),
                DeviceType = 0,
                SandboxId = Helpers.FromString(jwtToken.pfsid),
                ClientData = clientData,
                ClientId = Helpers.FromString(jwtToken.aud),
                IsAccountInfoPresent = 0,
                Platform = Helpers.FromString("Epic"),
                ProductId = Helpers.FromString(jwtToken.pfpid),
                ProductUserId = 0,
                ResultCode = Result.Success
            };
            @delegate(Helpers.StructToPtr(verifyIdTokenCallbackInfo));
        }
        #endregion
    }
}
