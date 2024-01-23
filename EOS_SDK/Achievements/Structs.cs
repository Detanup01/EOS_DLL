using System.Runtime.InteropServices;

namespace EOS_SDK.Achievements
{
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct AddNotifyAchievementsUnlockedOptionspublic
    {
        public int m_ApiVersion { get => 1; }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct AddNotifyAchievementsUnlockedV2Optionspublic
    {
        public int m_ApiVersion { get => 2; }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct CopyAchievementDefinitionByAchievementIdOptionspublic
    {
        public int m_ApiVersion { get => 2; }
        public IntPtr m_AchievementId; //string
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct CopyAchievementDefinitionByIndexOptionspublic
    {
        public int m_ApiVersion { get => 1; }
        public uint m_AchievementIndex;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct CopyAchievementDefinitionV2ByAchievementIdOptionspublic
    {
        public int m_ApiVersion { get => 2; }
        public IntPtr m_AchievementId; //string
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct CopyAchievementDefinitionV2ByIndexOptionspublic
    {
        public int m_ApiVersion { get => 2; }
        public uint m_AchievementIndex;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct CopyPlayerAchievementByAchievementIdOptionspublic
    {
        public int m_ApiVersion { get => 2; }
        public IntPtr m_TargetUserId; //ProductUserId
        public IntPtr m_AchievementId; //string
        public IntPtr m_LocalUserId; //ProductUserId
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct CopyPlayerAchievementByIndexOptionspublic
    {
        public int m_ApiVersion;
        public IntPtr m_TargetUserId; //ProductUserId
        public uint m_AchievementIndex;
        public IntPtr m_LocalUserId; //ProductUserId
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct CopyUnlockedAchievementByAchievementIdOptionspublic
    {
        public int m_ApiVersion;
        public IntPtr m_UserId; //ProductUserId
        public IntPtr m_AchievementId; //string
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct CopyUnlockedAchievementByIndexOptionspublic
    {
        public int m_ApiVersion;
        public IntPtr m_TargetUserId; //ProductUserId
        public uint m_AchievementIndex;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct Definitionpublic
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
    public struct DefinitionV2public
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
    public struct GetAchievementDefinitionCountOptionspublic
    {
        public int m_ApiVersion;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct GetPlayerAchievementCountOptionspublic
    {
        public int m_ApiVersion;
        public IntPtr m_UserId; //ProductUserId
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct GetUnlockedAchievementCountOptionspublic
    {
        public int m_ApiVersion;
        public IntPtr m_UserId; //ProductUserId
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct OnAchievementsUnlockedCallbackInfopublic
    {
        public IntPtr m_ClientData; //object
        public IntPtr m_UserId; //ProductUserId
        public uint m_AchievementsCount;
        public IntPtr m_AchievementIds; //string[]
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct OnAchievementsUnlockedCallbackV2Infopublic
    {
        public IntPtr m_ClientData; //object
        public IntPtr m_UserId; //ProductUserId
        public IntPtr m_AchievementId; //string
        public long m_UnlockTime; //System.DateTimeOffset
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct OnQueryDefinitionsCompleteCallbackInfopublic
    {
        public Result m_ResultCode;
        public IntPtr m_ClientData; //object
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct OnQueryPlayerAchievementsCompleteCallbackInfopublic
    {
        public Result m_ResultCode;
        public IntPtr m_ClientData; //object
        public IntPtr m_UserId; //ProductUserId
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct OnUnlockAchievementsCompleteCallbackInfopublic
    {
        public Result m_ResultCode;
        public IntPtr m_ClientData; //object
        public IntPtr m_UserId; //ProductUserId
        public uint m_AchievementsCount;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct PlayerAchievementpublic
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
    public struct PlayerStatInfopublic
    {
        public int m_ApiVersion;
        public IntPtr m_Name; //string
        public int m_CurrentValue;
        public int m_ThresholdValue;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct QueryDefinitionsOptionspublic
    {
        public int m_ApiVersion;
        public IntPtr m_LocalUserId; //ProductUserId
        public IntPtr m_EpicUserId_DEPRECATED; //EpicAccountId
        public IntPtr m_HiddenAchievementIds_DEPRECATED; //string[]
        public uint m_HiddenAchievementsCount_DEPRECATED;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct QueryPlayerAchievementsOptionspublic
    {
        public int m_ApiVersion;
        public IntPtr m_TargetUserId; //ProductUserId
        public IntPtr m_LocalUserId; //ProductUserId
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct StatThresholdspublic
    {
        public int m_ApiVersion;
        public IntPtr m_Name; //string
        public int m_Threshold;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct UnlockAchievementsOptionspublic
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
