//using EOS_SDK;
using System.Runtime.InteropServices;

namespace test
{
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    internal struct TestV2
    {
        public int Version { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }
}