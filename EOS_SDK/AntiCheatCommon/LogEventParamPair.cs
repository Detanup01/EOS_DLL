using System.Runtime.InteropServices;

namespace EOS_SDK.AntiCheatCommon
{

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct LogEventParamPair
    {
        public LogEventParamPairParamValue m_ParamValue;
    }
}