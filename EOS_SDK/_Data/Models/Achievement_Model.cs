using Newtonsoft.Json;

namespace EOS_SDK._Data.Models
{
    public class Achievement_Model
    {
        public string AchievementId { get; set; } = string.Empty;
        public Langs UnlockedDisplayName { get; set; } = new();
        public Langs UnlockedDescription { get; set; } = new();
        public Langs LockedDisplayName { get; set; } = new();
        public Langs LockedDescription { get; set; } = new();
        public Langs FlavorText { get; set; } = new();
        public string UnlockedIconUrl { get; set; } = string.Empty;
        public string LockedIconUrl { get; set; } = string.Empty;
        public bool IsHidden { get; set; }
        public List<StatThresholds> StatsThresholds { get; set; } = new();

        [JsonIgnore]
        public Data _Data { get; set; } = new();

        public class StatThresholds
        {
            public string Name { get; set; } = string.Empty;

            public int Threshold { get; set; }
        }

        public class Langs
        {
            [JsonProperty("default")]
            public string Default { get; set; } = string.Empty;
        }

        public class Data
        {
            public long UnlockedTime { get; set; } = -1;
            public bool IsUnlocked { get; set; } = false;

        }
    }
}
