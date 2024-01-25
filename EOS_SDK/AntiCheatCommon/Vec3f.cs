using System.Runtime.InteropServices;

namespace EOS_SDK.AntiCheatCommon
{
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct Vec3f
    {
        public float x;
        public float y;
        public float z;
    }
}