using System.Runtime.InteropServices;

namespace EOS_SDK.AntiCheatCommon
{
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct SetClientDetailsOptions
    {
        public int ApiVersion;
        public IntPtr ClientHandle;
        public AntiCheatCommonClientFlags ClientFlags;
        public AntiCheatCommonClientInput ClientInputMethod;
    }
}