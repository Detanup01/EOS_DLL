using EOS_SDK._Data;
using System.Runtime.InteropServices;

namespace EOS_SDK.Platform
{
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct ClientCredentials
    {
        public IntPtr ClientId;
        public IntPtr ClientSecret;

        public override readonly string ToString() => $"ClientId: {Helpers.ToUTF8String(ClientId)}, ClientSecret: {Helpers.ToUTF8String(ClientSecret)}";
    }
    [APIVersion(1)]
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct InitializeOptionsV1
    {
        public int ApiVersion;
        public IntPtr AllocateMemoryFunction;
        public IntPtr ReallocateMemoryFunction;
        public IntPtr ReleaseMemoryFunction;
        public IntPtr ProductName;
        public IntPtr ProductVersion;
    }

    [APIVersion(2)]
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct InitializeOptionsV2
    {
        public int ApiVersion;
        public IntPtr AllocateMemoryFunction;
        public IntPtr ReallocateMemoryFunction;
        public IntPtr ReleaseMemoryFunction;
        public IntPtr ProductName;
        public IntPtr ProductVersion;
        public IntPtr Reserved;
    }

    [APIVersion(3)]
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct InitializeOptionsV3
    {
        public int ApiVersion;
        public IntPtr AllocateMemoryFunction;
        public IntPtr ReallocateMemoryFunction;
        public IntPtr ReleaseMemoryFunction;
        public IntPtr ProductName;
        public IntPtr ProductVersion;
        public IntPtr Reserved;
        public IntPtr SystemInitializeOptions;
    }

    [APIVersion(4)]
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct InitializeOptions
    {
        public int ApiVersion;
        public IntPtr AllocateMemoryFunction;
        public IntPtr ReallocateMemoryFunction;
        public IntPtr ReleaseMemoryFunction;
        public IntPtr ProductName;
        public IntPtr ProductVersion;
        public IntPtr Reserved;
        public IntPtr SystemInitializeOptions;
        public IntPtr OverrideThreadAffinity;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct Options
    {
        public int ApiVersion;
        public IntPtr Reserved;
        public IntPtr ProductId;
        public IntPtr SandboxId;
        public ClientCredentials ClientCredentials;
        public int IsServer;
        public IntPtr EncryptionKey;
        public IntPtr OverrideCountryCode;
        public IntPtr OverrideLocaleCode;
        public IntPtr DeploymentId;
        public PlatformFlags Flags;
        public IntPtr CacheDirectory;
        public uint TickBudgetInMilliseconds;
        public IntPtr RTCOptions;
        public IntPtr IntegratedPlatformOptionsContainerHandle;
        public IntPtr SystemSpecificOptions;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct GetDesktopCrossplayStatusOptions
    {
        public int ApiVersion;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct DesktopCrossplayStatusInfo
    {
        public DesktopCrossplayStatus Status;
        public int ServiceInitResult;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct InitializeThreadAffinity
    {
        public int ApiVersion;
        public ulong NetworkWork;
        public ulong StorageIo;
        public ulong WebSocketIo;
        public ulong P2PIo;
        public ulong HttpRequestIo;
        public ulong RTCIo;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct RTCOptions
    {
        public int ApiVersion;
        public IntPtr PlatformSpecificOptions;
        public RTCBackgroundMode BackgroundMode;
    }
}
