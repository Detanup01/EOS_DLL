using EOS_SDK._Data;
using EOS_SDK._Data.Models;
using EOS_SDK.Version;
using Newtonsoft.Json;

namespace EOS_SDK.Achievements
{
    public class Achievements_Handler : IHandler
    {
        public List<Achievement_Model> Achievements = new();
        public Dictionary<string, List<Achievement_Model>> AchiKVs = new(); //support for servers/multiple users.
        IntPtr MyDummyPtr;
        public IntPtr CreateHandler()
        {
            Achievements = JsonConvert.DeserializeObject<List<Achievement_Model>>("achievements.json")!;
            AchiKVs = new();
            _log.Logger.WriteDebug("", Logging.LogCategory.Achievements);
            return Create();
        }

        public UnlockAchievementsOptions UnlockAchievements(UnlockAchievementsOptions options)
        {
            var achis = Helpers.ToStructArray<string>(options.AchievementIds, (int)options.AchievementsCount);
            _log.Logger.WriteDebug("Achi IDs to Unlock:" + JsonConvert.SerializeObject(achis), Logging.LogCategory.Achievements);

            var achiv = Achievements.Where(x => achis.Contains(x.AchievementId)).ToList();
            List<string> UnlockedAchis = new();
            foreach (var item in achiv)
            {
                UnlockedAchis.Add(item.AchievementId);
                item._Data.IsUnlocked = true;
                item._Data.UnlockedTime = TimeHelper.ConvertTimeFrom(DateTimeOffset.UtcNow);
                OnAchievementsUnlockedCallbackV2Info info = new()
                { 
                    AchievementId = Helpers.FromString(item.AchievementId),
                    UnlockTime = item._Data.UnlockedTime,
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
            return unlockAchievementsOptions;
        }

        public bool IsAchiExist(IntPtr ptr)
        {
            string achi = Helpers.ToString(ptr);
            return Achievements.Where(x=>x.AchievementId == achi).Any();
        }

        public bool IsAchiExistIndex(uint index)
        {
            return Achievements.Count > index;
        }

        public Definition GetDefinition(IntPtr ptr)
        {
            string achi = Helpers.ToString(ptr);
            var indx = Achievements.FindIndex(0, x => x.AchievementId == achi);
            return GetDefinitionIndex((uint)indx);
        }

        public Definition GetDefinitionIndex(uint index)
        {
            if (Achievements.Count >= index)
                return new();

            var achiv = Achievements[(int)index];

            List<StatThresholds> thresholds = new();
            foreach (var item in achiv.StatsThresholds)
            {
                StatThresholds statThresholds = new StatThresholds()
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
                Description = Helpers.FromString(achiv.UnlockedDescription.Default),
                DisplayName = Helpers.FromString(achiv.UnlockedDisplayName.Default),
                CompletionDescription = Helpers.FromString(achiv.UnlockedDisplayName.Default),
                HiddenDescription = Helpers.FromString(achiv.UnlockedDescription.Default),
                LockedDescription = Helpers.FromString(achiv.LockedDescription.Default),
                LockedDisplayName = Helpers.FromString(achiv.LockedDisplayName.Default),
                IsHidden = Convert.ToInt32(achiv.IsHidden),
                LockedIconId = Helpers.FromString(achiv.LockedIconUrl),
                StatThresholds = Helpers.FromStructArray(thresholds.ToArray()),
                StatThresholdsCount = thresholds.Count,
                UnlockedIconId = Helpers.FromString(achiv.UnlockedIconUrl)
            };
        }

        public UnlockedAchievement GetUnlockedAchievement(IntPtr ptr)
        {
            string achi = Helpers.ToString(ptr);
            var indx = Achievements.FindIndex(0, x => x.AchievementId == achi);
            return GetUnlockedAchievementIndex((uint)indx);
        }

        public UnlockedAchievement GetUnlockedAchievementIndex(uint index)
        {
            if (Achievements.Count >= index)
                return new();

            var achiv = Achievements[(int)index];

            return new()
            {
                ApiVersion = Versions.UnlockedachievementApiLatest,
                AchievementId = Helpers.FromString(achiv.AchievementId),
                UnlockTime = achiv._Data.UnlockedTime,
            };

        }

        public void SaveAchis()
        {
            File.WriteAllText("achievements.json", JsonConvert.SerializeObject(Achievements));
            
        }

        public bool CheckIfPointerValid(IntPtr ptr)
        {
            if (ptr == IntPtr.Zero)
                return false;
            return ptr == MyDummyPtr;
        }

        public IntPtr Create()
        {
            DummyStruct dummyStruct = new();
            var retptr = Helpers.StructToPtr(dummyStruct);
            _log.Logger.WriteInfo("Achievements_Handler.Create Pointer: " + retptr);
            MyDummyPtr = retptr;
            return retptr;
        }

        public void Tick()
        {
            
        }

        public void Close()
        {
            SaveAchis();
        }
    }
}
