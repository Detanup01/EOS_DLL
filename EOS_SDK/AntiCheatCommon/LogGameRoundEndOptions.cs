using System.Runtime.InteropServices;

namespace EOS_SDK.AntiCheatCommon
{
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct LogGameRoundEndOptions
    {
        public int m_ApiVersion;
        public uint m_WinningTeamId;
    }
}