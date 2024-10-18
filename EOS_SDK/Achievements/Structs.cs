using EOS_SDK._Data;
using System.Runtime.InteropServices;

namespace EOS_SDK.Achievements
{
    [APIVersion(1)]
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct AddNotifyAchievementsUnlockedOptions
    {
        public int ApiVersion;
    }

    [APIVersion(1)]
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct AddNotifyAchievementsUnlockedV2Options
    {
        public int ApiVersion;
    }

    [APIVersion(1)]
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct CopyAchievementDefinitionByAchievementIdOptions
    {
        public int ApiVersion;
        public IntPtr AchievementId; //string
    }

    [APIVersion(1)]
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct CopyAchievementDefinitionByIndexOptions
    {
        public int ApiVersion;
        public uint AchievementIndex;
    }

    [APIVersion(1)]
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct CopyAchievementDefinitionV2ByAchievementIdOptions
    {
        public int ApiVersion;
        public IntPtr AchievementId; //string
    }

    [APIVersion(1)]
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct CopyAchievementDefinitionV2ByIndexOptions
    {
        public int ApiVersion;
        public uint AchievementIndex;
    }

    [APIVersion(1)]
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct CopyPlayerAchievementByAchievementIdOptionsV1
    {
        public int ApiVersion;
        public IntPtr TargetUserId; //ProductUserId
        public IntPtr AchievementId; //string
    }

    [APIVersion(2)]
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct CopyPlayerAchievementByAchievementIdOptionsV2
    {
        public int ApiVersion;
        public IntPtr TargetUserId; //ProductUserId
        public IntPtr AchievementId; //string
        public IntPtr LocalUserId; //ProductUserId
    }

    [APIVersion(1)]
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct CopyPlayerAchievementByIndexOptionsV1
    {
        public int ApiVersion;
        public IntPtr TargetUserId; //ProductUserId
        public uint AchievementIndex;
    }

    [APIVersion(2)]
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct CopyPlayerAchievementByIndexOptionsV2
    {
        public int ApiVersion;
        public IntPtr TargetUserId; //ProductUserId
        public uint AchievementIndex;
        public IntPtr LocalUserId; //ProductUserId
    }

    [APIVersion(1)]
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct CopyUnlockedAchievementByAchievementIdOptions
    {
        public int ApiVersion;
        public IntPtr UserId; //ProductUserId
        public IntPtr AchievementId; //string
    }

    [APIVersion(1)]
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct CopyUnlockedAchievementByIndexOptions
    {
        public int ApiVersion;
        public IntPtr TargetUserId; //ProductUserId
        public uint AchievementIndex;
    }

    [APIVersion(1)]
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

    [APIVersion(2)]
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

    [APIVersion(1)]
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct GetAchievementDefinitionCountOptions
    {
        public int ApiVersion;
    }

    [APIVersion(1)]
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct GetPlayerAchievementCountOptions
    {
        public int ApiVersion;
        public IntPtr UserId; //ProductUserId
    }

    [APIVersion(1)]
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

        public static OnAchievementsUnlockedCallbackInfo Set(OnAchievementsUnlockedCallbackInfo main, UnlockAchievementsOptions unlockAchievements)
        {
            var ret = new OnAchievementsUnlockedCallbackInfo();
            ret = main;
            ret.UserId = unlockAchievements.UserId;
            ret.AchievementIds = unlockAchievements.AchievementIds;
            ret.AchievementsCount = unlockAchievements.AchievementsCount;
            return ret;
        }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct OnAchievementsUnlockedCallbackV2Info
    {
        public IntPtr ClientData; //object
        public IntPtr UserId; //ProductUserId
        public IntPtr AchievementId; //string
        public long UnlockTime; //System.DateTimeOffset
        public static OnAchievementsUnlockedCallbackV2Info Set(OnAchievementsUnlockedCallbackV2Info main, OnAchievementsUnlockedCallbackV2Info unlockAchievements)
        {
            var ret = new OnAchievementsUnlockedCallbackV2Info();
            ret = main;
            ret.UserId = unlockAchievements.UserId;
            ret.AchievementId = unlockAchievements.AchievementId;
            ret.UnlockTime = unlockAchievements.UnlockTime;
            return ret;
        }
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


    [APIVersion(1)]
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct PlayerAchievementV1
    {
        public int ApiVersion { get => 1; }
        public IntPtr AchievementId; //string
        public long UnlockTime; //DateTimeOffset
        public int StatInfoCount;
        public IntPtr StatInfo; //PlayerStatInfo[]
    }

    [APIVersion(2)]
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct PlayerAchievementV2
    {
        public int ApiVersion { get => 2; }
        public IntPtr AchievementId; //string
        public long UnlockTime; //DateTimeOffset
        public int StatInfoCount;
        public IntPtr StatInfo; //PlayerStatInfo[]
        public IntPtr DisplayName; //string
        public IntPtr Description; //string
        public IntPtr IconURL; //string
        public IntPtr FlavorText; //string
    }

    [APIVersion(1)]
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

    [APIVersion(1)]
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct QueryPlayerAchievementsOptionsV1
    {
        public int ApiVersion { get => 1; }
        public IntPtr TargetUserId; //ProductUserId
    }

    [APIVersion(2)]
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct QueryPlayerAchievementsOptionsV2
    {
        public int ApiVersion { get => 2; }
        public IntPtr TargetUserId; //ProductUserId
        public IntPtr LocalUserId; //ProductUserId
    }

    [APIVersion(1)]
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct StatThresholds
    {
        public int ApiVersion;
        public IntPtr Name; //string
        public int Threshold;
    }

    [APIVersion(1)]
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct UnlockAchievementsOptions
    {
        public int ApiVersion;
        public IntPtr UserId; //ProductUserId
        public IntPtr AchievementIds; //string[]
        public uint AchievementsCount;
    }

    [APIVersion(1)]
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct UnlockedAchievement
    {
        public int ApiVersion;
        public IntPtr AchievementId; //string
        public long UnlockTime; //DateTimeOffset
    }
}
