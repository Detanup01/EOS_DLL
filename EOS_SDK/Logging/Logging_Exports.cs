using EOS_SDK._log;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace EOS_SDK.Logging
{
    public unsafe class Logging_Exports
    {
#if true
        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_Logging_SetCallback(IntPtr callback)
        {
            Logger.AddCallback(callback);
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_Logging_SetLogLevel(int logCategory, int logLevel)
        {
            Logger.SetLogLevel((LogCategory)logCategory, (LogLevel)logLevel);
            return (int)Result.Success;
        }
#endif
    }
}
