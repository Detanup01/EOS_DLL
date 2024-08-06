using System.Runtime.InteropServices;

namespace EOS_SDK.Version
{
    public class Version_Exports
    {
        [UnmanagedCallersOnly(EntryPoint = "EOS_GetVersion")]
        public static IntPtr EOS_GetVersion()
        {
            return Helpers.FromString(_Data.SDK.Version);
        }
    }
}
