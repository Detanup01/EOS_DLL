using System.Runtime.InteropServices;

namespace EOS_SDK.AntiCheatCommon
{
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct LogEventOptions
    {
        public int m_ApiVersion { get => 1; }
        public IntPtr m_ClientHandle;
        public uint m_EventId;
        public uint m_ParamsCount;
        public IntPtr m_Params; //LogEventParamPair[]
    }
}