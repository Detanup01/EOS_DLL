using System.Runtime.InteropServices;

namespace EOS_SDK.AntiCheatCommon
{

    [StructLayout(LayoutKind.Explicit, Pack = 8)]
    public struct LogEventParamPairParamValue
    {
        [FieldOffset(0)]
        public AntiCheatCommonEventParamType ParamValueType;
        [FieldOffset(8)]
        public IntPtr ClientHandle;
        [FieldOffset(8)]
        public IntPtr String;
        [FieldOffset(8)]
        public uint UInt32;
        [FieldOffset(8)]
        public int Int32;
        [FieldOffset(8)]
        public ulong UInt64;
        [FieldOffset(8)]
        public long Int64;
        [FieldOffset(8)]
        public Vec3f Vec3f;
        [FieldOffset(8)]
        public Quat Quat;
    }
}