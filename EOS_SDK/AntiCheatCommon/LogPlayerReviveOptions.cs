using System.Runtime.InteropServices;

namespace EOS_SDK.AntiCheatCommon
{
	[StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	public struct LogPlayerReviveOptionspublic
	{
		public int m_ApiVersion;
		public IntPtr m_RevivedPlayerHandle;
		public IntPtr m_ReviverPlayerHandle;
	}
}