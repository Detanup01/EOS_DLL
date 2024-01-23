using System.Runtime.InteropServices;

namespace EOS_SDK.AntiCheatCommon
{

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct LogPlayerTickOptionspublic
    {
        public int m_ApiVersion;
        public IntPtr m_PlayerHandle;
        public IntPtr m_PlayerPosition;
        public IntPtr m_PlayerViewRotation;
        public int m_IsPlayerViewZoomed;
        public float m_PlayerHealth;
        public AntiCheatCommonPlayerMovementState m_PlayerMovementState;
    }
}