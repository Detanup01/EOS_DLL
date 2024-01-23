using System.Runtime.InteropServices;

namespace EOS_SDK.AntiCheatCommon
{
	[StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	public struct OnClientAuthStatusChangedCallbackInfopublic
	{
		public IntPtr m_ClientData;
		public IntPtr m_ClientHandle;
		public AntiCheatCommonClientAuthStatus m_ClientAuthStatus;
	}
}