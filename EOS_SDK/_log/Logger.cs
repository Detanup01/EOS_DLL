using EOS_SDK._Data;
using LLibrary;
using System.Runtime.CompilerServices;

namespace EOS_SDK._log
{
    public class Logger
    {
        public static L Log = new L(true, directory: "eos_log");

        static Config Config = Config.GetConfig();
        static Logging.LogLevel LogLevel = Logging.LogLevel.Off;
        static IntPtr Callback = IntPtr.Zero;
        public static void SetLogLevel(Logging.LogCategory logCategory, Logging.LogLevel logLevel)
        {
            if (logCategory == Logging.LogCategory.AllCategories)
            {


            }
            LogLevel = logLevel;
        }
        public static void AddCallback(IntPtr callback)
        {
            Callback = callback;
        }

        static unsafe void WriteToEPIC(string? message, Logging.LogCategory category, Logging.LogLevel logLevel)
        {
            if (message == null)
                return;
            if (Callback == IntPtr.Zero)
                return;
            if (!(LogLevel <= logLevel))
                return;
            delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)Callback;
            Logging.LogMessage logMessage = new()
            { 
                Level = logLevel,
                Category = Helpers.FromString(category.ToString()),
                Message = Helpers.FromString(message)
            };
            @delegate(Helpers.StructToPtr(logMessage));
        }


        public static void Write(object obj, Logging.LogCategory logCategory = Logging.LogCategory.Core, [CallerMemberName] string membername = "Logger")
        {
            if (Config.IsLogEnabled)
                Log.Log("WriteOut", $"[{membername}] ({logCategory}) {obj}");
            WriteToEPIC(obj.ToString(), logCategory, Logging.LogLevel.Verbose);
        }

        public static void WriteInfo(object obj, Logging.LogCategory logCategory = Logging.LogCategory.Core, [CallerMemberName] string membername = "Logger")
        {
            if (Config.IsLogEnabled)
                Log.Info($"[{membername}] {obj}");
            WriteToEPIC(obj.ToString(), logCategory, Logging.LogLevel.Info);
        }

        public static void WriteDebug(object obj, Logging.LogCategory logCategory = Logging.LogCategory.Core, [CallerMemberName] string membername = "Logger")
        {
            if (Config.IsLogEnabled)
                Log.Debug($"[{membername}] {obj}");
            WriteToEPIC(obj.ToString(), logCategory, Logging.LogLevel.VeryVerbose);
        }

        public static void WriteWarn(object obj, Logging.LogCategory logCategory = Logging.LogCategory.Core, [CallerMemberName] string membername = "Logger")
        {
            Log.Warn($"[{membername}] {obj}");
            WriteToEPIC(obj.ToString(), logCategory, Logging.LogLevel.Warning);
        }

        public static void WriteError(object obj, Logging.LogCategory logCategory = Logging.LogCategory.Core, [CallerMemberName] string membername = "Logger")
        {
            Log.Error($"[{membername}] {obj}");
            WriteToEPIC(obj.ToString(), logCategory, Logging.LogLevel.Error);
        }
    }
}
