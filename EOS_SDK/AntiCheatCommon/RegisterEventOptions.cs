using System.Runtime.InteropServices;

namespace EOS_SDK.AntiCheatCommon
{

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct RegisterEventOptions
    {
        public int m_ApiVersion;
        public uint m_EventId;
        public IntPtr m_EventName;
        public AntiCheatCommonEventType m_EventType;
        public uint m_ParamDefsCount;
        public IntPtr m_ParamDefs;
    }
}