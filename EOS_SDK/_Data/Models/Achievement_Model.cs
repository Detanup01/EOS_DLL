using Newtonsoft.Json;

namespace EOS_SDK._Data.Models
{
    public class Achievement_Model
    {
        public string AchievementId { get; set; }
        public Langs UnlockedDisplayName { get; set; }
        public Langs UnlockedDescription { get; set; }
        public Langs LockedDisplayName { get; set; }
        public Langs LockedDescription { get; set; }
        public Langs FlavorText { get; set; }
        public string UnlockedIconUrl { get; set; }
        public string LockedIconUrl { get; set; }
        public bool IsHidden { get; set; }
        public List<StatThresholds> StatsThresholds { get; set; }
        public Data _Data { get; set; }

        public class StatThresholds
        {
            public string Name { get; set; }

            public int Threshold { get; set; }
        }

        public class Langs
        {
            [JsonProperty("default")]
            public string Default;
        }

        public class Data
        {
            public long UnlockedTime = -1;
            public bool IsUnlocked = false;

        }
    }
}
