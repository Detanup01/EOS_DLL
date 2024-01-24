using EOS_SDK.Platform;
using System.Runtime.InteropServices;

namespace EOS_SDK.Windows
{
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct WindowsOptions
    {
        public int m_ApiVersion;
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
    public struct WindowsRTCOptions
    {
        public int m_ApiVersion;
        public IntPtr m_PlatformSpecificOptions;
        public RTCBackgroundMode m_BackgroundMode;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct WindowsRTCOptionsPlatformSpecificOptions
    {
        public int m_ApiVersion;
        public IntPtr m_XAudio29DllPath;
    }
}
