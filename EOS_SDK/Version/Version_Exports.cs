using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace EOS_SDK.Version
{
    public class Version_Exports
    {
        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr _EOS_GetVersion()
        {
            return Helpers.FromString(_Data.SDK.Version);
        }
    }
}
