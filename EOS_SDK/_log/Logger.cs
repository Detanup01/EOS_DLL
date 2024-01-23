using EOS_SDK._Data;
using LLibrary;

namespace EOS_SDK._log
{
    public class Logger
    {
        public static L Log = new L(true, directory: "eos_log");

        static Config Config = Config.GetConfig();

        public static void WriteMessage(object obj, string label = "MSG")
        {
            if (Config.IsLogEnabled)
                Log.Log(label, obj);
        }

        public static void WriteInfo(object obj)
        {
            if (Config.IsLogEnabled)
                Log.Info(obj);
        }

        public static void WriteWarn(object obj)
        {
            Log.Warn(obj);
        }

        public static void WriteError(object obj)
        {
            Log.Error(obj);
        }
    }
}
