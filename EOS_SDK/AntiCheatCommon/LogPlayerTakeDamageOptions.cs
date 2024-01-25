using System.Runtime.InteropServices;

namespace EOS_SDK.AntiCheatCommon
{

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct LogPlayerTakeDamageOptions
    {
        public int ApiVersion;
        public IntPtr VictimPlayerHandle;
        public IntPtr VictimPlayerPosition;
        public IntPtr VictimPlayerViewRotation;
        public IntPtr AttackerPlayerHandle;
        public IntPtr AttackerPlayerPosition;
        public IntPtr AttackerPlayerViewRotation;
        public int IsHitscanAttack;
        public int HasLineOfSight;
        public int IsCriticalHit;
        public uint HitBoneId_DEPRECATED;
        public float DamageTaken;
        public float HealthRemaining;
        public AntiCheatCommonPlayerTakeDamageSource DamageSource;
        public AntiCheatCommonPlayerTakeDamageType DamageType;
        public AntiCheatCommonPlayerTakeDamageResult DamageResult;
        public IntPtr PlayerUseWeaponData;
        public uint TimeSincePlayerUseWeaponMs;
        public IntPtr DamagePosition;
    }
}