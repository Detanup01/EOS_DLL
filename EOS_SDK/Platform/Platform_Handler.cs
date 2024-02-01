using EOS_SDK._Data;
using EOS_SDK.Windows;

namespace EOS_SDK.Platform
{
    public class Platform_Handler
    {
        public struct Handler
        {
            public string ProductId;
            public string SandboxId;
            public ClientCredentials ClientCredentials;
            public int IsServer;
            public string EncryptionKey;
            public string OverrideCountryCode;
            public string OverrideLocaleCode;
            public string DeploymentId;
            public NetworkStatus NetworkStatus;
            public ApplicationStatus ApplicationStatus;

            public override string ToString()
            {
                return $"ProductId: {ProductId}, SandboxId: {SandboxId}, ClientCredentials: ({ClientCredentials.ToString()}), IsServer: {IsServer}, EncryptionKey: {EncryptionKey}\n" +
                    $"OverrideCountryCode {OverrideCountryCode}, OverrideLocaleCode {OverrideLocaleCode}, DeploymentId {DeploymentId}\n" +
                    $"NetworkStatus: {NetworkStatus}, ApplicationStatus: {ApplicationStatus}";
            }
        }
        public static Handler PlatformHandler;

        public static IntPtr Create(WindowsOptions windowsOptions)
        {

            PlatformHandler = new()
            {
                SandboxId = Helpers.ToString(windowsOptions.SandboxId),
                DeploymentId = Helpers.ToString(windowsOptions.DeploymentId),
                ClientCredentials = windowsOptions.ClientCredentials,
                EncryptionKey = Helpers.ToString(windowsOptions.EncryptionKey),
                IsServer = windowsOptions.IsServer,
                OverrideCountryCode = Helpers.ToString(windowsOptions.OverrideCountryCode),
                OverrideLocaleCode = Helpers.ToString(windowsOptions.OverrideLocaleCode),
                ProductId = Helpers.ToString(windowsOptions.ProductId),
                NetworkStatus = NetworkStatus.Offline,
                ApplicationStatus = ApplicationStatus.Foreground
            };
            var conf = Config.GetConfig();
            Config.Save(conf);
            _log.Logger.WriteInfo("Platform_Handler.Create Windows: " + PlatformHandler.ToString());
            return IntPtr.CreateChecked(SDK.PlatformPTR);
        }

        public static IntPtr Create(Options options)
        {
            PlatformHandler = new()
            {
                SandboxId = Helpers.ToString(options.SandboxId),
                DeploymentId = Helpers.ToString(options.DeploymentId),
                ClientCredentials = options.ClientCredentials,
                EncryptionKey = Helpers.ToString(options.EncryptionKey),
                IsServer = options.IsServer,
                OverrideCountryCode = Helpers.ToString(options.OverrideCountryCode),
                OverrideLocaleCode = Helpers.ToString(options.OverrideLocaleCode),
                ProductId = Helpers.ToString(options.ProductId),
                NetworkStatus = NetworkStatus.Offline,
                ApplicationStatus = ApplicationStatus.Foreground
            };
            var conf = Config.GetConfig();
            Config.Save(conf);
            _log.Logger.WriteInfo("Platform_Handler.Create Options: " + PlatformHandler.ToString());
            return IntPtr.CreateChecked(SDK.PlatformPTR);
        }

        public static bool CheckIfPointerValid(IntPtr ptr)
        {
            if (ptr == IntPtr.Zero)
                return false;
            return ptr == IntPtr.CreateChecked(SDK.PlatformPTR);
        }


        public static void Free(IntPtr ptr)
        {
            _log.Logger.WriteDebug("Platform try Free-ing PTR: " + ptr.ToString());
            /*
            if (CheckIfPointerValid(HandlerPointer))
                
            Marshal.FreeHGlobal(ptr);
            */

        }
    }
}
