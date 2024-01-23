using System.Runtime.InteropServices;

namespace EOS_SDK.AntiCheatCommon
{
	[StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	public struct LogPlayerUseWeaponDatapublic
	{
		public IntPtr m_PlayerHandle;
		public IntPtr m_PlayerPosition;
		public IntPtr m_PlayerViewRotation;
		public int m_IsPlayerViewZoomed;
		public int m_IsMeleeAttack;
		public IntPtr m_WeaponName;
	}
}