using System.Runtime.InteropServices;

namespace test
{
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    internal struct TESTInternalInput
    {
        public int Result;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    internal struct TESTInternal
    {
        public int Result;
        [MarshalAs(UnmanagedType.LPStr)]
        public string Str;
        public IntPtr Str2;
    }
}