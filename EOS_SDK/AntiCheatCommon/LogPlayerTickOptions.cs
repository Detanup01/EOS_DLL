using System.Runtime.InteropServices;

namespace EOS_SDK.AntiCheatCommon
{

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct LogPlayerTickOptions
    {
        public int ApiVersion;
        public IntPtr PlayerHandle;
        public IntPtr PlayerPosition;
        public IntPtr PlayerViewRotation;
        public int IsPlayerViewZoomed;
        public float PlayerHealth;
        public AntiCheatCommonPlayerMovementState PlayerMovementState;
    }
}