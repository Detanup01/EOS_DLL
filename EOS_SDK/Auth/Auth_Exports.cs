﻿using EOS_SDK._Data;
using EOS_SDK.Enums;
using EOS_SDK.Version;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace EOS_SDK.Auth;
#if false
public unsafe class Auth_Exports
{
    #region Notify
    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
    public static ulong EOS_Auth_AddNotifyLoginStatusChanged(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notification)
    {
        _log.Logger.WriteDebug($"{nameof(EOS_Auth_AddNotifyLoginStatusChanged)} Called", Logging.LogCategory.Auth);
        if (!EOS_Main.GetPlatform().CheckArgs(handle, options, clientData))
            return 0;
        var phandler = EOS_Main.GetPlatform().GetHandler<Auth_Handler>(handle);
        if (phandler == null)
            return 0;
        //var _AddNotifyLoginStatusChangedOptions = Marshal.PtrToStructure<AddNotifyLoginStatusChangedOptions>(options);
        LoginStatusChangedCallbackInfo loginStatusChangedCallbackInfo = new()
        {
            ClientData = clientData,
            PrevStatus = phandler.GetLoginStatus()
        };

        return NotifyManager.AddNotify("AuthNotifyLoginStatus", notification, loginStatusChangedCallbackInfo);
    }

    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
    public static void EOS_Auth_RemoveNotifyLoginStatusChanged(IntPtr handle, ulong inId)
    {
        _log.Logger.WriteDebug($"{nameof(EOS_Auth_RemoveNotifyLoginStatusChanged)} Called", Logging.LogCategory.Auth);
        var phandler = EOS_Main.GetPlatform().GetHandler<Auth_Handler>(handle);
        if (phandler == null)
            return;
        NotifyManager.RemoveNotify(inId);
    }
    #endregion
    #region IdToken
    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
    public static int EOS_Auth_CopyIdToken(IntPtr handle, IntPtr options, IntPtr outIdToken)
    {
        _log.Logger.WriteDebug($"{nameof(EOS_Auth_CopyIdToken)} Called", Logging.LogCategory.Auth);
        if (!EOS_Main.GetPlatform().CheckArgs(handle, options))
            return (int)Result.InvalidParameters;
        var phandler = EOS_Main.GetPlatform().GetHandler<Auth_Handler>(handle);
        if (phandler == null)
            return (int)Result.InvalidParameters;
        var _CopyIdTokenOptions = Marshal.PtrToStructure<CopyIdTokenOptions>(options);
        _log.Logger.WriteDebug($"{nameof(CopyIdTokenOptions)}: {_CopyIdTokenOptions.ToString()}", Logging.LogCategory.Auth);
        IdToken idToken = new()
        { 
            ApiVersion = Versions.IdtokenApiLatest_Auth,
            AccountId = Helpers.FromString(phandler.AccountId),
            JsonWebToken = Helpers.FromString(JWTHelper.CreateToken())
        };
        Helpers.StructWriteOut(idToken, outIdToken);
        return (int)Result.Success;
    }

    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
    public static void EOS_Auth_QueryIdToken(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
    {
        _log.Logger.WriteDebug($"{nameof(EOS_Auth_QueryIdToken)} Called", Logging.LogCategory.Auth);
        if (!EOS_Main.GetPlatform().CheckArgs(handle, options, completionDelegate))
            return;
        var phandler = EOS_Main.GetPlatform().GetHandler<Auth_Handler>(handle);
        if (phandler == null)
            return;
        var _QueryIdTokenOptions = Marshal.PtrToStructure<QueryIdTokenOptions>(options);
        _log.Logger.WriteDebug($"{nameof(QueryIdTokenOptions)}: {_QueryIdTokenOptions.ToString()}", Logging.LogCategory.Auth);
        delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: Auth.OnQueryIdTokenCallback
        QueryIdTokenCallbackInfo queryIdTokenCallbackInfo = new()
        { 
            ClientData = clientData,
            LocalUserId = _QueryIdTokenOptions.LocalUserId,
            ResultCode = Result.Success,
            TargetAccountId = Helpers.FromString(phandler.AccountId),
        };
        @delegate(Helpers.StructToPtr(queryIdTokenCallbackInfo));
    }

    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
    public static void EOS_Auth_IdToken_Release(IntPtr idToken)
    {
        _log.Logger.WriteDebug($"{nameof(EOS_Auth_IdToken_Release)} Called", Logging.LogCategory.Auth);
        if (idToken == IntPtr.Zero)
            return;
        Marshal.DestroyStructure<IdToken>(idToken);
    }
    #endregion
    #region AuthToken
    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
    public static int EOS_Auth_CopyUserAuthToken(IntPtr handle, IntPtr options, IntPtr localUserId, IntPtr outUserAuthToken)
    {
        _log.Logger.WriteDebug($"{nameof(EOS_Auth_CopyUserAuthToken)} Called", Logging.LogCategory.Auth);
        if (!EOS_Main.GetPlatform().CheckArgs(handle, options, localUserId))
            return (int)Result.InvalidParameters;
        var phandler = EOS_Main.GetPlatform().GetHandler<Auth_Handler>(handle);
        if (phandler == null)
            return (int)Result.InvalidParameters;
        //var _CopyUserAuthTokenOptions = Marshal.PtrToStructure<CopyUserAuthTokenOptions>(options);
        var auth_refresh = JWTHelper.CreateAuthRefresh();
        Token token = new()
        {
            AccessToken = Helpers.FromString(auth_refresh.Auth),
            AccountId = Helpers.FromString(phandler.AccountId),
            ApiVersion = Versions.CopyuserauthtokenApiLatest,
            AuthType = AuthTokenType.User,
            App = Helpers.FromString(Config.GetConfig().AppId),
            ClientId = EOS_Main.GetPlatform().ClientCredentials.ClientId,
            RefreshToken = Helpers.FromString(auth_refresh.Refresh),
            ExpiresIn = TimeHelper.GetEpochTime(auth_refresh.now.AddSeconds(7200)),
            ExpiresAt = Helpers.FromString(auth_refresh.now.AddSeconds(7200).ToUniversalTime().ToString("o")),
            RefreshExpiresAt = TimeHelper.GetEpochTime(auth_refresh.now.AddSeconds(28800)),
            RefreshExpiresIn = Helpers.FromString(auth_refresh.now.AddSeconds(28800).ToUniversalTime().ToString("o"))
        };
        Helpers.StructWriteOut(token, outUserAuthToken);
        return (int)Result.Success;
    }

    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
    public static void EOS_Auth_Token_Release(IntPtr authToken)
    {
        _log.Logger.WriteDebug($"{nameof(EOS_Auth_Token_Release)} Called", Logging.LogCategory.Auth);
        if (authToken == IntPtr.Zero)
            return;
        Marshal.DestroyStructure<Token>(authToken);

    }
    #endregion
    #region LoggedInAccount
    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
    public static IntPtr EOS_Auth_GetLoggedInAccountByIndex(IntPtr handle, int index)
    {
        _log.Logger.WriteDebug($"{nameof(EOS_Auth_GetLoggedInAccountByIndex)} Called", Logging.LogCategory.Auth);
        if (handle == IntPtr.Zero)
            return IntPtr.Zero;
        var phandler = EOS_Main.GetPlatform().GetHandler<Auth_Handler>(handle);
        if (phandler == null)
            return IntPtr.Zero;
        if (phandler.GetLoginStatus() == LoginStatus.LoggedIn)
            return Helpers.FromString(phandler.AccountId);
        return IntPtr.Zero;
    }

    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
    public static int EOS_Auth_GetLoggedInAccountsCount(IntPtr handle)
    {
        _log.Logger.WriteDebug($"{nameof(EOS_Auth_GetLoggedInAccountsCount)} Called", Logging.LogCategory.Auth);
        if (handle == IntPtr.Zero)
            return 0;
        var phandler = EOS_Main.GetPlatform().GetHandler<Auth_Handler>(handle);
        if (phandler == null)
            return 0;
        if (phandler.GetLoginStatus() == LoginStatus.LoggedIn)
            return 1;
        return 0;
    }
    #endregion
    #region MergedAccount
    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
    public static IntPtr EOS_Auth_GetMergedAccountByIndex(IntPtr handle, IntPtr localUserId, uint index)
    {
        _log.Logger.WriteDebug($"{nameof(EOS_Auth_GetMergedAccountByIndex)} Called", Logging.LogCategory.Auth);
        if (handle == IntPtr.Zero)
            return IntPtr.Zero;
        var phandler = EOS_Main.GetPlatform().GetHandler<Auth_Handler>(handle);
        if (phandler == null)
            return IntPtr.Zero;
        if (phandler.GetLoginStatus() == LoginStatus.LoggedIn)
            return Helpers.FromString(phandler.AccountId);
        return IntPtr.Zero;
    }

    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
    public static uint EOS_Auth_GetMergedAccountsCount(IntPtr handle, IntPtr localUserId)
    {
        _log.Logger.WriteDebug($"{nameof(EOS_Auth_GetMergedAccountsCount)} Called", Logging.LogCategory.Auth);
        return 0;
    }
    #endregion
    #region Link, Login , LogOut
    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
    public static void EOS_Auth_LinkAccount(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
    {
        _log.Logger.WriteDebug($"{nameof(EOS_Auth_LinkAccount)} Called", Logging.LogCategory.Auth);
        if (completionDelegate == IntPtr.Zero)
            return;
        var _LinkAccountOptions = Marshal.PtrToStructure<LinkAccountOptions>(options);
        if (handle == IntPtr.Zero)
            return;
        var phandler = EOS_Main.GetPlatform().GetHandler<Auth_Handler>(handle);
        if (phandler == null)
            return;
        delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: Auth.OnLinkAccountCallback
        var userid_ = Helpers.FromString(phandler.AccountId);
        LinkAccountCallbackInfo linkAccountCallbackInfo = new()
        { 
            ClientData = clientData,
            ResultCode = Result.Success,
            LocalUserId = _LinkAccountOptions.LocalUserId,
            SelectedAccountId = userid_
        };
        @delegate(Helpers.StructToPtr(linkAccountCallbackInfo));
    }

    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
    public static void EOS_Auth_Login(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
    {
        _log.Logger.WriteDebug($"{nameof(EOS_Auth_Login)} Called", Logging.LogCategory.Auth);
        if (completionDelegate == IntPtr.Zero)
            return;
        var phandler = EOS_Main.GetPlatform().GetHandler<Auth_Handler>(handle);
        if (phandler == null)
            return;
        /*
        var version = Helpers.GetVersionFromStructPTR(options);

        if (version == 3)
        {
            var _LoginOptions3 = Marshal.PtrToStructure<LoginOptionsV3>(options);
        }
        else
        {
            var _LoginOptions2 = Marshal.PtrToStructure<LoginOptionsV2>(options);
        }

        var _LoginOptions = Marshal.PtrToStructure<LoginOptionsV3>(options);
        */
        var userid_ = Helpers.FromString(phandler.AccountId);
        LoginCallbackInfo loginCallbackInfo = new()
        {
            ClientData = clientData,
            ResultCode = Result.Success,
            LocalUserId = userid_,
            SelectedAccountId = userid_
        };
        CallbackManager.AddCallback(completionDelegate, loginCallbackInfo, nameof(EOS_Auth_Login));
        phandler.TriggerStateChange(true, userid_);
    }

    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
    public static void EOS_Auth_Logout(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
    {
        _log.Logger.WriteDebug($"{nameof(EOS_Auth_Logout)} Called", Logging.LogCategory.Auth);
        if (completionDelegate == IntPtr.Zero)
            return;
        var phandler = EOS_Main.GetPlatform().GetHandler<Auth_Handler>(handle);
        if (phandler == null)
            return;
        var _LogoutOptions = Marshal.PtrToStructure<LogoutOptions>(options);
        LogoutCallbackInfo logoutCallbackInfo = new()
        { 
            ClientData = clientData,
            ResultCode = Result.Success,
            LocalUserId = _LogoutOptions.LocalUserId
        };
        CallbackManager.AddCallback(completionDelegate, logoutCallbackInfo, nameof(EOS_Auth_Login));
        phandler.TriggerStateChange(false, _LogoutOptions.LocalUserId);
    }
    #endregion
    #region Verify
    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
    public static void EOS_Auth_VerifyIdToken(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
    {
        _log.Logger.WriteDebug($"{nameof(EOS_Auth_VerifyIdToken)} Called", Logging.LogCategory.Auth);
        if (completionDelegate == IntPtr.Zero)
            return;
        var _VerifyIdTokenOptions = Marshal.PtrToStructure<VerifyIdTokenOptions>(options);
        delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: Auth.OnVerifyIdTokenCallback

        VerifyIdTokenCallbackInfo verifyIdTokenCallbackInfo = new()
        { 
            ResultCode = Result.Success,
            ClientData = clientData,
        };
        @delegate(Helpers.StructToPtr(verifyIdTokenCallbackInfo));
    }

    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
    public static void EOS_Auth_VerifyUserAuth(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
    {
        _log.Logger.WriteDebug($"{nameof(EOS_Auth_VerifyUserAuth)} Called", Logging.LogCategory.Auth);
        if (completionDelegate == IntPtr.Zero)
            return;
        var _VerifyUserAuthOptions = Marshal.PtrToStructure<VerifyUserAuthOptions>(options);
        delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: Auth.OnVerifyUserAuthCallback

        VerifyUserAuthCallbackInfo verifyUserAuthCallbackInfo = new() 
        {
            ResultCode = Result.Success,
            ClientData = clientData,
        };
        @delegate(Helpers.StructToPtr(verifyUserAuthCallbackInfo));
    }
    #endregion
    #region Etc
    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
    public static int EOS_Auth_GetSelectedAccountId(IntPtr handle, IntPtr localUserId, IntPtr outSelectedAccountId)
    {
        _log.Logger.WriteDebug($"{nameof(EOS_Auth_GetSelectedAccountId)} Called", Logging.LogCategory.Auth);
        if (outSelectedAccountId == IntPtr.Zero)
            return (int)Result.InvalidParameters;
        Helpers.StringWriteOut(Auth_Handler.GetAccountId(), outSelectedAccountId);
        return (int)Result.Success;
    }

    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
    public static int EOS_Auth_GetLoginStatus(IntPtr handle, IntPtr localUserId)
    {
        _log.Logger.WriteDebug($"{nameof(EOS_Auth_GetLoginStatus)} Called", Logging.LogCategory.Auth);
        return (int)Auth_Handler.GetLoginStatus();
    }

    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
    public static void EOS_Auth_DeletePersistentAuth(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
    {
        _log.Logger.WriteDebug($"{nameof(EOS_Auth_DeletePersistentAuth)} Called", Logging.LogCategory.Auth);
        if (completionDelegate == IntPtr.Zero)
            return;
        //var _DeletePersistentAuthOptions = Marshal.PtrToStructure<DeletePersistentAuthOptions>(options);
        delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: Auth.OnDeletePersistentAuthCallback

        DeletePersistentAuthCallbackInfo deletePersistentAuthCallbackInfo = new()
        { 
            ClientData = clientData,
            ResultCode = Result.Success
        };
        @delegate(Helpers.StructToPtr(deletePersistentAuthCallbackInfo));
    }
    #endregion
}
#endif