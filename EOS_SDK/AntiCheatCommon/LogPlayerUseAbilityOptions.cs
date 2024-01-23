using System.Runtime.InteropServices;
namespace EOS_SDK.AntiCheatCommon
{

	[StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	public struct LogPlayerUseAbilityOptionspubli
	{
		public int m_ApiVersion;
		public IntPtr m_PlayerHandle;
		public uint m_AbilityId;
		public uint m_AbilityDurationMs;
		public uint m_AbilityCooldownMs;
	}
}