using EOS_SDK._Data;
using System.Runtime.InteropServices;

namespace EOS_SDK.Auth
{
    public class Auth_Handler
    {
        struct AuthStruct
        {
            public int Version { get => 1; }
            public bool IsLoggedIn;
        }

        static AuthStruct Auth_Struct;

        public static IntPtr Create()
        {
            Auth_Struct = new AuthStruct();
            return IntPtr.CreateChecked(Auth_Struct.Version);
        }

        public static string GetUserId()
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
