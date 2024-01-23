using System.Runtime.InteropServices;

namespace EOS_SDK.AntiCheatCommon
{

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct LogPlayerDespawnOptionspublic
    {
        public int m_ApiVersion;
        public IntPtr m_DespawnedPlayerHandle;
    }
}