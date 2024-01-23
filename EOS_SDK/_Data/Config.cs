using Newtonsoft.Json;

namespace EOS_SDK._Data
{
    public class Config
    {
        public static Config GetConfig() 
        { 
            if (File.Exists("eos.json"))
            {
                var config = JsonConvert.DeserializeObject<Config>(File.ReadAllText("eos.json"));
                return config;
            }
            return new();
        }

        public bool IsLogEnabled = false;
    }
}
