using EOS_SDK._Data;
using System.Runtime.InteropServices;

namespace EOS_SDK.Enums
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
        public nint AccountId;

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
        public nint RefreshToken;

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
        public nint ContinuanceToken;
        public nint LocalUserId;

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
        public nint Credentials;
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
        public nint Credentials;
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
        public nint LocalUserId;

        public override string ToString()
        {
            return $"ApiVersion: {ApiVersion}, LocalUserId: {Helpers.ToString(LocalUserId)}";
        }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct QueryIdTokenOptions
    {
        public int ApiVersion;
        public nint LocalUserId;
        public nint TargetAccountId;

        public override string ToString()
        {
            return $"ApiVersion: {ApiVersion}, LocalUserId: {Helpers.ToString(LocalUserId)}, TargetAccountId: {Helpers.ToString(TargetAccountId)}";
        }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct VerifyIdTokenOptions
    {
        public int ApiVersion;
        public nint IdToken;

        public override string ToString()
        {
            return $"ApiVersion: {ApiVersion}, IdToken: {IdToken}";
        }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct VerifyUserAuthOptions
    {
        public int ApiVersion;
        public nint AuthToken;

        public override string ToString()
        {
            return $"ApiVersion: {ApiVersion}, AuthToken: {AuthToken}";
        }
    }


    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct AccountFeatureRestrictedInfo
    {
        public int ApiVersion;
        public nint VerificationURI;

        public override string ToString()
        {
            return $"ApiVersion: {ApiVersion}, VerificationURI: {VerificationURI}";
        }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct Credentials
    {
        public int ApiVersion;
        public nint Id;
        public nint Token;
        public LoginCredentialType Type;
        public nint SystemAuthCredentialsOptions;
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
        public nint ClientData;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct IdToken
    {
        public int ApiVersion;
        public nint AccountId;
        public nint JsonWebToken;

        public override string ToString()
        {
            return $"ApiVersion: {ApiVersion}, AccountId: {Helpers.ToString(AccountId)}, JsonWebToken: {Helpers.ToString(JsonWebToken)}";
        }
    }


    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct LinkAccountCallbackInfo
    {
        public Result ResultCode;
        public nint ClientData;
        public nint LocalUserId;
        public nint PinGrantInfo;
        public nint SelectedAccountId;
    }


    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct LoginCallbackInfo
    {
        public Result ResultCode;
        public nint ClientData;
        public nint LocalUserId;
        public nint PinGrantInfo;
        public nint ContinuanceToken;
        public nint AccountFeatureRestrictedInfo_DEPRECATED;
        public nint SelectedAccountId;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct LoginStatusChangedCallbackInfo
    {
        public nint ClientData;
        public nint LocalUserId;
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
        public nint ClientData;
        public nint LocalUserId;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct PinGrantInfo
    {
        public int ApiVersion;
        public nint UserCode;
        public nint VerificationURI;
        public nint ExpiresIn;
        public nint VerificationURIComplete;

        public override string ToString()
        {
            return $"ApiVersion: {ApiVersion}";
        }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct QueryIdTokenCallbackInfo
    {
        public Result ResultCode;
        public nint ClientData;
        public nint LocalUserId;
        public nint TargetAccountId;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct Token
    {
        public int ApiVersion;
        public nint App;
        public nint ClientId;
        public nint AccountId;
        public nint AccessToken;
        public double ExpiresIn;
        public nint ExpiresAt;
        public AuthTokenType AuthType;
        public nint RefreshToken;
        public double RefreshExpiresIn;
        public nint RefreshExpiresAt;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct VerifyIdTokenCallbackInfo
    {
        public Result ResultCode;
        public nint ClientData;
        public nint ApplicationId;
        public nint ClientId;
        public nint ProductId;
        public nint SandboxId;
        public nint DeploymentId;
        public nint DisplayName;
        public int IsExternalAccountInfoPresent;
        public ExternalAccountType ExternalAccountIdType;
        public nint ExternalAccountId;
        public nint ExternalAccountDisplayName;
        public nint Platform;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct VerifyUserAuthCallbackInfo
    {
        public Result ResultCode;
        public nint ClientData;
    }
}
