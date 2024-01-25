using System.Runtime.InteropServices;

namespace EOS_SDK.AntiCheatCommon
{
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct LogGameRoundStartOptions
    {
        public int ApiVersion;
        public IntPtr SessionIdentifier;
        public IntPtr LevelName;
        public IntPtr ModeName;
        public uint RoundTimeSeconds;
    }
}