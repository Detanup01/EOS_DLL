using System.Runtime.InteropServices;

namespace EOS_SDK.Sessions
{
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct ActiveSessionCopyInfoOptions
    {
        public int ApiVersion;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct ActiveSessionGetRegisteredPlayerByIndexOptions
    {
        public int ApiVersion;
        public uint PlayerIndex;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct ActiveSessionGetRegisteredPlayerCountOptions
    {
        public int ApiVersion;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct ActiveSessionInfo
    {
        public int ApiVersion;
        public nint SessionName; //string
        public nint LocalUserId; //ProductUserId
        public OnlineSessionState State;
        public nint SessionDetails; //SessionDetailsInfo
    }
}
