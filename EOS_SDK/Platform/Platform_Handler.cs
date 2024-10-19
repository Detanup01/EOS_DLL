using EOS_SDK._Coroutines;
using EOS_SDK._Data;
using EOS_SDK._Networking;
using EOS_SDK.Windows;
using System.Runtime.InteropServices;

namespace EOS_SDK.Platform
{
    public class Platform_Handler : IHandler
    {
        public string ProductId = string.Empty;
        public string SandboxId = string.Empty;
        public ClientCredentials ClientCredentials;
        public int IsServer;
        public string EncryptionKey = string.Empty;
        public string OverrideCountryCode = string.Empty;
        public string OverrideLocaleCode = string.Empty;
        public string DeploymentId = string.Empty;
        public NetworkStatus NetworkStatus;
        public ApplicationStatus ApplicationStatus;
        public Dictionary<uint, IHandler> Handlers = new();
        public IntPtr MyDummyPtr;
        public Dictionary<IntPtr, uint> DummyPtrToHandler = new();
        public NetworkMaster Network = new();

        public override string ToString()
        {
            return $"ProductId: {ProductId}, SandboxId: {SandboxId}, ClientCredentials: ({ClientCredentials.ToString()}), IsServer: {IsServer}, EncryptionKey: {EncryptionKey}\n" +
                $"OverrideCountryCode {OverrideCountryCode}, OverrideLocaleCode {OverrideLocaleCode}, DeploymentId {DeploymentId}\n" +
                $"NetworkStatus: {NetworkStatus}, ApplicationStatus: {ApplicationStatus}";
        }
        public IntPtr Create(WindowsOptions windowsOptions)
        {
            SandboxId = Helpers.ToString(windowsOptions.SandboxId);
            DeploymentId = Helpers.ToString(windowsOptions.DeploymentId);
            ClientCredentials = windowsOptions.ClientCredentials;
            EncryptionKey = Helpers.ToString(windowsOptions.EncryptionKey);
            IsServer = windowsOptions.IsServer;
            OverrideCountryCode = Helpers.ToString(windowsOptions.OverrideCountryCode);
            OverrideLocaleCode = Helpers.ToString(windowsOptions.OverrideLocaleCode);
            ProductId = Helpers.ToString(windowsOptions.ProductId);
            NetworkStatus = NetworkStatus.Offline;
            ApplicationStatus = ApplicationStatus.Foreground;
            _log.Logger.WriteInfo("Platform_Handler.Create Windows: " + ToString());
            return Create();
        }

        public IntPtr Create(Options options)
        {
            SandboxId = Helpers.ToString(options.SandboxId);
            DeploymentId = Helpers.ToString(options.DeploymentId);
            ClientCredentials = options.ClientCredentials;
            EncryptionKey = Helpers.ToString(options.EncryptionKey);
            IsServer = options.IsServer;
            OverrideCountryCode = Helpers.ToString(options.OverrideCountryCode);
            OverrideLocaleCode = Helpers.ToString(options.OverrideLocaleCode);
            ProductId = Helpers.ToString(options.ProductId);
            NetworkStatus = NetworkStatus.Offline;
            ApplicationStatus = ApplicationStatus.Foreground;
            _log.Logger.WriteInfo("Platform_Handler.Create Options: " + ToString());
            return Create();
        }

        public bool CheckIfPointerValid(IntPtr ptr)
        {
            if (ptr == IntPtr.Zero)
                return false;
            return ptr == MyDummyPtr;
        }


        public void Free(IntPtr ptr)
        {
            foreach (var handler in Handlers.Values)
            {
                handler.Close();
            }
            Close();
            _log.Logger.WriteDebug("Platform try Free-ing PTR: " + ptr.ToString());
            Marshal.FreeHGlobal(ptr);
        }

        public void Update()
        {
            CallbackManager.Update();
            Network.Update();
            Tick();
        }


        public IntPtr Create()
        {
            CoroutineWorker.Instance.Watch.Start();
            MyDummyPtr = Helpers.StructToPtr(new DummyStruct());
            _log.Logger.WriteInfo("Platform_Handler.Create Pointer: " + MyDummyPtr);
            Handlers.Add(SDK.PlatformPTR, this);
            DummyPtrToHandler.Add(MyDummyPtr, SDK.PlatformPTR);
            Network.Start();
            //  PreCreate All Handles
            foreach (var pointer in SDK.PTRs)
            {
                if (pointer == SDK.PlatformPTR)
                    continue;
                CreateHandler(pointer);
            }
            return MyDummyPtr;
        }

        public void Tick()
        {
            foreach (var handler in Handlers.Values)
            {
                handler.Tick();
            }
        }

        public void Close()
        {
            _log.Logger.WriteInfo("Platform_Handler.Close");
            Network.Stop();
        }

        public IntPtr CreateHandler(uint handlerCRC)
        {
            IHandler? handler = null;
            switch (handlerCRC)
            {
                case SDK.AchievementPTR:
                    handler = new Achievements.Achievements_Handler();
                    break;
                default:
                    break;
            }
            var ptr = IntPtr.Zero;
            if (handler != null)
            {
                ptr = handler.Create(); 
                Handlers.Add(handlerCRC, handler);
                DummyPtrToHandler.Add(ptr, handlerCRC);
            }
            return ptr;
        }

        /// <summary>
        /// Check if the argument is valid.
        /// </summary>
        /// <param name="handle">Handle of the function</param>
        /// <param name="completionDelegate">Delegate for functions</param>
        /// <returns>True if valid</returns>
        public bool CheckArgs(IntPtr handle, IntPtr completionDelegate)
        {
            if (handle == IntPtr.Zero)
                return false;
            if (completionDelegate == IntPtr.Zero)
                return false;
            if (!DummyPtrToHandler.ContainsKey(handle))
                return false;
            return true;
        }

        public bool CheckArgs(IntPtr handle, IntPtr options, IntPtr outParam)
        {
            if (handle == IntPtr.Zero)
                return false;
            if (options == IntPtr.Zero)
                    return false;
            if (outParam == IntPtr.Zero)
                return false;
            if (!DummyPtrToHandler.ContainsKey(handle))
                return false;
            return true;
        }

        public T? GetHandler<T>(IntPtr ptr_handle) where T : IHandler
        {
            if (!DummyPtrToHandler.TryGetValue(ptr_handle, out uint hex))
            {
                return default;
            }
            if (!Handlers.TryGetValue(hex, out IHandler? handler))
            {
                return default;
            }
            if (handler == null)
                return default;
            return (T)handler;
        }

        public T? GetHandlerNoDummy<T>(uint hex) where T : IHandler
        {
            if (!Handlers.TryGetValue(hex, out IHandler? handler))
            {
                return default;
            }
            if (handler == null)
                return default;
            return (T)handler;
        }
    }
}
