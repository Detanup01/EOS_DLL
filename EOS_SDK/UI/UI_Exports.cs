using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOS_SDK.UI
{
    public unsafe class UI_Exports
    {
#if false

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_UI_AcknowledgeEventId(IntPtr handle, IntPtr options)
		{
			var _AcknowledgeEventIdOptions = Marshal.PtrToStructure<AcknowledgeEventIdOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_UI_AddNotifyDisplaySettingsUpdated(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationFn)
		{
			var _AddNotifyDisplaySettingsUpdatedOptions = Marshal.PtrToStructure<AddNotifyDisplaySettingsUpdatedOptions>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)notificationFn; //Delegate Class was: UI.OnDisplaySettingsUpdatedCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_UI_AddNotifyMemoryMonitor(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationFn)
		{
			var _AddNotifyMemoryMonitorOptions = Marshal.PtrToStructure<AddNotifyMemoryMonitorOptions>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)notificationFn; //Delegate Class was: UI.OnMemoryMonitorCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_UI_GetFriendsExclusiveInput(IntPtr handle, IntPtr options)
		{
			var _GetFriendsExclusiveInputOptions = Marshal.PtrToStructure<GetFriendsExclusiveInputOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_UI_GetFriendsVisible(IntPtr handle, IntPtr options)
		{
			var _GetFriendsVisibleOptions = Marshal.PtrToStructure<GetFriendsVisibleOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static UI.NotificationLocation EOS_UI_GetNotificationLocationPreference(IntPtr handle)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static UI.InputStateButtonFlags EOS_UI_GetToggleFriendsButton(IntPtr handle, IntPtr options)
		{
			var _GetToggleFriendsButtonOptions = Marshal.PtrToStructure<GetToggleFriendsButtonOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static UI.KeyCombination EOS_UI_GetToggleFriendsKey(IntPtr handle, IntPtr options)
		{
			var _GetToggleFriendsKeyOptions = Marshal.PtrToStructure<GetToggleFriendsKeyOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_UI_HideFriends(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _HideFriendsOptions = Marshal.PtrToStructure<HideFriendsOptions>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: UI.OnHideFriendsCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_UI_IsSocialOverlayPaused(IntPtr handle, IntPtr options)
		{
			var _IsSocialOverlayPausedOptions = Marshal.PtrToStructure<IsSocialOverlayPausedOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_UI_IsValidButtonCombination(IntPtr handle, UI.InputStateButtonFlags buttonCombination)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_UI_IsValidKeyCombination(IntPtr handle, UI.KeyCombination keyCombination)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_UI_PauseSocialOverlay(IntPtr handle, IntPtr options)
		{
			var _PauseSocialOverlayOptions = Marshal.PtrToStructure<PauseSocialOverlayOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_UI_PrePresent(IntPtr handle, IntPtr options)
		{
			var _PrePresentOptions = Marshal.PtrToStructure<PrePresentOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_UI_RemoveNotifyDisplaySettingsUpdated(IntPtr handle, ulong id)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_UI_RemoveNotifyMemoryMonitor(IntPtr handle, ulong id)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_UI_ReportInputState(IntPtr handle, IntPtr options)
		{
			var _ReportInputStateOptions = Marshal.PtrToStructure<ReportInputStateOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_UI_SetDisplayPreference(IntPtr handle, IntPtr options)
		{
			var _SetDisplayPreferenceOptions = Marshal.PtrToStructure<SetDisplayPreferenceOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_UI_SetToggleFriendsButton(IntPtr handle, IntPtr options)
		{
			var _SetToggleFriendsButtonOptions = Marshal.PtrToStructure<SetToggleFriendsButtonOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_UI_SetToggleFriendsKey(IntPtr handle, IntPtr options)
		{
			var _SetToggleFriendsKeyOptions = Marshal.PtrToStructure<SetToggleFriendsKeyOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_UI_ShowBlockPlayer(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _ShowBlockPlayerOptions = Marshal.PtrToStructure<ShowBlockPlayerOptions>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: UI.OnShowBlockPlayerCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_UI_ShowFriends(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _ShowFriendsOptions = Marshal.PtrToStructure<ShowFriendsOptions>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: UI.OnShowFriendsCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_UI_ShowNativeProfile(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _ShowNativeProfileOptions = Marshal.PtrToStructure<ShowNativeProfileOptions>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: UI.OnShowNativeProfileCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_UI_ShowReportPlayer(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _ShowReportPlayerOptions = Marshal.PtrToStructure<ShowReportPlayerOptions>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: UI.OnShowReportPlayerCallback
        }
#endif
    }
}
