using System.Runtime.InteropServices;

namespace EOS_SDK.AntiCheatCommon
{

    [StructLayout(LayoutKind.Explicit, Pack = 8)]
    public struct LogEventParamPairParamValuepublic
    {
        [FieldOffset(0)]
        public AntiCheatCommonEventParamType m_ParamValueType;
        [FieldOffset(8)]
        public IntPtr m_ClientHandle;
        [FieldOffset(8)]
        public IntPtr m_String;
        [FieldOffset(8)]
        public uint m_UInt32;
        [FieldOffset(8)]
        public int m_Int32;
        [FieldOffset(8)]
        public ulong m_UInt64;
        [FieldOffset(8)]
        public long m_Int64;
        [FieldOffset(8)]
        public Vec3fpublic m_Vec3f;
        [FieldOffset(8)]
        public Quatpublic m_Quat;
    }
}