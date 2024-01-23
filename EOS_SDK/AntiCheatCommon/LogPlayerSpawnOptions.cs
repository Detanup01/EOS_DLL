using System.Runtime.InteropServices;

namespace EOS_SDK.AntiCheatCommon
{
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct LogPlayerSpawnOptionspublic
    {
        public int m_ApiVersion;
        public IntPtr m_SpawnedPlayerHandle;
        public uint m_TeamId;
        public uint m_CharacterId;
    }
}