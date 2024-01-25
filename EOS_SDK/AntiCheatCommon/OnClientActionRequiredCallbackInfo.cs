using System.Runtime.InteropServices;
namespace EOS_SDK.AntiCheatCommon
{

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct OnClientActionRequiredCallbackInfo
    {
        public IntPtr ClientData;
        public IntPtr ClientHandle;
        public AntiCheatCommonClientAction ClientAction;
        public AntiCheatCommonClientActionReason ActionReasonCode;
        public IntPtr ActionReasonDetailsString;
    }
}