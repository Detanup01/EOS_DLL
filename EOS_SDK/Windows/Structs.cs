using EOS_SDK.Platform;
using System.Runtime.InteropServices;

namespace EOS_SDK.Windows
{
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct WindowsOptions
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

        public override string ToString()
        {
            return $"ApiVersion: {ApiVersion}, Reserved: {Reserved}, ProductId: {Helpers.ToString(ProductId)}, SandboxId: {Helpers.ToString(SandboxId)}, ClientCredentials: {ClientCredentials}" +
                $", IsServer: {IsServer}, EncryptionKey: {Helpers.ToString(EncryptionKey)}, OverrideCountryCode: {Helpers.ToString(OverrideCountryCode)}, OverrideLocaleCode: {Helpers.ToString(OverrideLocaleCode)}" +
                $", DeploymentId: {Helpers.ToString(DeploymentId)}, Flags: {Flags}";
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
