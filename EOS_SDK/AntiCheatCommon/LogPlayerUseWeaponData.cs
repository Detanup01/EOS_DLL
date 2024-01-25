using System.Runtime.InteropServices;

namespace EOS_SDK.AntiCheatCommon
{
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct LogPlayerUseWeaponData
    {
        public IntPtr PlayerHandle;
        public IntPtr PlayerPosition;
        public IntPtr PlayerViewRotation;
        public int IsPlayerViewZoomed;
        public int IsMeleeAttack;
        public IntPtr WeaponName;
    }
}