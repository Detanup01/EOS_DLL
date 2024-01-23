using System.Runtime.InteropServices;

namespace EOS_SDK.AntiCheatCommon
{
	[StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
    public struct LogGameRoundStartOptionspublic
	{
		public int m_ApiVersion;
		public IntPtr m_SessionIdentifier;
		public IntPtr m_LevelName;
		public IntPtr m_ModeName;
		public uint m_RoundTimeSeconds;
	}
}