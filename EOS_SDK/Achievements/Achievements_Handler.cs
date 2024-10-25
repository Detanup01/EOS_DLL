using EOS_SDK._Data;
using EOS_SDK._Data.Models;
using EOS_SDK._Networking.Packets;
using EOS_SDK._Networking.Packets.ResponsePackets;
using EOS_SDK.Version;
using System.Text.Json;

namespace EOS_SDK.Achievements;

public class Achievements_Handler : IHandler
{
    public List<Achievement_Model> Achievements = []; // Achivements. DO NOT EDIT
    public Dictionary<string, List<Achievement_Model>> AchKVs = []; //User Dependent Achieves


    List<string> _AchReqs = [];
    List<string> _SentReq = [];
    public UnlockAchievementsOptions UnlockAchievements(UnlockAchievementsOptions options)
    {
        var Ach = GetAchievement_FromAccount(Helpers.ToUTF8String(options.UserId));
        var achis = Helpers.ToStructArray<string>(options.AchievementIds, (int)options.AchievementsCount);
        _log.Logger.WriteDebug("Achi IDs to Unlock:" + JsonSerializer.Serialize(achis, SourceGenerationContext.Default.ListString), Logging.LogCategory.Achievements);

        var achiv = Ach.Where(x => achis.Contains(x.AchievementId)).ToList();
        List<string> UnlockedAchis = new();
        foreach (var item in achiv)
        {
            UnlockedAchis.Add(item.AchievementId);
            item.UnlockedTime = TimeHelper.ConvertTimeFrom(DateTimeOffset.UtcNow);
            OnAchievementsUnlockedCallbackV2Info info = new()
            {
                AchievementId = Helpers.FromString(item.AchievementId),
                UnlockTime = item.UnlockedTime,
                UserId = options.UserId
            };
            NotifyManager.TriggerNotify("Ach_UnlockedV2", info);
        }
        var ptr = Helpers.FromStructArray(UnlockedAchis.ToArray());
        UnlockAchievementsOptions unlockAchievementsOptions = new()
        {
            ApiVersion = options.ApiVersion,
            UserId = options.UserId,
            AchievementIds = ptr,
            AchievementsCount = (uint)UnlockedAchis.Count
        };
        SaveAchis();
        AchiSync();
        return unlockAchievementsOptions;
    }

    #region Achi Check
    public bool IsAchiExist(IntPtr ptr)
    {
        string achi = Helpers.ToUTF8String(ptr);
        return Achievements.Where(x => x.AchievementId == achi).Any();
    }

    public bool IsAchiExistIndex(uint index)
    {
        return Achievements.Count > index;
    }
    #endregion
    #region GetX
    public Definition GetDefinition(IntPtr ptr)
    {
        string achi = Helpers.ToUTF8String(ptr);
        int indx = Achievements.FindIndex(0, x => x.AchievementId == achi);
        return GetDefinitionIndex((uint)indx);
    }

    public Definition GetDefinitionIndex(uint index)
    {
        if (Achievements.Count >= index)
            return default;

        var achiv = Achievements[(int)index];

        List<StatThresholds> thresholds = new();
        foreach (var item in achiv.StatsThresholds)
        {
            StatThresholds statThresholds = new()
            {
                ApiVersion = Versions.StatthresholdsApiLatest,
                Name = Helpers.FromString(item.Name),
                Threshold = item.Threshold
            };
            thresholds.Add(statThresholds);
        }

        return new()
        {
            ApiVersion = Versions.DefinitionApiLatest_Achievements,
            AchievementId = Helpers.FromString(achiv.AchievementId),
            Description = Helpers.FromString(achiv.UnlockedDescription),
            DisplayName = Helpers.FromString(achiv.UnlockedDisplayName),
            CompletionDescription = Helpers.FromString(achiv.UnlockedDisplayName),
            HiddenDescription = Helpers.FromString(achiv.UnlockedDescription),
            LockedDescription = Helpers.FromString(achiv.LockedDescription),
            LockedDisplayName = Helpers.FromString(achiv.LockedDisplayName),
            IsHidden = Convert.ToInt32(achiv.IsHidden),
            LockedIconId = Helpers.FromString(achiv.LockedIconUrl),
            StatThresholds = Helpers.FromStructArray(thresholds.ToArray()),
            StatThresholdsCount = thresholds.Count,
            UnlockedIconId = Helpers.FromString(achiv.UnlockedIconUrl)
        };
    }

    public DefinitionV2 GetDefinitionV2(IntPtr ptr)
    {
        string achi = Helpers.ToUTF8String(ptr);
        int indx = Achievements.FindIndex(0, x => x.AchievementId == achi);
        return GetDefinitionV2Index((uint)indx);
    }

    public DefinitionV2 GetDefinitionV2Index(uint index)
    {
        if (Achievements.Count >= index)
            return default;

        var achiv = Achievements[(int)index];

        List<StatThresholds> thresholds = new();
        foreach (var item in achiv.StatsThresholds)
        {
            StatThresholds statThresholds = new()
            {
                ApiVersion = Versions.StatthresholdsApiLatest,
                Name = Helpers.FromString(item.Name),
                Threshold = item.Threshold
            };
            thresholds.Add(statThresholds);
        }

        return new()
        {
            ApiVersion = Versions.Definitionv2ApiLatest,
            AchievementId = Helpers.FromString(achiv.AchievementId),
            UnlockedDescription = Helpers.FromString(achiv.UnlockedDescription),
            UnlockedDisplayName = Helpers.FromString(achiv.UnlockedDisplayName),
            LockedDescription = Helpers.FromString(achiv.LockedDescription),
            LockedDisplayName = Helpers.FromString(achiv.LockedDisplayName),
            IsHidden = Convert.ToInt32(achiv.IsHidden),
            LockedIconURL = Helpers.FromString(achiv.LockedIconUrl),
            StatThresholds = Helpers.FromStructArray(thresholds.ToArray()),
            StatThresholdsCount = (uint)thresholds.Count,
            UnlockedIconURL = Helpers.FromString(achiv.UnlockedIconUrl),
            FlavorText = Helpers.FromString(achiv.FlavorText),
        };
    }

    public UnlockedAchievement GetUnlockedAchievement(string AccountId, IntPtr ptr)
    {
        string achi = Helpers.ToUTF8String(ptr);
        var indx = GetAchievement_FromAccount(AccountId).FindIndex(0, x => x.AchievementId == achi);
        return GetUnlockedAchievementIndex(AccountId, (uint)indx);
    }

    public UnlockedAchievement GetUnlockedAchievementIndex(string AccountId, uint index)
    {
        if (GetAchievement_FromAccount(AccountId).Count >= index)
            return default;

        var achiv = GetAchievement_FromAccount(AccountId)[(int)index];
        UnlockedAchievement res = new()
        {
            ApiVersion = Versions.UnlockedachievementApiLatest,
            AchievementId = Helpers.FromString(achiv.AchievementId),
            UnlockTime = achiv.UnlockedTime,
        };
        DisposeOtherAccountAch(AccountId);
        return res;
    }

    public PlayerAchievementV1 GetPlayerAchievementV1(string AccountId, IntPtr ptr)
    {
        string achi = Helpers.ToUTF8String(ptr);
        var indx = GetAchievement_FromAccount(AccountId).FindIndex(0, x => x.AchievementId == achi);
        return GetPlayerAchievementV1Index(AccountId, (uint)indx);
    }

    public PlayerAchievementV1 GetPlayerAchievementV1Index(string AccountId, uint index)
    {
        if (GetAchievement_FromAccount(AccountId).Count >= index)
            return default;

        var achiv = GetAchievement_FromAccount(AccountId)[(int)index];

        List<PlayerStatInfo> statInfos = new();
        foreach (var item in achiv.StatsThresholds)
        {
            PlayerStatInfo statThresholds = new()
            {
                ApiVersion = 1,
                Name = Helpers.FromString(item.Name),
                CurrentValue = item.Current,
                ThresholdValue = item.Threshold,
            };
            statInfos.Add(statThresholds);
        }


        PlayerAchievementV1 res = new()
        {
            AchievementId = Helpers.FromString(achiv.AchievementId),
            StatInfoCount = statInfos.Count,
            StatInfo = Helpers.FromStructArray(statInfos.ToArray()),
            UnlockTime = achiv.UnlockedTime
        };
        DisposeOtherAccountAch(AccountId);
        return res;
    }

    public PlayerAchievementV2 GetPlayerAchievementV2(string AccountId, IntPtr ptr)
    {
        string achi = Helpers.ToUTF8String(ptr);
        var indx = GetAchievement_FromAccount(AccountId).FindIndex(0, x => x.AchievementId == achi);
        return GetPlayerAchievementV2Index(AccountId, (uint)indx);
    }

    public PlayerAchievementV2 GetPlayerAchievementV2Index(string AccountId, uint index)
    {
        if (GetAchievement_FromAccount(AccountId).Count >= index)
            return default;

        var achiv = GetAchievement_FromAccount(AccountId)[(int)index];

        List<PlayerStatInfo> statInfos = new();
        foreach (var item in achiv.StatsThresholds)
        {
            PlayerStatInfo statThresholds = new()
            {
                ApiVersion = 2,
                Name = Helpers.FromString(item.Name),
                CurrentValue = item.Current,
                ThresholdValue = item.Threshold,
            };
            statInfos.Add(statThresholds);
        }


        PlayerAchievementV2 res = new()
        {
            AchievementId = Helpers.FromString(achiv.AchievementId),
            StatInfoCount = statInfos.Count,
            StatInfo = Helpers.FromStructArray(statInfos.ToArray()),
            UnlockTime = achiv.UnlockedTime,
            Description = Helpers.FromString(achiv.UnlockedDescription),
            DisplayName = Helpers.FromString(achiv.UnlockedDisplayName),
            FlavorText = Helpers.FromString(achiv.FlavorText),
            IconURL = Helpers.FromString(achiv.UnlockedIconUrl),
        };
        DisposeOtherAccountAch(AccountId);
        return res;
    }

    #endregion


    public void CreateAchForUser(string AccountId)
    {
        AchKVs.Add(AccountId, []);
        _AchReqs.Add(AccountId);
    }

    public void AddUserToAchRequest(string AccountId)
    {
        _AchReqs.Add(AccountId);
    }

    public void SetAchForUser(string AccountId, List<Achievement_Model> ach)
    {
        _AchReqs.Remove(AccountId);
        AchKVs.TryAdd(AccountId, ach);
    }

    public bool IsAccountStillWaiting(string AccountId)
    {
        return _AchReqs.Contains(AccountId);
    }

    public void DisposeOtherAccountAch(string AccountId)
    {
        if (AccountId == EOS_Main.GetConfig().AccountId)
            return;
        _SentReq.Remove(AccountId);
        _AchReqs.Remove(AccountId);
        AchiSync();
        AchKVs.Remove(AccountId);
    }

    public List<Achievement_Model> GetAchievement_FromAccount(string AccountId)
    {
        if (AchKVs.TryGetValue(AccountId, out var achievement_Models))
        {
            return achievement_Models;
        }
        CreateAchForUser(AccountId);
        return [];
    }


    private void AchiSync()
    {
        var accid = EOS_Main.GetConfig().AccountId;
        var achs = AchKVs.Where(x=>x.Key != accid).ToDictionary();
        foreach (var ach in achs)
        {
            var modelstring = JsonSerializer.Serialize(ach.Value, SourceGenerationContext.Default.ListAchievement_Model);
            PlayerPacket<AchResponsePacket> achpacket = new()
            {
                PacketData = new()
                {
                    JsonAchModel = modelstring,
                    AccountId = ach.Key,
                },
                SenderAccountId = accid,
                ToAccountId = ach.Key
            };
            EOS_Main.GetPlatform().Network.SendNetPacketToUser(achpacket, ach.Key);
        }
    }

    private void SaveAchis()
    {
        File.WriteAllText("eos_emu/achievements.json", JsonSerializer.Serialize(Achievements, SourceGenerationContext.Default.ListAchievement_Model));
        File.WriteAllText("eos_emu/user_achievements.json", JsonSerializer.Serialize(AchKVs[EOS_Main.GetConfig().AccountId], SourceGenerationContext.Default.ListAchievement_Model));
    }

    #region From IHandle
    public IntPtr Create()
    {
        if (File.Exists("eos_emu/achievements.json"))
        {

            try
            {
                var ach = JsonSerializer.Deserialize(File.ReadAllText("eos_emu/achievements.json"), SourceGenerationContext.Default.ListAchievement_Model);
                if (ach != null)
                {
                    Achievements = new();
                }
            }
            catch
            {
                _log.Logger.WriteDebug("achievements.json couldnt be parsed!", Logging.LogCategory.Achievements);
            }

            if (File.Exists("eos_emu/user_achievements.json"))
            {
                try
                {
                    var ach = JsonSerializer.Deserialize(File.ReadAllText("eos_emu/user_achievements.json"), SourceGenerationContext.Default.ListAchievement_Model);
                    if (ach != null)
                    {
                        AchKVs = new()
                {
                    { EOS_Main.GetConfig().AccountId, Achievements }
                };
                    }
                }
                catch
                {
                    _log.Logger.WriteDebug("user_achievements.json couldnt be parsed!", Logging.LogCategory.Achievements);
                }
            }
        }
        else
        {
            Achievements = [];
            AchKVs = new()
            {
                { EOS_Main.GetConfig().AccountId, [] }
            };
        }
        _log.Logger.WriteDebug("Achievements_Handler.Create", Logging.LogCategory.Achievements);
        return Helpers.StructToPtr(new DummyStruct(nameof(Achievements_Handler)));
    }

    public void Tick()
    {
        if (EOS_Main.GetPlatform().Network.IsNull())
            return;
        foreach (string userId in _AchReqs)
        {
            if (_SentReq.Contains(userId))
                continue;

            PlayerPacket<ReqPacket> playerPacket = new()
            {
                PacketData = new()
                {
                    Request = ReqEnum.Ach
                },
                SenderAccountId = EOS_Main.GetConfig().AccountId,
                ToAccountId = userId
            };
            EOS_Main.GetPlatform().Network.SendNetPacketToUser(playerPacket, userId);
            _SentReq.Add(userId);
        }
    }

    public void Dispose()
    {
        _SentReq.Clear();
        SaveAchis();
        AchiSync();
        GC.SuppressFinalize(this);
    }
    #endregion
}
