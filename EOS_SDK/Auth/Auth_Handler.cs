using EOS_SDK._Data;
using EOS_SDK.Enums;

namespace EOS_SDK.Auth;

public class Auth_Handler : IHandler
{
    struct AuthStruct
    {
        public bool IsLoggedIn;
    }

    AuthStruct Auth_Struct;

    public string AccountId => Config.GetConfig().AccountId;

    public void TriggerStateChange(bool IsLoggedIn, IntPtr localuserid)
    {
        Auth_Struct.IsLoggedIn = IsLoggedIn;
        LoginStatusChangedCallbackInfo info = new()
        {
            CurrentStatus = GetLoginStatus(),
            LocalUserId = localuserid
        };
        NotifyManager.TriggerNotify("AuthNotifyLoginStatus", info);
    }

    public LoginStatus GetLoginStatus()
    {
        if (Auth_Struct.IsLoggedIn)
            return LoginStatus.LoggedIn;
        return LoginStatus.NotLoggedIn;
    }

    public IntPtr Create()
    {
        Auth_Struct = new AuthStruct();
        _log.Logger.WriteDebug("Auth Created", Logging.LogCategory.Auth);
        return Helpers.StructToPtr(new DummyStruct(nameof(Auth_Handler)));
    }

    public void Tick()
    {
        
    }

    public void Dispose()
    {
        GC.SuppressFinalize(this);
    }
}
