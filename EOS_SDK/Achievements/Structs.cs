using System.Runtime.InteropServices;

namespace EOS_SDK.Achievements
{
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct AddNotifyAchievementsUnlockedOptions
    {
        public int ApiVersion;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct AddNotifyAchievementsUnlockedV2Options
    {
        public int ApiVersion;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct CopyAchievementDefinitionByAchievementIdOptions
    {
        public int ApiVersion;
        public IntPtr AchievementId; //string
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct CopyAchievementDefinitionByIndexOptions
    {
        public int ApiVersion;
        public uint AchievementIndex;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct CopyAchievementDefinitionV2ByAchievementIdOptions
    {
        public int ApiVersion;
        public IntPtr AchievementId; //string
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct CopyAchievementDefinitionV2ByIndexOptions
    {
        public int ApiVersion;
        public uint AchievementIndex;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct CopyPlayerAchievementByAchievementIdOptions
    {
        public int ApiVersion;
        public IntPtr TargetUserId; //ProductUserId
        public IntPtr AchievementId; //string
        public IntPtr LocalUserId; //ProductUserId
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct CopyPlayerAchievementByIndexOptions
    {
        public int ApiVersion;
        public IntPtr TargetUserId; //ProductUserId
        public uint AchievementIndex;
        public IntPtr LocalUserId; //ProductUserId
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct CopyUnlockedAchievementByAchievementIdOptions
    {
        public int ApiVersion;
        public IntPtr UserId; //ProductUserId
        public IntPtr AchievementId; //string
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct CopyUnlockedAchievementByIndexOptions
    {
        public int ApiVersion;
        public IntPtr TargetUserId; //ProductUserId
        public uint AchievementIndex;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct Definition
    {
        public int ApiVersion;
        public IntPtr AchievementId; //string
        public IntPtr DisplayName; //string
        public IntPtr Description; //string
        public IntPtr LockedDisplayName; //string
        public IntPtr LockedDescription; //string
        public IntPtr HiddenDescription; //string
        public IntPtr CompletionDescription; //string
        public IntPtr UnlockedIconId; //string
        public IntPtr LockedIconId; //string
        public int IsHidden; //bool
        public int StatThresholdsCount;
        public IntPtr StatThresholds; //StatThresholds[]
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct DefinitionV2
    {
        public int ApiVersion;
        public IntPtr AchievementId; //string
        public IntPtr UnlockedDisplayName; //string
        public IntPtr UnlockedDescription; //string
        public IntPtr LockedDisplayName;  //string
        public IntPtr LockedDescription;  //string
        public IntPtr FlavorText;  //string
        public IntPtr UnlockedIconURL; //string
        public IntPtr LockedIconURL; //string
        public int IsHidden; //bool
        public uint StatThresholdsCount;
        public IntPtr StatThresholds; //StatThresholds[]
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct GetAchievementDefinitionCountOptions
    {
        public int ApiVersion;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct GetPlayerAchievementCountOptions
    {
        public int ApiVersion;
        public IntPtr UserId; //ProductUserId
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct GetUnlockedAchievementCountOptions
    {
        public int ApiVersion;
        public IntPtr UserId; //ProductUserId
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct OnAchievementsUnlockedCallbackInfo
    {
        public IntPtr ClientData; //object
        public IntPtr UserId; //ProductUserId
        public uint AchievementsCount;
        public IntPtr AchievementIds; //string[]
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct OnAchievementsUnlockedCallbackV2Info
    {
        public IntPtr ClientData; //object
        public IntPtr UserId; //ProductUserId
        public IntPtr AchievementId; //string
        public long UnlockTime; //System.DateTimeOffset
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct OnQueryDefinitionsCompleteCallbackInfo
    {
        public Result ResultCode;
        public IntPtr ClientData; //object
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct OnQueryPlayerAchievementsCompleteCallbackInfo
    {
        public Result ResultCode;
        public IntPtr ClientData; //object
        public IntPtr UserId; //ProductUserId
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct OnUnlockAchievementsCompleteCallbackInfo
    {
        public Result ResultCode;
        public IntPtr ClientData; //object
        public IntPtr UserId; //ProductUserId
        public uint AchievementsCount;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct PlayerAchievement
    {
        public int ApiVersion;
        public IntPtr AchievementId; //string
        public long UnlockTime; //DateTimeOffset
        public int StatInfoCount;
        public IntPtr StatInfo; //PlayerStatInfo[]
        public IntPtr DisplayName; //string
        public IntPtr Description; //string
        public IntPtr IconURL; //string
        public IntPtr FlavorText; //string
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct PlayerStatInfo
    {
        public int ApiVersion;
        public IntPtr Name; //string
        public int CurrentValue;
        public int ThresholdValue;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct QueryDefinitionsOptions
    {
        public int ApiVersion;
        public IntPtr LocalUserId; //ProductUserId
        public IntPtr EpicUserId_DEPRECATED; //EpicAccountId
        public IntPtr HiddenAchievementIds_DEPRECATED; //string[]
        public uint HiddenAchievementsCount_DEPRECATED;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct QueryPlayerAchievementsOptions
    {
        public int ApiVersion;
        public IntPtr TargetUserId; //ProductUserId
        public IntPtr LocalUserId; //ProductUserId
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct StatThresholds
    {
        public int ApiVersion;
        public IntPtr Name; //string
        public int Threshold;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct UnlockAchievementsOptions
    {
        public int ApiVersion;
        public IntPtr UserId; //ProductUserId
        public IntPtr AchievementIds; //string[]
        public uint AchievementsCount;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct UnlockedAchievement
    {
        public int ApiVersion;
        public IntPtr AchievementId; //string
        public long UnlockTime; //DateTimeOffset
    }
}
