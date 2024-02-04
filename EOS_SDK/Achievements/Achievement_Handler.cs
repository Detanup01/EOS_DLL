using EOS_SDK._Data;
using EOS_SDK._Data.Models;
using Newtonsoft.Json;

namespace EOS_SDK.Achievements
{
    internal class Achievement_Handler
    {
        public struct Handler
        {
            public List<Achievement_Model> Achievements;
            public Dictionary<string, List<Achievement_Model>> AchiKVs; //support for servers/multiple users.
        }

        static Handler Instance;

        public static IntPtr Create()
        {
            Instance = new()
            {
                Achievements = JsonConvert.DeserializeObject<List<Achievement_Model>>("achievements.json")
            };
            _log.Logger.WriteDebug("", Logging.LogCategory.Achievements);
            return IntPtr.CreateChecked(SDK.AchivementPTR);
        }

        public static UnlockAchievementsOptions UnlockAchievements(UnlockAchievementsOptions options)
        {
            var achis = Helpers.ToStructArray<string>(options.AchievementIds, (int)options.AchievementsCount);
            _log.Logger.WriteDebug("Achi IDs to Unlock:" + JsonConvert.SerializeObject(achis), Logging.LogCategory.Achievements);

            var achiv = Instance.Achievements.Where(x => achis.Contains(x.AchievementId)).ToList();
            List<string> UnlockedAchis = new();
            foreach (var item in achiv)
            {
                UnlockedAchis.Add(item.AchievementId);
                item._Data.IsUnlocked = true;
                item._Data.UnlockedTime = TimeHelper.ConvertTimeFrom(DateTimeOffset.UtcNow);
            }
            var ptr = Helpers.FromStructArray(UnlockedAchis.ToArray());
            UnlockAchievementsOptions unlockAchievementsOptions = new()
            { 
                ApiVersion = options.ApiVersion,
                UserId = options.UserId,
                AchievementIds = ptr,
                AchievementsCount = (uint)UnlockedAchis.Count
            };
            return unlockAchievementsOptions;
        }
    }
}
