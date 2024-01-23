using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOS_SDK.RTCAdmin
{
    public unsafe class RTCAdmin_Exports
    {
#if false

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_RTCAdmin_CopyUserTokenByIndex(IntPtr handle, IntPtr options, IntPtr outUserToken)
		{
			var _CopyUserTokenByIndexOptions = Marshal.PtrToStructure<CopyUserTokenByIndexOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_RTCAdmin_CopyUserTokenByUserId(IntPtr handle, IntPtr options, IntPtr outUserToken)
		{
			var _CopyUserTokenByUserIdOptions = Marshal.PtrToStructure<CopyUserTokenByUserIdOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_RTCAdmin_Kick(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _KickOptions = Marshal.PtrToStructure<KickOptions>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: RTCAdmin.OnKickCompleteCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_RTCAdmin_QueryJoinRoomToken(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _QueryJoinRoomTokenOptions = Marshal.PtrToStructure<QueryJoinRoomTokenOptions>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: RTCAdmin.OnQueryJoinRoomTokenCompleteCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_RTCAdmin_SetParticipantHardMute(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _SetParticipantHardMuteOptions = Marshal.PtrToStructure<SetParticipantHardMuteOptions>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: RTCAdmin.OnSetParticipantHardMuteCompleteCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_RTCAdmin_UserToken_Release(IntPtr userToken)
        {
        }
#endif
    }
}
