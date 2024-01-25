using System.Runtime.InteropServices;

namespace EOS_SDK.AntiCheatCommon
{
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct LogPlayerSpawnOptions
    {
        public int ApiVersion;
        public IntPtr SpawnedPlayerHandle;
        public uint TeamId;
        public uint CharacterId;
    }
}