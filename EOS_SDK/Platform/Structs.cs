using System.Runtime.InteropServices;

namespace EOS_SDK.Platform
{
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct ClientCredentials
    {
        public IntPtr m_ClientId;
        public IntPtr m_ClientSecret;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct InitializeOptions
    {
        public int m_ApiVersion;
        public IntPtr m_AllocateMemoryFunction;
        public IntPtr m_ReallocateMemoryFunction;
        public IntPtr m_ReleaseMemoryFunction;
        public IntPtr m_ProductName;
        public IntPtr m_ProductVersion;
        public IntPtr m_Reserved;
        public IntPtr m_SystemInitializeOptions;
        public IntPtr m_OverrideThreadAffinity;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct Options
    {
        public IntPtr m_Reserved;
        public IntPtr m_ProductId;
        public IntPtr m_SandboxId;
        public ClientCredentials m_ClientCredentials;
        public int m_IsServer;
        public IntPtr m_EncryptionKey;
        public IntPtr m_OverrideCountryCode;
        public IntPtr m_OverrideLocaleCode;
        public IntPtr m_DeploymentId;
        public PlatformFlags m_Flags;
        public IntPtr m_CacheDirectory;
        public uint m_TickBudgetInMilliseconds;
        public IntPtr m_RTCOptions;
        public IntPtr m_IntegratedPlatformOptionsContainerHandle;
        public IntPtr m_SystemSpecificOptions;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct GetDesktopCrossplayStatusOptions
    {
        public int m_ApiVersion;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct DesktopCrossplayStatusInfo
    {
        public DesktopCrossplayStatus m_Status;
        public int m_ServiceInitResult;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct InitializeThreadAffinity
    {
        public int m_ApiVersion;
        public ulong m_NetworkWork;
        public ulong m_StorageIo;
        public ulong m_WebSocketIo;
        public ulong m_P2PIo;
        public ulong m_HttpRequestIo;
        public ulong m_RTCIo;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct RTCOptions
    {
        public int m_ApiVersion;
        public IntPtr m_PlatformSpecificOptions;
        public RTCBackgroundMode m_BackgroundMode;
    }
}
