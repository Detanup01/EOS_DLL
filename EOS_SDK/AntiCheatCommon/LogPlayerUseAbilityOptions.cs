using System.Runtime.InteropServices;
namespace EOS_SDK.AntiCheatCommon
{

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct LogPlayerUseAbilityOptions
    {
        public int ApiVersion;
        public IntPtr PlayerHandle;
        public uint AbilityId;
        public uint AbilityDurationMs;
        public uint AbilityCooldownMs;
    }
}