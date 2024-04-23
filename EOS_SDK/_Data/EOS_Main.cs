using EOS_SDK.Platform;

namespace EOS_SDK._Data
{
    public class EOS_Main
    {
        static EOS_Main? Main;

        public string ProductName;
        public string ProductVersion;

        public EOS_Main(IntPtr name, IntPtr version)
        {
            ProductName = Helpers.ToString(name);
            ProductVersion = Helpers.ToString(version);
        }

        public bool IsInit = false;
        static Platform_Handler? _Platform;
        static Config? _Config;
        public static void Create(InitializeOptionsV1 options)
        {
            Main = new EOS_Main(options.ProductName, options.ProductVersion);

            GetConfig();
            GetPlatform();
            Main.IsInit = true;
        }

        public static bool IsInited()
        {
            if (Main != null) 
            {
                return Main.IsInit;
            }
            return false;
        }

        public static void Shutdown()
        {
            GetPlatform().Close();
            Main = null;
        }


        public static Platform_Handler GetPlatform()
        {
            if (_Platform == null)
            {
                _Platform = new Platform_Handler();
            }
            return _Platform;
        }

        public static Config GetConfig()
        {
            if (_Config == null)
            {
                _Config = Config.GetConfig();
                JWTHelper.RSA_Config();
                Config.Save(_Config);
            }
            return _Config;
        }

        public static bool IsMyUser(IntPtr ptr)
        {
            string str = Helpers.ToString(ptr);
            if (GetConfig().AccountId == str || GetConfig().EpicProductUserId == str)
                return true;
            return false;
        }
    }
}
