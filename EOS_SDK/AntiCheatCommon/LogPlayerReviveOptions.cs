using System.Runtime.InteropServices;

namespace EOS_SDK.AntiCheatCommon
{
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct LogPlayerReviveOptions
    {
        public int ApiVersion;
        public IntPtr RevivedPlayerHandle;
        public IntPtr ReviverPlayerHandle;
    }
}