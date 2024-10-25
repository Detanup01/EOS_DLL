using EOS_SDK.Platform;
using System.Runtime.InteropServices;

namespace EOS_SDK.Windows;

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

    public override string ToString() => $"ApiVersion: {ApiVersion}, Reserved: {Reserved}, ProductId: {Helpers.ToUTF8String(ProductId)}, SandboxId: {Helpers.ToUTF8String(SandboxId)}, ClientCredentials: {ClientCredentials}" +
            $", IsServer: {IsServer}, EncryptionKey: {Helpers.ToUTF8String(EncryptionKey)}, OverrideCountryCode: {Helpers.ToUTF8String(OverrideCountryCode)}, OverrideLocaleCode: {Helpers.ToUTF8String(OverrideLocaleCode)}" +
            $", DeploymentId: {Helpers.ToUTF8String(DeploymentId)}, Flags: {Flags}";
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
