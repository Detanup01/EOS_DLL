using EOS_SDK._Data;
using System.Runtime.InteropServices;

namespace EOS_SDK.Connect
{
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct AddNotifyAuthExpirationOptions
    {
        public int ApiVersion;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct AddNotifyLoginStatusChangedOptions
    {
        public int ApiVersion;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct AuthExpirationCallbackInfo
    {
        public IntPtr ClientData;
        public IntPtr LocalUserId;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct CopyIdTokenOptions
    {
        public int ApiVersion;
        public IntPtr LocalUserId;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct CopyProductUserExternalAccountByAccountIdOptions
    {
        public int ApiVersion;
        public IntPtr TargetUserId;
        public IntPtr AccountId;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct CopyProductUserExternalAccountByAccountTypeOptions
    {
        public int ApiVersion;
        public IntPtr TargetUserId;
        public ExternalAccountType AccountIdType;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct CopyProductUserExternalAccountByIndexOptions
    {
        public int ApiVersion;
        public IntPtr TargetUserId;
        public uint ExternalAccountInfoIndex;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct CopyProductUserInfoOptions
    {
        public int ApiVersion;
        public IntPtr TargetUserId;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct CreateDeviceIdCallbackInfo
    {
        public Result ResultCode;
        public IntPtr ClientData;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct CreateDeviceIdOptions
    {
        public int ApiVersion;
        public IntPtr DeviceModel;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct CreateUserCallbackInfo
    {
        public Result ResultCode;
        public IntPtr ClientData;
        public IntPtr LocalUserId;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct CreateUserOptions
    {
        public int ApiVersion;
        public IntPtr ContinuanceToken;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct Credentials
    {
        public int ApiVersion;
        public IntPtr Token;
        public ExternalCredentialType Type;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct DeleteDeviceIdCallbackInfo
    {
        public Result ResultCode;
        public IntPtr ClientData;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct DeleteDeviceIdOptions
    {
        public int ApiVersion;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct ExternalAccountInfo
    {
        public int ApiVersion;
        public IntPtr ProductUserId;
        public IntPtr DisplayName;
        public IntPtr AccountId;
        public ExternalAccountType AccountIdType;
        public long LastLoginTime;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct GetExternalAccountMappingsOptions
    {
        public int ApiVersion;
        public IntPtr LocalUserId;
        public ExternalAccountType AccountIdType;
        public IntPtr TargetExternalUserId;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct GetProductUserExternalAccountCountOptions
    {
        public int ApiVersion;
        public IntPtr TargetUserId;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct GetProductUserIdMappingOptions
    {
        public int ApiVersion;
        public IntPtr LocalUserId;
        public ExternalAccountType AccountIdType;
        public IntPtr TargetExternalUserId;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct IdToken
    {
        public int ApiVersion;
        public IntPtr ProductUserId;
        public IntPtr JsonWebToken;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct LinkAccountCallbackInfo
    {
        public Result ResultCode;
        public IntPtr ClientData;
        public IntPtr LocalUserId;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct LinkAccountOptions
    {
        public int ApiVersion;
        public IntPtr LocalUserId;
        public IntPtr ContinuanceToken;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct LoginCallbackInfo
    {
        public Result ResultCode;
        public IntPtr ClientData;
        public IntPtr LocalUserId;
        public IntPtr ContinuanceToken;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct LoginOptions
    {
        public int ApiVersion;
        public IntPtr Credentials;
        public IntPtr UserLoginInfo;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct LoginStatusChangedCallbackInfo
    {
        public IntPtr ClientData;
        public IntPtr LocalUserId;
        public LoginStatus PreviousStatus;
        public LoginStatus CurrentStatus;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct QueryExternalAccountMappingsCallbackInfo
    {
        public Result ResultCode;
        public IntPtr ClientData;
        public IntPtr LocalUserId;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct QueryExternalAccountMappingsOptions
    {
        public int ApiVersion;
        public IntPtr LocalUserId;
        public ExternalAccountType AccountIdType;
        public IntPtr ExternalAccountIds;
        public uint ExternalAccountIdCount;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct QueryProductUserIdMappingsCallbackInfo
    {
        public Result ResultCode;
        public IntPtr ClientData;
        public IntPtr LocalUserId;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct QueryProductUserIdMappingsOptions
    {
        public int ApiVersion;
        public IntPtr LocalUserId;
        public ExternalAccountType AccountIdType_DEPRECATED;
        public IntPtr ProductUserIds;
        public uint ProductUserIdCount;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct TransferDeviceIdAccountCallbackInfo
    {
        public Result ResultCode;
        public IntPtr ClientData;
        public IntPtr LocalUserId;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct TransferDeviceIdAccountOptions
    {
        public int ApiVersion;
        public IntPtr PrimaryLocalUserId;
        public IntPtr LocalDeviceUserId;
        public IntPtr ProductUserIdToPreserve;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct UnlinkAccountCallbackInfo
    {
        public Result ResultCode;
        public IntPtr ClientData;
        public IntPtr LocalUserId;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct UnlinkAccountOptions
    {
        public int ApiVersion;
        public IntPtr LocalUserId;
    }

    [APIVersion(2)]
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct UserLoginInfoV2
    {
        public int ApiVersion;
        public IntPtr DisplayName;
        public IntPtr NsaIdToken;
    }

    [APIVersion(1)]
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct UserLoginInfoV1
    {
        public int ApiVersion;
        public IntPtr DisplayName;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct VerifyIdTokenCallbackInfo
    {
        public Result ResultCode;
        public IntPtr ClientData;
        public IntPtr ProductUserId;
        public int IsAccountInfoPresent;
        public ExternalAccountType AccountIdType;
        public IntPtr AccountId;
        public IntPtr Platform;
        public IntPtr DeviceType;
        public IntPtr ClientId;
        public IntPtr ProductId;
        public IntPtr SandboxId;
        public IntPtr DeploymentId;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct VerifyIdTokenOptions
    {
        public int ApiVersion;
        public IntPtr IdToken;
    }
}
