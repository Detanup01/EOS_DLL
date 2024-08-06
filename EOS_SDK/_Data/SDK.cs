namespace EOS_SDK._Data
{
    public class SDK
    {
        public const string Version = "1.16.3";
        public const string EmuVersion = "0.0.0.1";

        public static readonly List<uint> PTRs = 
        [
            AchievementPTR, ActiveSessionPTR, AntiCheatClientPTR, AntiCheatServerPTR, AuthPTR, ConnectPTR, PlatformPTR
        ];

        public const uint AchievementPTR = 0xABFD3700;
        public const uint ActiveSessionPTR = 0xCC59EC41;
        public const uint AntiCheatClientPTR = 0x5B22C26B;
        public const uint AntiCheatServerPTR = 0x0D8CDC79;
        public const uint AuthPTR = 0xE131221A;
        public const uint ConnectPTR = 0x5ECD3D16;

        public const uint PlatformPTR = 0xD7745CA2;

    }
}
