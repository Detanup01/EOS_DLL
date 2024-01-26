using EOS_SDK.Windows;
using System.Runtime.InteropServices;

namespace EOS_SDK.Platform
{
    public class Platform_Hander
    {
        [StructLayout(LayoutKind.Sequential, Pack = 8)]
        public struct Handler
        {
            public IntPtr CurrentVersion;
            public IntPtr ProductId;
            public IntPtr SandboxId;
            public ClientCredentials ClientCredentials;
            public int IsServer;
            public IntPtr EncryptionKey;
            public IntPtr OverrideCountryCode;
            public IntPtr OverrideLocaleCode;
            public IntPtr DeploymentId;
            public NetworkStatus NetworkStatus;
            public ApplicationStatus ApplicationStatus;
        }
        public static Handler InternalHandler;
        static IntPtr HandlerPointer = IntPtr.Zero;

        public static IntPtr Create(WindowsOptions windowsOptions)
        {
            InternalHandler = new()
            {
                CurrentVersion = Helpers.FromString(_Data.SDK.Version),
                SandboxId = windowsOptions.SandboxId,
                DeploymentId = windowsOptions.DeploymentId,
                ClientCredentials = windowsOptions.ClientCredentials,
                EncryptionKey = windowsOptions.EncryptionKey,
                IsServer = windowsOptions.IsServer,
                OverrideCountryCode = windowsOptions.OverrideCountryCode,
                OverrideLocaleCode = windowsOptions.OverrideLocaleCode,
                ProductId = windowsOptions.ProductId,
                NetworkStatus = NetworkStatus.Offline,
                ApplicationStatus = ApplicationStatus.Foreground
            };
            HandlerPointer = Helpers.StructToPtr(InternalHandler);
            return HandlerPointer;
        }

        public static IntPtr Create(Options options)
        {
            InternalHandler = new()
            {
                CurrentVersion = Helpers.FromString(_Data.SDK.Version),
                SandboxId = options.SandboxId,
                DeploymentId = options.DeploymentId,
                ClientCredentials = options.ClientCredentials,
                EncryptionKey = options.EncryptionKey,
                IsServer = options.IsServer,
                OverrideCountryCode = options.OverrideCountryCode,
                OverrideLocaleCode = options.OverrideLocaleCode,
                ProductId = options.ProductId,
                NetworkStatus = NetworkStatus.Offline,
                ApplicationStatus = ApplicationStatus.Foreground
            };
            HandlerPointer = Helpers.StructToPtr(InternalHandler);
            return HandlerPointer;
        }

        public static bool CheckIfPointerValid(IntPtr ptr)
        {
            if (ptr == IntPtr.Zero)
                return false;
            return ptr == HandlerPointer;
        }


        public static void Free(IntPtr ptr)
        {
            if (CheckIfPointerValid(HandlerPointer))
                Marshal.FreeHGlobal(HandlerPointer);
            Marshal.FreeHGlobal(ptr);

        }
    }
}
