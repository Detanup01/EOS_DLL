using System.Runtime.InteropServices;

namespace EOS_SDK.Auth
{
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct AddNotifyLoginStatusChangedOptions
    {
        public int m_ApiVersion;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct CopyIdTokenOptions
    {
        public int m_ApiVersion;
        public IntPtr m_AccountId;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct CopyUserAuthTokenOptions
    {
        public int m_ApiVersion;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct DeletePersistentAuthOptions
    {
        public int m_ApiVersion;
        public IntPtr m_RefreshToken;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct LinkAccountOptions
    {
        public int m_ApiVersion;
        public LinkAccountFlags m_LinkAccountFlags;
        public IntPtr m_ContinuanceToken;
        public IntPtr m_LocalUserId;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct LoginOptions
    {
        public int m_ApiVersion;
        public IntPtr m_Credentials;
        public AuthScopeFlags m_ScopeFlags;
        public LoginFlags m_LoginFlags;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct LogoutOptions
    {
        public int m_ApiVersion;
        public IntPtr m_LocalUserId;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct QueryIdTokenOptions
    {
        public int m_ApiVersion;
        public IntPtr m_LocalUserId;
        public IntPtr m_TargetAccountId;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct VerifyIdTokenOptions
    {
        public int m_ApiVersion;
        public IntPtr m_IdToken;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct VerifyUserAuthOptions
    {
        public int m_ApiVersion;
        public IntPtr m_AuthToken;
    }


    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct AccountFeatureRestrictedInfo
    {
        public int m_ApiVersion;
        public IntPtr m_VerificationURI;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct Credentials
    {
        public int m_ApiVersion;
        public IntPtr m_Id;
        public IntPtr m_Token;
        public LoginCredentialType m_Type;
        public IntPtr m_SystemAuthCredentialsOptions;
        public ExternalCredentialType m_ExternalType;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct DeletePersistentAuthCallbackInfo
    {
        public Result m_ResultCode;
        public IntPtr m_ClientData;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct IdToken
    {
        public int m_ApiVersion;
        public IntPtr m_AccountId;
        public IntPtr m_JsonWebToken;
    }


    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct LinkAccountCallbackInfo
    {
        public Result m_ResultCode;
        public IntPtr m_ClientData;
        public IntPtr m_LocalUserId;
        public IntPtr m_PinGrantInfo;
        public IntPtr m_SelectedAccountId;
    }


    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct LoginCallbackInfo
    {
        public Result m_ResultCode;
        public IntPtr m_ClientData;
        public IntPtr m_LocalUserId;
        public IntPtr m_PinGrantInfo;
        public IntPtr m_ContinuanceToken;
        public IntPtr m_AccountFeatureRestrictedInfo_DEPRECATED;
        public IntPtr m_SelectedAccountId;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct LoginStatusChangedCallbackInfo
    {
        public IntPtr m_ClientData;
        public IntPtr m_LocalUserId;
        public LoginStatus m_PrevStatus;
        public LoginStatus m_CurrentStatus;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct LogoutCallbackInfo
    {
        public Result m_ResultCode;
        public IntPtr m_ClientData;
        public IntPtr m_LocalUserId;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct PinGrantInfo
    {
        public int m_ApiVersion;
        public IntPtr m_UserCode;
        public IntPtr m_VerificationURI;
        public IntPtr m_ExpiresIn;
        public IntPtr m_VerificationURIComplete;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct QueryIdTokenCallbackInfo
    {
        public Result m_ResultCode;
        public IntPtr m_ClientData;
        public IntPtr m_LocalUserId;
        public IntPtr m_TargetAccountId;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct Token
    {
        public int m_ApiVersion;
        public IntPtr m_App;
        public IntPtr m_ClientId;
        public IntPtr m_AccountId;
        public IntPtr m_AccessToken;
        public double m_ExpiresIn;
        public IntPtr m_ExpiresAt;
        public AuthTokenType m_AuthType;
        public IntPtr m_RefreshToken;
        public double m_RefreshExpiresIn;
        public IntPtr m_RefreshExpiresAt;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct VerifyIdTokenCallbackInfo
    {
        public Result m_ResultCode;
        public IntPtr m_ClientData;
        public IntPtr m_ApplicationId;
        public IntPtr m_ClientId;
        public IntPtr m_ProductId;
        public IntPtr m_SandboxId;
        public IntPtr m_DeploymentId;
        public IntPtr m_DisplayName;
        public int m_IsExternalAccountInfoPresent;
        public ExternalAccountType m_ExternalAccountIdType;
        public IntPtr m_ExternalAccountId;
        public IntPtr m_ExternalAccountDisplayName;
        public IntPtr m_Platform;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct VerifyUserAuthCallbackInfo
    {
        public Result m_ResultCode;
        public IntPtr m_ClientData;
    }
}
