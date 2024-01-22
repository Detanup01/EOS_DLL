using System.Runtime.InteropServices;

namespace EOS_SDK.Achievements
{
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct AddNotifyAchievementsUnlockedOptionsInternal
    {
        public int m_ApiVersion;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct OnAchievementsUnlockedCallbackInfoInternal
    {
        public IntPtr m_ClientData;
        public IntPtr m_UserId;
        public uint m_AchievementsCount;
        public IntPtr m_AchievementIds;
    }
}
