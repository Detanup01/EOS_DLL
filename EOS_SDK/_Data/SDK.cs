namespace EOS_SDK._Data;

public class SDK
{
    public const string Version = "1.16.3";
    public const string EmuVersion = "0.0.0.1";

    public static readonly List<uint> PTRs = 
    [
        AchievementPTR, AntiCheatClientPTR, AntiCheatServerPTR, AuthPTR, ConnectPTR, PlatformPTR
    ];

    // Fake pointers calculated with https://emn178.github.io/online-tools/crc/

    public const uint AchievementPTR = 0xD0867B3C;
    public const uint AntiCheatClientPTR = 0x5B22C26B;
    public const uint AntiCheatServerPTR = 0x5A8D4DFD;
    public const uint AuthPTR = 0xE131221A;
    public const uint ConnectPTR = 0x5ECD3D16;
    public const uint CustomInvitesPTR = 0xFEE91C6D;
    public const uint EcomPTR = 0xE01FB12E;
    public const uint FriendsPTR = 0xA8991AFD;
    public const uint IntegratedPlatformPTR = 0x2C6A7095;
    public const uint KWSPTR = 0xB0D86EA3;
    public const uint LeaderboardsPTR = 0x49EEA320;
    public const uint LobbyPTR = 0xE119D795;
    public const uint LoggingPTR = 0xE8EFC4D8;
    public const uint MetricsPTR = 0x723AA4A0;
    public const uint ModsPTR = 0x63242E8F;
    public const uint P2PPTR = 0x9AAECB28;
    public const uint PlatformPTR = 0xD7745CA2;
    public const uint PlayerDataStoragePTR = 0xD28DB738;
    public const uint PresencePTR = 0xDBBAEA09;
    public const uint ProgressionSnapshotPTR = 0x63242E8F;
    public const uint ReportsPTR = 0x9D0D34FB;
    public const uint RTCPTR = 0x83B810BF;
    public const uint RTCAdminPTR = 0x4AC469CC;
    public const uint RTCAudioPTR = 0x14DEC81B;
    public const uint RTCDataPTR = 0x4AC469CC;
    public const uint SanctionsPTR = 0xACBAE57C;
    public const uint SessionPTR = 0x806C7515;
    public const uint StatsPTR = 0x27D2CCCE;
    public const uint TitleStoragePTR = 0xD937D512;
    public const uint UIPTR = 0xE7C32629;
    public const uint UserInfoPTR = 0x26C51117;

}
