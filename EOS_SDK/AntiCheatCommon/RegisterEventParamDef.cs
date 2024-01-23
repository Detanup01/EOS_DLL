using System.Runtime.InteropServices;

namespace EOS_SDK.AntiCheatCommon
{

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct RegisterEventParamDefpublic
    {
        public IntPtr m_ParamName;
        public AntiCheatCommonEventParamType m_ParamType;
    }
}