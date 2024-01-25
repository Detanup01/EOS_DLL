using System.Runtime.InteropServices;

namespace EOS_SDK.AntiCheatCommon
{
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct LogEventOptions
    {
        public int ApiVersion { get => 1; }
        public IntPtr ClientHandle;
        public uint EventId;
        public uint ParamsCount;
        public IntPtr Params; //LogEventParamPair[]
    }
}