using EOS_SDK.Others;
using System.Text.Json;

namespace EOS_SDK._Data
{
    public class Config
    {
        public static Config GetConfig()
        {
            if (File.Exists("eos_emu/eos.json"))
            {
                var config = JsonSerializer.Deserialize(File.ReadAllText("eos_emu/eos.json"), SourceGenerationContext.Default.Config);
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
            if (!Directory.Exists("eos_emu"))
                Directory.CreateDirectory("eos_emu");
            File.WriteAllBytes("eos_emu/eos.json", JsonSerializer.SerializeToUtf8Bytes(config, SourceGenerationContext.Default.Config));
        }

        public bool IsLogEnabled { get; set; } = false;
        public bool GenerateNewIds { get; set; } = true;
        public string UserName { get; set; } = "DefaultName";
        public string AppId { get; set; } = "b4a0d2d15acb4db894a599b810297543";
        public string AccountId { get; set; } = "ffaabbccddeeff0123456789deadc0de";
        public string EpicProductUserId { get; set; } = "deadc0deffaabbccddeeff0123456789";
        public string RSA_Private { get; set; } = string.Empty;
        public string RSA_Public { get; set; } = string.Empty;
        public List<string> BannedNetworkUsers { get; set; } = [];
        public ConfigNetworking Networking { get; set; } = new();

        public class ConfigNetworking
        {
            public bool UseIPV6 { get; set; } = false;
        }

    }
}
