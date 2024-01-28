namespace EOS_SDK.Auth
{

    [Flags]
    public enum AuthScopeFlags : int
    {
        NoFlags = 0x0,
        BasicProfile = 0x1,
        FriendsList = 0x2,
        Presence = 0x4,
        FriendsManagement = 0x8,
        Email = 0x10,
        Country = 0x20
    }
}