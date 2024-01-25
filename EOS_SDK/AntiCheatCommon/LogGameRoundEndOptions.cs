using System.Runtime.InteropServices;

namespace EOS_SDK.AntiCheatCommon
{
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct LogGameRoundEndOptions
    {
        public int ApiVersion;
        public uint WinningTeamId;
    }
}