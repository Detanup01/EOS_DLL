using System.Runtime.InteropServices;

namespace EOS_SDK.ActiveSession
{
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct ActiveSessionCopyInfoOptionspublic
    {
        public int m_ApiVersion;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct ActiveSessionGetRegisteredPlayerByIndexOptionspublic
    {
        public int m_ApiVersion;
        public uint m_PlayerIndex;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct ActiveSessionGetRegisteredPlayerCountOptionspublic
    {
        public int m_ApiVersion;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct ActiveSessionInfopublic
    {
        public int m_ApiVersion;
        public IntPtr m_SessionName; //string
        public IntPtr m_LocalUserId; //ProductUserId
        public OnlineSessionState m_State;
        public IntPtr m_SessionDetails; //SessionDetailsInfo
    }
}
