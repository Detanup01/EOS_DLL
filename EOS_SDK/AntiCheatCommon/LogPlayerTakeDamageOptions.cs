using System.Runtime.InteropServices;

namespace EOS_SDK.AntiCheatCommon
{

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct LogPlayerTakeDamageOptionspublic
    {
        public int m_ApiVersion;
        public IntPtr m_VictimPlayerHandle;
        public IntPtr m_VictimPlayerPosition;
        public IntPtr m_VictimPlayerViewRotation;
        public IntPtr m_AttackerPlayerHandle;
        public IntPtr m_AttackerPlayerPosition;
        public IntPtr m_AttackerPlayerViewRotation;
        public int m_IsHitscanAttack;
        public int m_HasLineOfSight;
        public int m_IsCriticalHit;
        public uint m_HitBoneId_DEPRECATED;
        public float m_DamageTaken;
        public float m_HealthRemaining;
        public AntiCheatCommonPlayerTakeDamageSource m_DamageSource;
        public AntiCheatCommonPlayerTakeDamageType m_DamageType;
        public AntiCheatCommonPlayerTakeDamageResult m_DamageResult;
        public IntPtr m_PlayerUseWeaponData;
        public uint m_TimeSincePlayerUseWeaponMs;
        public IntPtr m_DamagePosition;
    }
}