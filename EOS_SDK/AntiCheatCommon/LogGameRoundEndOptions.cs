using System.Runtime.InteropServices;

namespace EOS_SDK.AntiCheatCommon
{
	[StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
    public struct LogGameRoundEndOptionspublic
	{
		public int m_ApiVersion;
		public uint m_WinningTeamId;
	}
}