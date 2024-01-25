using System.Runtime.InteropServices;

namespace EOS_SDK.AntiCheatCommon
{
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct SetGameSessionIdOptions
    {
        public int ApiVersion;
        public IntPtr GameSessionId;
    }
}