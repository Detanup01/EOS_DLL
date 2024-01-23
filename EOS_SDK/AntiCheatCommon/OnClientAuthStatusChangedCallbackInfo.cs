using System.Runtime.InteropServices;

namespace EOS_SDK.AntiCheatCommon
{
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct OnClientAuthStatusChangedCallbackInfo
    {
        public IntPtr m_ClientData;
        public IntPtr m_ClientHandle;
        public AntiCheatCommonClientAuthStatus m_ClientAuthStatus;
    }
}