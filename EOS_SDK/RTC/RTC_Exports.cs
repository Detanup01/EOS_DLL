using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOS_SDK.RTC
{
    public unsafe class RTC_Exports
    {
#if false

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static ulong EOS_RTC_AddNotifyDisconnected(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _AddNotifyDisconnectedOptions = Marshal.PtrToStructure<AddNotifyDisconnectedOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: RTC.OnDisconnectedCallback
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static ulong EOS_RTC_AddNotifyParticipantStatusChanged(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _AddNotifyParticipantStatusChangedOptions = Marshal.PtrToStructure<AddNotifyParticipantStatusChangedOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: RTC.OnParticipantStatusChangedCallback
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static ulong EOS_RTC_AddNotifyRoomStatisticsUpdated(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr statisticsUpdateHandler)
		{
			var _AddNotifyRoomStatisticsUpdatedOptions = Marshal.PtrToStructure<AddNotifyRoomStatisticsUpdatedOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)statisticsUpdateHandler; //Delegate Class was: RTC.OnRoomStatisticsUpdatedCallback
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static void EOS_RTC_BlockParticipant(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _BlockParticipantOptions = Marshal.PtrToStructure<BlockParticipantOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: RTC.OnBlockParticipantCallback
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static IntPtr EOS_RTC_GetAudioInterface(IntPtr handle)
        {
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static void EOS_RTC_JoinRoom(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _JoinRoomOptions = Marshal.PtrToStructure<JoinRoomOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: RTC.OnJoinRoomCallback
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static void EOS_RTC_LeaveRoom(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _LeaveRoomOptions = Marshal.PtrToStructure<LeaveRoomOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: RTC.OnLeaveRoomCallback
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static void EOS_RTC_RemoveNotifyDisconnected(IntPtr handle, ulong notificationId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static void EOS_RTC_RemoveNotifyParticipantStatusChanged(IntPtr handle, ulong notificationId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static void EOS_RTC_RemoveNotifyRoomStatisticsUpdated(IntPtr handle, ulong notificationId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static Result EOS_RTC_SetRoomSetting(IntPtr handle, IntPtr options)
		{
			var _SetRoomSettingOptions = Marshal.PtrToStructure<SetRoomSettingOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static Result EOS_RTC_SetSetting(IntPtr handle, IntPtr options)
		{
			var _SetSettingOptions = Marshal.PtrToStructure<SetSettingOptions>(options);
        }
#endif
    }
}
