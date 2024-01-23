using System.Runtime.InteropServices;

namespace EOS_SDK
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct PageResult
	{
        public int m_StartIndex;
        public int m_Count;
        public int m_TotalCount;
	}
}