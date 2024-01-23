using System.Runtime.InteropServices;

namespace EOS_SDK.AntiCheatCommon
{
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct SetClientDetailsOptions
    {
        public int m_ApiVersion;
        public IntPtr m_ClientHandle;
        public AntiCheatCommonClientFlags m_ClientFlags;
        public AntiCheatCommonClientInput m_ClientInputMethod;
    }
}