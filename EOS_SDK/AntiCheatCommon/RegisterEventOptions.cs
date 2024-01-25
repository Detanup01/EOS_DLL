using System.Runtime.InteropServices;

namespace EOS_SDK.AntiCheatCommon
{

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct RegisterEventOptions
    {
        public int ApiVersion;
        public uint EventId;
        public IntPtr EventName;
        public AntiCheatCommonEventType EventType;
        public uint ParamDefsCount;
        public IntPtr ParamDefs;
    }
}