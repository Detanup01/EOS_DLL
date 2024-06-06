using EOS_SDK.Others;
using Newtonsoft.Json;

namespace EOS_SDK._Data
{
    public class Config
    {
        public static Config GetConfig()
        {
            if (File.Exists("eos_emu/eos.json"))
            {
                var config = JsonConvert.DeserializeObject<Config>(File.ReadAllText("eos_emu/eos.json"));
                return ApplyConfig(config!);
            }
            return ApplyConfig(new());
        }

        static Config ApplyConfig(Config config)
        {
            if (config.GenerateNewIds)
            {
                config.AccountId = EpicAccountId.Generator(config.AppId, config.UserName);
                config.EpicProductUserId = ProductUserId.Generator(config.AppId, config.UserName);
            }
            return config;
        }

        public static void Save(Config config)
        {
            if (Directory.Exists("eos_emu"))
                Directory.CreateDirectory("eos_emu");
            File.WriteAllText("eos_emu/eos.json", JsonConvert.SerializeObject(config, Formatting.Indented));
        }

        public bool IsLogEnabled = false;
        public bool GenerateNewIds = true;
        public string UserName = "DefaultName";
        public string AppId = "b4a0d2d15acb4db894a599b810297543";
        public string AccountId = "ffaabbccddeeff0123456789deadc0de";
        public string EpicProductUserId = "deadc0deffaabbccddeeff0123456789";
        public string RSA_Private = string.Empty;
        public string RSA_Public = string.Empty;
        public List<string> BannedNetworkUsers = new List<string>();
    }
}
