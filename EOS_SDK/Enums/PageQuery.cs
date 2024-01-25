using System.Runtime.InteropServices;

namespace EOS_SDK
{

	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct PageQuery
	{
        public int ApiVersion;
        public int StartIndex;
        public int MaxCount;
	}
}