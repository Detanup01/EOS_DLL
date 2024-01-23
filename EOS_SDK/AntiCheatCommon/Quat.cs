using System.Runtime.InteropServices;

namespace EOS_SDK.AntiCheatCommon
{
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct Quatpublic
    {
        public float m_w;
        public float m_x;
        public float m_y;
        public float m_z;
    }
}