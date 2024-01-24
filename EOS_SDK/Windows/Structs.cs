using EOS_SDK.Platform;
using System.Runtime.InteropServices;

namespace EOS_SDK.Windows
{
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct WindowsOptions
    {
        public int ApiVersion;
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

        public override string ToString()
        {
            return $"ApiVersion: {ApiVersion}, Reserved: {m_Reserved}, ProductId: {Helpers.ToString(m_ProductId)}, SandboxId: {Helpers.ToString(m_SandboxId)}, ClientCredentials: {m_ClientCredentials}" +
                $", IsServer: {m_IsServer}, EncryptionKey: {Helpers.ToString(m_EncryptionKey)}, OverrideCountryCode: {Helpers.ToString(m_OverrideCountryCode)}, OverrideLocaleCode: {Helpers.ToString(m_OverrideLocaleCode)}" +
                $", DeploymentId: {Helpers.ToString(m_DeploymentId)}, Flags: {m_Flags}";
        }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct WindowsRTCOptions
    {
        public int ApiVersion;
        public IntPtr PlatformSpecificOptions;
        public RTCBackgroundMode BackgroundMode;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct WindowsRTCOptionsPlatformSpecificOptions
    {
        public int ApiVersion;
        public IntPtr XAudio29DllPath;
    }
}
