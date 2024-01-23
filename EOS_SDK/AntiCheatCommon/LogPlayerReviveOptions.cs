using System.Runtime.InteropServices;

namespace EOS_SDK.AntiCheatCommon
{
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct LogPlayerReviveOptions
    {
        public int m_ApiVersion;
        public IntPtr m_RevivedPlayerHandle;
        public IntPtr m_ReviverPlayerHandle;
    }
}