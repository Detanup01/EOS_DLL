using EOS_SDK._Data;
using EOS_SDK.Enums;
using EOS_SDK.Others;
using EOS_SDK.Platform;
using System.Security.Cryptography;
using System.Text;

namespace EOS_SDK.Auth
{
    public class Auth_Handler
    {
        struct AuthStruct
        {
            public bool IsLoggedIn;
        }

        static AuthStruct Auth_Struct;

        public static IntPtr Create()
        {
            Auth_Struct = new AuthStruct();
            _log.Logger.WriteDebug("Auth Created", Logging.LogCategory.Auth);
            return IntPtr.CreateChecked(SDK.AuthPTR);
        }

        public static string GetAccountId()
        {
            return Config.GetConfig().AccountId;
        }

        public static void TriggerStateChange(bool IsLoggedIn, IntPtr localuserid)
        {
            Auth_Struct.IsLoggedIn = IsLoggedIn;
            LoginStatusChangedCallbackInfo info = new()
            {
                CurrentStatus = GetLoginStatus(),
                LocalUserId = localuserid
            };
            NotifyManager.TriggerNotify("AuthNotifyLoginStatus", info);
        }

        public static LoginStatus GetLoginStatus()
        {
            if (Auth_Struct.IsLoggedIn)
                return LoginStatus.LoggedIn;
            return LoginStatus.NotLoggedIn;
        }
    }
}
