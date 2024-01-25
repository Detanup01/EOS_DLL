using System.Runtime.InteropServices;

namespace EOS_SDK.AntiCheatCommon
{

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct RegisterEventParamDef
    {
        public IntPtr ParamName;
        public AntiCheatCommonEventParamType ParamType;
    }
}