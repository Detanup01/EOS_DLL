using System.Runtime.InteropServices;

namespace EOS_SDK
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct PageResult
	{
        public int StartIndex;
        public int Count;
        public int TotalCount;
	}
}