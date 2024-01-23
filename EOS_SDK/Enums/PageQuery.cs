using System.Runtime.InteropServices;

namespace EOS_SDK
{

	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct PageQuery
	{
        public int m_ApiVersion;
        public int m_StartIndex;
        public int m_MaxCount;
	}
}