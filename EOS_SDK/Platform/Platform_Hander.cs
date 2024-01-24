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
        }
        static Handler InternalHandler;
        static IntPtr HandlerPointer;

        public static IntPtr Create(WindowsOptions windowsOptions)
        {
            InternalHandler = new()
            {
                CurrentVersion = Helpers.FromString(_Data.SDK.Version),
                SandboxId = windowsOptions.m_SandboxId,
                DeploymentId = windowsOptions.m_DeploymentId,
                ClientCredentials = windowsOptions.m_ClientCredentials,
                EncryptionKey = windowsOptions.m_EncryptionKey,
                IsServer = windowsOptions.m_IsServer,
                OverrideCountryCode = windowsOptions.m_OverrideCountryCode,
                OverrideLocaleCode = windowsOptions.m_OverrideLocaleCode,
                ProductId = windowsOptions.m_ProductId
            };
            HandlerPointer = Helpers.StructToPtr(InternalHandler);
            return HandlerPointer;
        }

        public static IntPtr Create(Options options)
        {
            InternalHandler = new()
            {
                CurrentVersion = Helpers.FromString(_Data.SDK.Version),
                SandboxId = options.m_SandboxId,
                DeploymentId = options.m_DeploymentId,
                ClientCredentials = options.m_ClientCredentials,
                EncryptionKey = options.m_EncryptionKey,
                IsServer = options.m_IsServer,
                OverrideCountryCode = options.m_OverrideCountryCode,
                OverrideLocaleCode = options.m_OverrideLocaleCode,
                ProductId = options.m_ProductId
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
    }
}
