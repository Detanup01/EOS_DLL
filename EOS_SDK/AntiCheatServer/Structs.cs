using EOS_SDK._Data;
using System.Runtime.InteropServices;
using EOS_SDK.Version;

namespace EOS_SDK.AntiCheatServer
{
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct AddNotifyClientActionRequiredOptions
    {
        public int ApiVersion { get => Versions.AddNotifyClientActionRequiredApiLatest; }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct AddNotifyClientAuthStatusChangedOptions
    {
        public int ApiVersion { get => 1; }
    }


    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct AddNotifyMessageToClientOptions
    {
        public int ApiVersion { get => 1; }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct BeginSessionOptions
    {
        public int ApiVersion { get => 3; }
        public uint RegisterTimeoutSeconds;
        public IntPtr ServerName;
        public int EnableGameplayData;
        public IntPtr LocalUserId;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct EndSessionOptions
    {
        public int ApiVersion { get => 1; }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct GetProtectMessageOutputLengthOptions
    {
        public int ApiVersion { get => 1; }
        public uint DataLengthBytes;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct ProtectMessageOptions
    {
        public int ApiVersion { get => 1; }
        public IntPtr ClientHandle;
        public uint DataLengthBytes;
        public IntPtr Data;
        public uint OutBufferSizeBytes;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct ReceiveMessageFromClientOptions
    {
        public int ApiVersion { get => 1; }
        public IntPtr ClientHandle;
        public uint DataLengthBytes;
        public IntPtr Data;
    }

    [APIVersion(2)]
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct RegisterClientOptionsV2
    {
        public int ApiVersion { get => 2; }
        public IntPtr ClientHandle;
        public AntiCheatCommon.AntiCheatCommonClientType ClientType;
        public AntiCheatCommon.AntiCheatCommonClientPlatform ClientPlatform;
        public IntPtr AccountId_DEPRECATED;
        public IntPtr IpAddress;
        public IntPtr UserId;
    }

    [APIVersion(1)]
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct RegisterClientOptionsV1
    {
        public int ApiVersion { get => 1; }
        public IntPtr ClientHandle;
        public AntiCheatCommon.AntiCheatCommonClientType ClientType;
        public AntiCheatCommon.AntiCheatCommonClientPlatform ClientPlatform;
        public IntPtr AccountId;
        public IntPtr IpAddress;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct SetClientNetworkStateOptions
    {
        public int ApiVersion { get => 1; }
        public IntPtr ClientHandle;
        public int IsNetworkActive;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct UnprotectMessageOptions
    {
        public int ApiVersion { get => 1; }
        public IntPtr ClientHandle;
        public uint DataLengthBytes;
        public IntPtr Data;
        public uint OutBufferSizeBytes;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct UnregisterClientOptions
    {
        public int ApiVersion { get => 1; }
        public IntPtr ClientHandle;
    }
}
