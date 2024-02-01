using EOS_SDK._Data;
using System.Runtime.InteropServices;

namespace EOS_SDK.Auth
{
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct AddNotifyLoginStatusChangedOptions
    {
        public int ApiVersion;

        public override string ToString()
        {
            return $"ApiVersion: {ApiVersion}";
        }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct CopyIdTokenOptions
    {
        public int ApiVersion;
        public IntPtr AccountId;

        public override string ToString()
        {
            return $"ApiVersion: {ApiVersion}, AccountId: {Helpers.ToString(AccountId)}";
        }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct CopyUserAuthTokenOptions
    {
        public int ApiVersion;

        public override string ToString()
        {
            return $"ApiVersion: {ApiVersion}";
        }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct DeletePersistentAuthOptions
    {
        public int ApiVersion;
        public IntPtr RefreshToken;

        public override string ToString()
        {
            return $"ApiVersion: {ApiVersion}, RefreshToken: {Helpers.ToString(RefreshToken)}";
        }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct LinkAccountOptions
    {
        public int ApiVersion;
        public LinkAccountFlags LinkAccountFlags;
        public IntPtr ContinuanceToken;
        public IntPtr LocalUserId;

        public override string ToString()
        {
            return $"ApiVersion: {ApiVersion}, LinkAccountFlags: {LinkAccountFlags}, ContinuanceToken: {ContinuanceToken}, LocalUserId: {Helpers.ToString(LocalUserId)}";
        }
    }

    [APIVersion(3)]
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct LoginOptionsV3
    {
        public int ApiVersion;
        public IntPtr Credentials;
        public AuthScopeFlags ScopeFlags;
        public LoginFlags LoginFlags;

        public override string ToString()
        {
            return $"ApiVersion: {ApiVersion}, Credentials: {Credentials}, ScopeFlags: {ScopeFlags}, LoginFlags: {LoginFlags}";
        }
    }

    [APIVersion(2)]
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct LoginOptionsV2
    {
        public int ApiVersion;
        public IntPtr Credentials;
        public AuthScopeFlags ScopeFlags;

        public override string ToString()
        {
            return $"ApiVersion: {ApiVersion}, Credentials: {Credentials}, ScopeFlags: {ScopeFlags}";
        }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct LogoutOptions
    {
        public int ApiVersion;
        public IntPtr LocalUserId;

        public override string ToString()
        {
            return $"ApiVersion: {ApiVersion}, LocalUserId: {Helpers.ToString(LocalUserId)}";
        }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct QueryIdTokenOptions
    {
        public int ApiVersion;
        public IntPtr LocalUserId;
        public IntPtr TargetAccountId;

        public override string ToString()
        {
            return $"ApiVersion: {ApiVersion}, LocalUserId: {Helpers.ToString(LocalUserId)}, TargetAccountId: {Helpers.ToString(TargetAccountId)}";
        }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct VerifyIdTokenOptions
    {
        public int ApiVersion;
        public IntPtr IdToken;

        public override string ToString()
        {
            return $"ApiVersion: {ApiVersion}, IdToken: {IdToken}";
        }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct VerifyUserAuthOptions
    {
        public int ApiVersion;
        public IntPtr AuthToken;

        public override string ToString()
        {
            return $"ApiVersion: {ApiVersion}, AuthToken: {AuthToken}";
        }
    }


    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct AccountFeatureRestrictedInfo
    {
        public int ApiVersion;
        public IntPtr VerificationURI;

        public override string ToString()
        {
            return $"ApiVersion: {ApiVersion}, VerificationURI: {VerificationURI}";
        }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct Credentials
    {
        public int ApiVersion;
        public IntPtr Id;
        public IntPtr Token;
        public LoginCredentialType Type;
        public IntPtr SystemAuthCredentialsOptions;
        public ExternalCredentialType ExternalType;

        public override string ToString()
        {
            return $"ApiVersion: {ApiVersion}";
        }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct DeletePersistentAuthCallbackInfo
    {
        public Result ResultCode;
        public IntPtr ClientData;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct IdToken
    {
        public int ApiVersion;
        public IntPtr AccountId;
        public IntPtr JsonWebToken;

        public override string ToString()
        {
            return $"ApiVersion: {ApiVersion}, AccountId: {Helpers.ToString(AccountId)}, JsonWebToken: {Helpers.ToString(JsonWebToken)}";
        }
    }


    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct LinkAccountCallbackInfo
    {
        public Result ResultCode;
        public IntPtr ClientData;
        public IntPtr LocalUserId;
        public IntPtr PinGrantInfo;
        public IntPtr SelectedAccountId;
    }


    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct LoginCallbackInfo
    {
        public Result ResultCode;
        public IntPtr ClientData;
        public IntPtr LocalUserId;
        public IntPtr PinGrantInfo;
        public IntPtr ContinuanceToken;
        public IntPtr AccountFeatureRestrictedInfo_DEPRECATED;
        public IntPtr SelectedAccountId;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct LoginStatusChangedCallbackInfo
    {
        public IntPtr ClientData;
        public IntPtr LocalUserId;
        public LoginStatus PrevStatus;
        public LoginStatus CurrentStatus;

        public LoginStatusChangedCallbackInfo Set(LoginStatusChangedCallbackInfo main, LoginStatusChangedCallbackInfo setter)
        {
            var loginStatusChangedCallbackInfo = new LoginStatusChangedCallbackInfo();
            loginStatusChangedCallbackInfo = main;
            loginStatusChangedCallbackInfo.CurrentStatus = setter.CurrentStatus;
            loginStatusChangedCallbackInfo.LocalUserId = setter.LocalUserId;
            return loginStatusChangedCallbackInfo;
        }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct LogoutCallbackInfo
    {
        public Result ResultCode;
        public IntPtr ClientData;
        public IntPtr LocalUserId;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct PinGrantInfo
    {
        public int ApiVersion;
        public IntPtr UserCode;
        public IntPtr VerificationURI;
        public IntPtr ExpiresIn;
        public IntPtr VerificationURIComplete;

        public override string ToString()
        {
            return $"ApiVersion: {ApiVersion}";
        }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct QueryIdTokenCallbackInfo
    {
        public Result ResultCode;
        public IntPtr ClientData;
        public IntPtr LocalUserId;
        public IntPtr TargetAccountId;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct Token
    {
        public int ApiVersion;
        public IntPtr App;
        public IntPtr ClientId;
        public IntPtr AccountId;
        public IntPtr AccessToken;
        public double ExpiresIn;
        public IntPtr ExpiresAt;
        public AuthTokenType AuthType;
        public IntPtr RefreshToken;
        public double RefreshExpiresIn;
        public IntPtr RefreshExpiresAt;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct VerifyIdTokenCallbackInfo
    {
        public Result ResultCode;
        public IntPtr ClientData;
        public IntPtr ApplicationId;
        public IntPtr ClientId;
        public IntPtr ProductId;
        public IntPtr SandboxId;
        public IntPtr DeploymentId;
        public IntPtr DisplayName;
        public int IsExternalAccountInfoPresent;
        public ExternalAccountType ExternalAccountIdType;
        public IntPtr ExternalAccountId;
        public IntPtr ExternalAccountDisplayName;
        public IntPtr Platform;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct VerifyUserAuthCallbackInfo
    {
        public Result ResultCode;
        public IntPtr ClientData;
    }
}
