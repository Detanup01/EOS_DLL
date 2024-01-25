using System.Runtime.InteropServices;

namespace EOS_SDK.ActiveSession
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
        public IntPtr SessionName; //string
        public IntPtr LocalUserId; //ProductUserId
        public OnlineSessionState State;
        public IntPtr SessionDetails; //SessionDetailsInfo
    }
}
