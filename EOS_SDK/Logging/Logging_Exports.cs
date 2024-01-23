using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOS_SDK.Logging
{
    public unsafe class Mods_Exports
    {
#if false
        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Logging_SetCallback(Logging.LogMessageFuncInternal callback)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Logging_SetLogLevel(Logging.LogCategory logCategory, Logging.LogLevel logLevel)
        {
        }
#endif
    }
}
