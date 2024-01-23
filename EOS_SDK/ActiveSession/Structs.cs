using System.Runtime.InteropServices;

namespace EOS_SDK.ActiveSession
{
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct ActiveSessionCopyInfoOptions
    {
        public int m_ApiVersion;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct ActiveSessionGetRegisteredPlayerByIndexOptions
    {
        public int m_ApiVersion;
        public uint m_PlayerIndex;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct ActiveSessionGetRegisteredPlayerCountOptions
    {
        public int m_ApiVersion;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct ActiveSessionInfo
    {
        public int m_ApiVersion;
        public IntPtr m_SessionName; //string
        public IntPtr m_LocalUserId; //ProductUserId
        public OnlineSessionState m_State;
        public IntPtr m_SessionDetails; //SessionDetailsInfo
    }
}
