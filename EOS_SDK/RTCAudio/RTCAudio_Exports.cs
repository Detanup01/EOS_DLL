using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOS_SDK.RTCAudio
{
    public unsafe class RTCAudio_Exports
    {
#if false

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static ulong EOS_RTCAudio_AddNotifyAudioBeforeRender(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _AddNotifyAudioBeforeRenderOptions = Marshal.PtrToStructure<AddNotifyAudioBeforeRenderOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: RTCAudio.OnAudioBeforeRenderCallback
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static ulong EOS_RTCAudio_AddNotifyAudioBeforeSend(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _AddNotifyAudioBeforeSendOptions = Marshal.PtrToStructure<AddNotifyAudioBeforeSendOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: RTCAudio.OnAudioBeforeSendCallback
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static ulong EOS_RTCAudio_AddNotifyAudioDevicesChanged(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _AddNotifyAudioDevicesChangedOptions = Marshal.PtrToStructure<AddNotifyAudioDevicesChangedOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: RTCAudio.OnAudioDevicesChangedCallback
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static ulong EOS_RTCAudio_AddNotifyAudioInputState(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _AddNotifyAudioInputStateOptions = Marshal.PtrToStructure<AddNotifyAudioInputStateOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: RTCAudio.OnAudioInputStateCallback
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static ulong EOS_RTCAudio_AddNotifyAudioOutputState(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _AddNotifyAudioOutputStateOptions = Marshal.PtrToStructure<AddNotifyAudioOutputStateOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: RTCAudio.OnAudioOutputStateCallback
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static ulong EOS_RTCAudio_AddNotifyParticipantUpdated(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _AddNotifyParticipantUpdatedOptions = Marshal.PtrToStructure<AddNotifyParticipantUpdatedOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: RTCAudio.OnParticipantUpdatedCallback
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static Result EOS_RTCAudio_CopyInputDeviceInformationByIndex(IntPtr handle, IntPtr options, IntPtr outInputDeviceInformation)
		{
			var _CopyInputDeviceInformationByIndexOptions = Marshal.PtrToStructure<CopyInputDeviceInformationByIndexOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static Result EOS_RTCAudio_CopyOutputDeviceInformationByIndex(IntPtr handle, IntPtr options, IntPtr outOutputDeviceInformation)
		{
			var _CopyOutputDeviceInformationByIndexOptions = Marshal.PtrToStructure<CopyOutputDeviceInformationByIndexOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static IntPtr EOS_RTCAudio_GetAudioInputDeviceByIndex(IntPtr handle, IntPtr options)
		{
			var _GetAudioInputDeviceByIndexOptions = Marshal.PtrToStructure<GetAudioInputDeviceByIndexOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static uint EOS_RTCAudio_GetAudioInputDevicesCount(IntPtr handle, IntPtr options)
		{
			var _GetAudioInputDevicesCountOptions = Marshal.PtrToStructure<GetAudioInputDevicesCountOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static IntPtr EOS_RTCAudio_GetAudioOutputDeviceByIndex(IntPtr handle, IntPtr options)
		{
			var _GetAudioOutputDeviceByIndexOptions = Marshal.PtrToStructure<GetAudioOutputDeviceByIndexOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static uint EOS_RTCAudio_GetAudioOutputDevicesCount(IntPtr handle, IntPtr options)
		{
			var _GetAudioOutputDevicesCountOptions = Marshal.PtrToStructure<GetAudioOutputDevicesCountOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static uint EOS_RTCAudio_GetInputDevicesCount(IntPtr handle, IntPtr options)
		{
			var _GetInputDevicesCountOptions = Marshal.PtrToStructure<GetInputDevicesCountOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static uint EOS_RTCAudio_GetOutputDevicesCount(IntPtr handle, IntPtr options)
		{
			var _GetOutputDevicesCountOptions = Marshal.PtrToStructure<GetOutputDevicesCountOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static void EOS_RTCAudio_InputDeviceInformation_Release(IntPtr deviceInformation)
        {
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static void EOS_RTCAudio_OutputDeviceInformation_Release(IntPtr deviceInformation)
        {
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static void EOS_RTCAudio_QueryInputDevicesInformation(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _QueryInputDevicesInformationOptions = Marshal.PtrToStructure<QueryInputDevicesInformationOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: RTCAudio.OnQueryInputDevicesInformationCallback
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static void EOS_RTCAudio_QueryOutputDevicesInformation(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _QueryOutputDevicesInformationOptions = Marshal.PtrToStructure<QueryOutputDevicesInformationOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: RTCAudio.OnQueryOutputDevicesInformationCallback
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static Result EOS_RTCAudio_RegisterPlatformAudioUser(IntPtr handle, IntPtr options)
		{
			var _RegisterPlatformAudioUserOptions = Marshal.PtrToStructure<RegisterPlatformAudioUserOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static void EOS_RTCAudio_RegisterPlatformUser(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _RegisterPlatformUserOptions = Marshal.PtrToStructure<RegisterPlatformUserOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: RTCAudio.OnRegisterPlatformUserCallback
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static void EOS_RTCAudio_RemoveNotifyAudioBeforeRender(IntPtr handle, ulong notificationId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static void EOS_RTCAudio_RemoveNotifyAudioBeforeSend(IntPtr handle, ulong notificationId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static void EOS_RTCAudio_RemoveNotifyAudioDevicesChanged(IntPtr handle, ulong notificationId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static void EOS_RTCAudio_RemoveNotifyAudioInputState(IntPtr handle, ulong notificationId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static void EOS_RTCAudio_RemoveNotifyAudioOutputState(IntPtr handle, ulong notificationId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static void EOS_RTCAudio_RemoveNotifyParticipantUpdated(IntPtr handle, ulong notificationId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static Result EOS_RTCAudio_SendAudio(IntPtr handle, IntPtr options)
		{
			var _SendAudioOptions = Marshal.PtrToStructure<SendAudioOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static Result EOS_RTCAudio_SetAudioInputSettings(IntPtr handle, IntPtr options)
		{
			var _SetAudioInputSettingsOptions = Marshal.PtrToStructure<SetAudioInputSettingsOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static Result EOS_RTCAudio_SetAudioOutputSettings(IntPtr handle, IntPtr options)
		{
			var _SetAudioOutputSettingsOptions = Marshal.PtrToStructure<SetAudioOutputSettingsOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static void EOS_RTCAudio_SetInputDeviceSettings(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _SetInputDeviceSettingsOptions = Marshal.PtrToStructure<SetInputDeviceSettingsOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: RTCAudio.OnSetInputDeviceSettingsCallback
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static void EOS_RTCAudio_SetOutputDeviceSettings(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _SetOutputDeviceSettingsOptions = Marshal.PtrToStructure<SetOutputDeviceSettingsOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: RTCAudio.OnSetOutputDeviceSettingsCallback
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static Result EOS_RTCAudio_UnregisterPlatformAudioUser(IntPtr handle, IntPtr options)
		{
			var _UnregisterPlatformAudioUserOptions = Marshal.PtrToStructure<UnregisterPlatformAudioUserOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static void EOS_RTCAudio_UnregisterPlatformUser(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _UnregisterPlatformUserOptions = Marshal.PtrToStructure<UnregisterPlatformUserOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: RTCAudio.OnUnregisterPlatformUserCallback
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static void EOS_RTCAudio_UpdateParticipantVolume(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _UpdateParticipantVolumeOptions = Marshal.PtrToStructure<UpdateParticipantVolumeOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: RTCAudio.OnUpdateParticipantVolumeCallback
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static void EOS_RTCAudio_UpdateReceiving(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _UpdateReceivingOptions = Marshal.PtrToStructure<UpdateReceivingOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: RTCAudio.OnUpdateReceivingCallback
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static void EOS_RTCAudio_UpdateReceivingVolume(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _UpdateReceivingVolumeOptions = Marshal.PtrToStructure<UpdateReceivingVolumeOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: RTCAudio.OnUpdateReceivingVolumeCallback
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static void EOS_RTCAudio_UpdateSending(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _UpdateSendingOptions = Marshal.PtrToStructure<UpdateSendingOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: RTCAudio.OnUpdateSendingCallback
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static void EOS_RTCAudio_UpdateSendingVolume(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _UpdateSendingVolumeOptions = Marshal.PtrToStructure<UpdateSendingVolumeOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: RTCAudio.OnUpdateSendingVolumeCallback
        }
#endif
    }
}
