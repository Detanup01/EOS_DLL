using System.Runtime.InteropServices;

namespace EOS_SDK.Achievements
{
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct AddNotifyAchievementsUnlockedOptions
    {
        public int m_ApiVersion;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct AddNotifyAchievementsUnlockedV2Options
    {
        public int m_ApiVersion;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct CopyAchievementDefinitionByAchievementIdOptions
    {
        public int m_ApiVersion;
        public IntPtr m_AchievementId; //string
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct CopyAchievementDefinitionByIndexOptions
    {
        public int m_ApiVersion;
        public uint m_AchievementIndex;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct CopyAchievementDefinitionV2ByAchievementIdOptions
    {
        public int m_ApiVersion;
        public IntPtr m_AchievementId; //string
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct CopyAchievementDefinitionV2ByIndexOptions
    {
        public int m_ApiVersion;
        public uint m_AchievementIndex;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct CopyPlayerAchievementByAchievementIdOptions
    {
        public int m_ApiVersion;
        public IntPtr m_TargetUserId; //ProductUserId
        public IntPtr m_AchievementId; //string
        public IntPtr m_LocalUserId; //ProductUserId
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct CopyPlayerAchievementByIndexOptions
    {
        public int m_ApiVersion;
        public IntPtr m_TargetUserId; //ProductUserId
        public uint m_AchievementIndex;
        public IntPtr m_LocalUserId; //ProductUserId
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct CopyUnlockedAchievementByAchievementIdOptions
    {
        public int m_ApiVersion;
        public IntPtr m_UserId; //ProductUserId
        public IntPtr m_AchievementId; //string
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct CopyUnlockedAchievementByIndexOptions
    {
        public int m_ApiVersion;
        public IntPtr m_TargetUserId; //ProductUserId
        public uint m_AchievementIndex;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct Definition
    {
        public int m_ApiVersion;
        public IntPtr m_AchievementId; //string
        public IntPtr m_DisplayName; //string
        public IntPtr m_Description; //string
        public IntPtr m_LockedDisplayName; //string
        public IntPtr m_LockedDescription; //string
        public IntPtr m_HiddenDescription; //string
        public IntPtr m_CompletionDescription; //string
        public IntPtr m_UnlockedIconId; //string
        public IntPtr m_LockedIconId; //string
        public int m_IsHidden; //bool
        public int m_StatThresholdsCount;
        public IntPtr m_StatThresholds; //StatThresholds[]
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct DefinitionV2
    {
        public int m_ApiVersion;
        public IntPtr m_AchievementId; //string
        public IntPtr m_UnlockedDisplayName; //string
        public IntPtr m_UnlockedDescription; //string
        public IntPtr m_LockedDisplayName;  //string
        public IntPtr m_LockedDescription;  //string
        public IntPtr m_FlavorText;  //string
        public IntPtr m_UnlockedIconURL; //string
        public IntPtr m_LockedIconURL; //string
        public int m_IsHidden; //bool
        public uint m_StatThresholdsCount;
        public IntPtr m_StatThresholds; //StatThresholds[]
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct GetAchievementDefinitionCountOptions
    {
        public int m_ApiVersion;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct GetPlayerAchievementCountOptions
    {
        public int m_ApiVersion;
        public IntPtr m_UserId; //ProductUserId
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct GetUnlockedAchievementCountOptions
    {
        public int m_ApiVersion;
        public IntPtr m_UserId; //ProductUserId
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct OnAchievementsUnlockedCallbackInfo
    {
        public IntPtr m_ClientData; //object
        public IntPtr m_UserId; //ProductUserId
        public uint m_AchievementsCount;
        public IntPtr m_AchievementIds; //string[]
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct OnAchievementsUnlockedCallbackV2Info
    {
        public IntPtr m_ClientData; //object
        public IntPtr m_UserId; //ProductUserId
        public IntPtr m_AchievementId; //string
        public long m_UnlockTime; //System.DateTimeOffset
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct OnQueryDefinitionsCompleteCallbackInfo
    {
        public Result m_ResultCode;
        public IntPtr m_ClientData; //object
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct OnQueryPlayerAchievementsCompleteCallbackInfo
    {
        public Result m_ResultCode;
        public IntPtr m_ClientData; //object
        public IntPtr m_UserId; //ProductUserId
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct OnUnlockAchievementsCompleteCallbackInfo
    {
        public Result m_ResultCode;
        public IntPtr m_ClientData; //object
        public IntPtr m_UserId; //ProductUserId
        public uint m_AchievementsCount;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct PlayerAchievement
    {
        public int m_ApiVersion;
        public IntPtr m_AchievementId; //string
        public long m_UnlockTime; //DateTimeOffset
        public int m_StatInfoCount;
        public IntPtr m_StatInfo; //PlayerStatInfo[]
        public IntPtr m_DisplayName; //string
        public IntPtr m_Description; //string
        public IntPtr m_IconURL; //string
        public IntPtr m_FlavorText; //string
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct PlayerStatInfo
    {
        public int m_ApiVersion;
        public IntPtr m_Name; //string
        public int m_CurrentValue;
        public int m_ThresholdValue;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct QueryDefinitionsOptions
    {
        public int m_ApiVersion;
        public IntPtr m_LocalUserId; //ProductUserId
        public IntPtr m_EpicUserId_DEPRECATED; //EpicAccountId
        public IntPtr m_HiddenAchievementIds_DEPRECATED; //string[]
        public uint m_HiddenAchievementsCount_DEPRECATED;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct QueryPlayerAchievementsOptions
    {
        public int m_ApiVersion;
        public IntPtr m_TargetUserId; //ProductUserId
        public IntPtr m_LocalUserId; //ProductUserId
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct StatThresholds
    {
        public int m_ApiVersion;
        public IntPtr m_Name; //string
        public int m_Threshold;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct UnlockAchievementsOptions
    {
        public int m_ApiVersion;
        public IntPtr m_UserId; //ProductUserId
        public IntPtr m_AchievementIds; //string[]
        public uint m_AchievementsCount;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct UnlockedAchievementpublic
    {
        public int m_ApiVersion;
        public IntPtr m_AchievementId; //string
        public long m_UnlockTime; //DateTimeOffset
    }
}
