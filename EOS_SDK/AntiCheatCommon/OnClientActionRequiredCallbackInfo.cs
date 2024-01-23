using System.Runtime.InteropServices;
namespace EOS_SDK.AntiCheatCommon
{

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct OnClientActionRequiredCallbackInfopublic
    {
        public IntPtr m_ClientData;
        public IntPtr m_ClientHandle;
        public AntiCheatCommonClientAction m_ClientAction;
        public AntiCheatCommonClientActionReason m_ActionReasonCode;
        public IntPtr m_ActionReasonDetailsString;
    }
}