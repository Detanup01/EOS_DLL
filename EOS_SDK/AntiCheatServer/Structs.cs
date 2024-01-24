using EOS_SDK._Data;
using System.Runtime.InteropServices;
using EOS_SDK.Version;

namespace EOS_SDK.AntiCheatServer
{
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct AddNotifyClientActionRequiredOptions
    {
        public int m_ApiVersion { get => Versions.AddNotifyClientActionRequiredApiLatest; }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct AddNotifyClientAuthStatusChangedOptions
    {
        public int m_ApiVersion { get => 1; }
    }


    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct AddNotifyMessageToClientOptions
    {
        public int m_ApiVersion { get => 1; }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct BeginSessionOptions
    {
        public int m_ApiVersion { get => 3; }
        public uint m_RegisterTimeoutSeconds;
        public IntPtr m_ServerName;
        public int m_EnableGameplayData;
        public IntPtr m_LocalUserId;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct EndSessionOptions
    {
        public int m_ApiVersion { get => 1; }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct GetProtectMessageOutputLengthOptions
    {
        public int m_ApiVersion { get => 1; }
        public uint m_DataLengthBytes;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct ProtectMessageOptions
    {
        public int m_ApiVersion { get => 1; }
        public IntPtr m_ClientHandle;
        public uint m_DataLengthBytes;
        public IntPtr m_Data;
        public uint m_OutBufferSizeBytes;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct ReceiveMessageFromClientOptions
    {
        public int m_ApiVersion { get => 1; }
        public IntPtr m_ClientHandle;
        public uint m_DataLengthBytes;
        public IntPtr m_Data;
    }

    [APIVersion(2)]
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct RegisterClientOptionsV2
    {
        public int m_ApiVersion { get => 2; }
        public IntPtr m_ClientHandle;
        public AntiCheatCommon.AntiCheatCommonClientType m_ClientType;
        public AntiCheatCommon.AntiCheatCommonClientPlatform m_ClientPlatform;
        public IntPtr m_AccountId_DEPRECATED;
        public IntPtr m_IpAddress;
        public IntPtr m_UserId;
    }

    [APIVersion(1)]
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct RegisterClientOptionsV1
    {
        public int m_ApiVersion { get => 1; }
        public IntPtr m_ClientHandle;
        public AntiCheatCommon.AntiCheatCommonClientType m_ClientType;
        public AntiCheatCommon.AntiCheatCommonClientPlatform m_ClientPlatform;
        public IntPtr m_AccountId;
        public IntPtr m_IpAddress;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct SetClientNetworkStateOptions
    {
        public int m_ApiVersion { get => 1; }
        public IntPtr m_ClientHandle;
        public int m_IsNetworkActive;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct UnprotectMessageOptions
    {
        public int m_ApiVersion { get => 1; }
        public IntPtr m_ClientHandle;
        public uint m_DataLengthBytes;
        public IntPtr m_Data;
        public uint m_OutBufferSizeBytes;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct UnregisterClientOptions
    {
        public int m_ApiVersion { get => 1; }
        public IntPtr m_ClientHandle;
    }
}
