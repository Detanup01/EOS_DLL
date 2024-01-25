using System.Runtime.InteropServices;

namespace EOS_SDK.AntiCheatCommon
{
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct OnClientAuthStatusChangedCallbackInfo
    {
        public IntPtr ClientData;
        public IntPtr ClientHandle;
        public AntiCheatCommonClientAuthStatus ClientAuthStatus;
    }
}