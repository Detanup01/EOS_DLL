using EOS_SDK._Data;
using System.Runtime.InteropServices;

namespace EOS_SDK.Connect
{
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct AddNotifyAuthExpirationOptions
    {
        public int m_ApiVersion;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct AddNotifyLoginStatusChangedOptions
    {
        public int m_ApiVersion;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct AuthExpirationCallbackInfo
    {
        public IntPtr m_ClientData;
        public IntPtr m_LocalUserId;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct CopyIdTokenOptions
    {
        public int m_ApiVersion;
        public IntPtr m_LocalUserId;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct CopyProductUserExternalAccountByAccountIdOptions
    {
        public int m_ApiVersion;
        public IntPtr m_TargetUserId;
        public IntPtr m_AccountId;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct CopyProductUserExternalAccountByAccountTypeOptions
    {
        public int m_ApiVersion;
        public IntPtr m_TargetUserId;
        public ExternalAccountType m_AccountIdType;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct CopyProductUserExternalAccountByIndexOptions
    {
        public int m_ApiVersion;
        public IntPtr m_TargetUserId;
        public uint m_ExternalAccountInfoIndex;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct CopyProductUserInfoOptions
    {
        public int m_ApiVersion;
        public IntPtr m_TargetUserId;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct CreateDeviceIdCallbackInfo
    {
        public Result m_ResultCode;
        public IntPtr m_ClientData;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct CreateDeviceIdOptions
    {
        public int m_ApiVersion;
        public IntPtr m_DeviceModel;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct CreateUserCallbackInfo
    {
        public Result m_ResultCode;
        public IntPtr m_ClientData;
        public IntPtr m_LocalUserId;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct CreateUserOptions
    {
        public int m_ApiVersion;
        public IntPtr m_ContinuanceToken;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct Credentials
    {
        public int m_ApiVersion;
        public IntPtr m_Token;
        public ExternalCredentialType m_Type;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct DeleteDeviceIdCallbackInfo
    {
        public Result m_ResultCode;
        public IntPtr m_ClientData;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct DeleteDeviceIdOptions
    {
        public int m_ApiVersion;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct ExternalAccountInfo
    {
        public int m_ApiVersion;
        public IntPtr m_ProductUserId;
        public IntPtr m_DisplayName;
        public IntPtr m_AccountId;
        public ExternalAccountType m_AccountIdType;
        public long m_LastLoginTime;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct GetExternalAccountMappingsOptions
    {
        public int m_ApiVersion;
        public IntPtr m_LocalUserId;
        public ExternalAccountType m_AccountIdType;
        public IntPtr m_TargetExternalUserId;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct GetProductUserExternalAccountCountOptions
    {
        public int m_ApiVersion;
        public IntPtr m_TargetUserId;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct GetProductUserIdMappingOptions
    {
        public int m_ApiVersion;
        public IntPtr m_LocalUserId;
        public ExternalAccountType m_AccountIdType;
        public IntPtr m_TargetExternalUserId;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct IdToken
    {
        public int m_ApiVersion;
        public IntPtr m_ProductUserId;
        public IntPtr m_JsonWebToken;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct LinkAccountCallbackInfo
    {
        public Result m_ResultCode;
        public IntPtr m_ClientData;
        public IntPtr m_LocalUserId;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct LinkAccountOptions
    {
        public int m_ApiVersion;
        public IntPtr m_LocalUserId;
        public IntPtr m_ContinuanceToken;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct LoginCallbackInfo
    {
        public Result m_ResultCode;
        public IntPtr m_ClientData;
        public IntPtr m_LocalUserId;
        public IntPtr m_ContinuanceToken;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct LoginOptions
    {
        public int m_ApiVersion;
        public IntPtr m_Credentials;
        public IntPtr m_UserLoginInfo;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct LoginStatusChangedCallbackInfo
    {
        public IntPtr m_ClientData;
        public IntPtr m_LocalUserId;
        public LoginStatus m_PreviousStatus;
        public LoginStatus m_CurrentStatus;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct QueryExternalAccountMappingsCallbackInfo
    {
        public Result m_ResultCode;
        public IntPtr m_ClientData;
        public IntPtr m_LocalUserId;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct QueryExternalAccountMappingsOptions
    {
        public int m_ApiVersion;
        public IntPtr m_LocalUserId;
        public ExternalAccountType m_AccountIdType;
        public IntPtr m_ExternalAccountIds;
        public uint m_ExternalAccountIdCount;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct QueryProductUserIdMappingsCallbackInfo
    {
        public Result m_ResultCode;
        public IntPtr m_ClientData;
        public IntPtr m_LocalUserId;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct QueryProductUserIdMappingsOptions
    {
        public int m_ApiVersion;
        public IntPtr m_LocalUserId;
        public ExternalAccountType m_AccountIdType_DEPRECATED;
        public IntPtr m_ProductUserIds;
        public uint m_ProductUserIdCount;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct TransferDeviceIdAccountCallbackInfo
    {
        public Result m_ResultCode;
        public IntPtr m_ClientData;
        public IntPtr m_LocalUserId;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct TransferDeviceIdAccountOptions
    {
        public int m_ApiVersion;
        public IntPtr m_PrimaryLocalUserId;
        public IntPtr m_LocalDeviceUserId;
        public IntPtr m_ProductUserIdToPreserve;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct UnlinkAccountCallbackInfo
    {
        public Result m_ResultCode;
        public IntPtr m_ClientData;
        public IntPtr m_LocalUserId;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct UnlinkAccountOptions
    {
        public int m_ApiVersion;
        public IntPtr m_LocalUserId;
    }

    [APIVersion(2)]
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct UserLoginInfoV2
    {
        public int m_ApiVersion;
        public IntPtr m_DisplayName;
        public IntPtr m_NsaIdToken;
    }

    [APIVersion(1)]
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct UserLoginInfoV1
    {
        public int m_ApiVersion;
        public IntPtr m_DisplayName;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct VerifyIdTokenCallbackInfo
    {
        public Result m_ResultCode;
        public IntPtr m_ClientData;
        public IntPtr m_ProductUserId;
        public int m_IsAccountInfoPresent;
        public ExternalAccountType m_AccountIdType;
        public IntPtr m_AccountId;
        public IntPtr m_Platform;
        public IntPtr m_DeviceType;
        public IntPtr m_ClientId;
        public IntPtr m_ProductId;
        public IntPtr m_SandboxId;
        public IntPtr m_DeploymentId;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct VerifyIdTokenOptions
    {
        public int m_ApiVersion;
        public IntPtr m_IdToken;
    }
}
