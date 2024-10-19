namespace EOS_SDK._Data.Models;

public class Achievement_Model
{
    public string AchievementId { get; set; } = string.Empty;
    public string UnlockedDisplayName { get; set; } = string.Empty;
    public string UnlockedDescription { get; set; } = string.Empty;
    public string LockedDisplayName { get; set; } = string.Empty;
    public string LockedDescription { get; set; } = string.Empty;
    public string FlavorText { get; set; } = string.Empty;
    public string UnlockedIconUrl { get; set; } = string.Empty;
    public string LockedIconUrl { get; set; } = string.Empty;
    public bool IsHidden { get; set; }
    public List<StatThresholds> StatsThresholds { get; set; } = new();
    public long UnlockedTime { get; set; } = -1;

    public class StatThresholds
    {
        public string Name { get; set; } = string.Empty;
        public int Current { get; set; }
        public int Threshold { get; set; }
    }
}
