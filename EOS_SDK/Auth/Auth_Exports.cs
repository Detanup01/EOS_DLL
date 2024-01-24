using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace EOS_SDK.Auth
{
    public unsafe class Auth_Exports
    {
        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_Auth_AddNotifyLoginStatusChanged(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notification)
        {
            var _AddNotifyLoginStatusChangedOptions = Marshal.PtrToStructure<AddNotifyLoginStatusChangedOptions>(options);
            delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)notification; //Delegate Class was: Auth.OnLoginStatusChangedCallback
            return 0;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_Auth_CopyIdToken(IntPtr handle, IntPtr options, IntPtr outIdToken)
        {
            var _CopyIdTokenOptions = Marshal.PtrToStructure<CopyIdTokenOptions>(options);
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_Auth_CopyUserAuthToken(IntPtr handle, IntPtr options, IntPtr localUserId, IntPtr outUserAuthToken)
        {
            var _CopyUserAuthTokenOptions = Marshal.PtrToStructure<CopyUserAuthTokenOptions>(options);
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Auth_DeletePersistentAuth(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
        {
            var _DeletePersistentAuthOptions = Marshal.PtrToStructure<DeletePersistentAuthOptions>(options);
            delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: Auth.OnDeletePersistentAuthCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_Auth_GetLoggedInAccountByIndex(IntPtr handle, int index)
        {
            return 0;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_Auth_GetLoggedInAccountsCount(IntPtr handle)
        {
            return 0;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_Auth_GetLoginStatus(IntPtr handle, IntPtr localUserId)
        {
            return (int)LoginStatus.NotLoggedIn;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_Auth_GetMergedAccountByIndex(IntPtr handle, IntPtr localUserId, uint index)
        {
            return 0;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static uint EOS_Auth_GetMergedAccountsCount(IntPtr handle, IntPtr localUserId)
        {
            return 0;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_Auth_GetSelectedAccountId(IntPtr handle, IntPtr localUserId, IntPtr outSelectedAccountId)
        {
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Auth_IdToken_Release(IntPtr idToken)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Auth_LinkAccount(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
        {
            var _LinkAccountOptions = Marshal.PtrToStructure<LinkAccountOptions>(options);
            delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: Auth.OnLinkAccountCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Auth_Login(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
        {
            var _LoginOptions = Marshal.PtrToStructure<LoginOptionsV3>(options);
            delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: Auth.OnLoginCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Auth_Logout(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
        {
            var _LogoutOptions = Marshal.PtrToStructure<LogoutOptions>(options);
            delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: Auth.OnLogoutCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Auth_QueryIdToken(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
        {
            var _QueryIdTokenOptions = Marshal.PtrToStructure<QueryIdTokenOptions>(options);
            delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: Auth.OnQueryIdTokenCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Auth_RemoveNotifyLoginStatusChanged(IntPtr handle, ulong inId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Auth_Token_Release(IntPtr authToken)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Auth_VerifyIdToken(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
        {
            var _VerifyIdTokenOptions = Marshal.PtrToStructure<VerifyIdTokenOptions>(options);
            delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: Auth.OnVerifyIdTokenCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Auth_VerifyUserAuth(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
        {
            var _VerifyUserAuthOptions = Marshal.PtrToStructure<VerifyUserAuthOptions>(options);
            delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: Auth.OnVerifyUserAuthCallback
        }

    }
}
