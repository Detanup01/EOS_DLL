using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EOS_SDK.CustomInvites
{
    public unsafe class CustomInvites_Exports
    {
#if CUSTOMINVITES
       [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static void EOS_CustomInvites_AcceptRequestToJoin(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _AcceptRequestToJoinOptions = Marshal.PtrToStructure<AcceptRequestToJoinOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: CustomInvites.OnAcceptRequestToJoinCallback
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static ulong EOS_CustomInvites_AddNotifyCustomInviteAccepted(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationFn)
		{
			var _AddNotifyCustomInviteAcceptedOptions = Marshal.PtrToStructure<AddNotifyCustomInviteAcceptedOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)notificationFn; //Delegate Class was: CustomInvites.OnCustomInviteAcceptedCallback
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static ulong EOS_CustomInvites_AddNotifyCustomInviteReceived(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationFn)
		{
			var _AddNotifyCustomInviteReceivedOptions = Marshal.PtrToStructure<AddNotifyCustomInviteReceivedOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)notificationFn; //Delegate Class was: CustomInvites.OnCustomInviteReceivedCallback
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static ulong EOS_CustomInvites_AddNotifyCustomInviteRejected(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationFn)
		{
			var _AddNotifyCustomInviteRejectedOptions = Marshal.PtrToStructure<AddNotifyCustomInviteRejectedOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)notificationFn; //Delegate Class was: CustomInvites.OnCustomInviteRejectedCallback
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static ulong EOS_CustomInvites_AddNotifyRequestToJoinAccepted(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationFn)
		{
			var _AddNotifyRequestToJoinAcceptedOptions = Marshal.PtrToStructure<AddNotifyRequestToJoinAcceptedOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)notificationFn; //Delegate Class was: CustomInvites.OnRequestToJoinAcceptedCallback
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static ulong EOS_CustomInvites_AddNotifyRequestToJoinReceived(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationFn)
		{
			var _AddNotifyRequestToJoinReceivedOptions = Marshal.PtrToStructure<AddNotifyRequestToJoinReceivedOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)notificationFn; //Delegate Class was: CustomInvites.OnRequestToJoinReceivedCallback
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static ulong EOS_CustomInvites_AddNotifyRequestToJoinRejected(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationFn)
		{
			var _AddNotifyRequestToJoinRejectedOptions = Marshal.PtrToStructure<AddNotifyRequestToJoinRejectedOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)notificationFn; //Delegate Class was: CustomInvites.OnRequestToJoinRejectedCallback
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static ulong EOS_CustomInvites_AddNotifyRequestToJoinResponseReceived(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationFn)
		{
			var _AddNotifyRequestToJoinResponseReceivedOptions = Marshal.PtrToStructure<AddNotifyRequestToJoinResponseReceivedOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)notificationFn; //Delegate Class was: CustomInvites.OnRequestToJoinResponseReceivedCallback
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static ulong EOS_CustomInvites_AddNotifySendCustomNativeInviteRequested(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationFn)
		{
			var _AddNotifySendCustomNativeInviteRequestedOptions = Marshal.PtrToStructure<AddNotifySendCustomNativeInviteRequestedOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)notificationFn; //Delegate Class was: CustomInvites.OnSendCustomNativeInviteRequestedCallback
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static Result EOS_CustomInvites_FinalizeInvite(IntPtr handle, IntPtr options)
		{
			var _FinalizeInviteOptions = Marshal.PtrToStructure<FinalizeInviteOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static void EOS_CustomInvites_RejectRequestToJoin(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _RejectRequestToJoinOptions = Marshal.PtrToStructure<RejectRequestToJoinOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: CustomInvites.OnRejectRequestToJoinCallback
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static void EOS_CustomInvites_RemoveNotifyCustomInviteAccepted(IntPtr handle, ulong inId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static void EOS_CustomInvites_RemoveNotifyCustomInviteReceived(IntPtr handle, ulong inId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static void EOS_CustomInvites_RemoveNotifyCustomInviteRejected(IntPtr handle, ulong inId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static void EOS_CustomInvites_RemoveNotifyRequestToJoinAccepted(IntPtr handle, ulong inId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static void EOS_CustomInvites_RemoveNotifyRequestToJoinReceived(IntPtr handle, ulong inId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static void EOS_CustomInvites_RemoveNotifyRequestToJoinRejected(IntPtr handle, ulong inId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static void EOS_CustomInvites_RemoveNotifyRequestToJoinResponseReceived(IntPtr handle, ulong inId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static void EOS_CustomInvites_RemoveNotifySendCustomNativeInviteRequested(IntPtr handle, ulong inId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static void EOS_CustomInvites_SendCustomInvite(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _SendCustomInviteOptions = Marshal.PtrToStructure<SendCustomInviteOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: CustomInvites.OnSendCustomInviteCallback
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static void EOS_CustomInvites_SendRequestToJoin(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _SendRequestToJoinOptions = Marshal.PtrToStructure<SendRequestToJoinOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: CustomInvites.OnSendRequestToJoinCallback
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static Result EOS_CustomInvites_SetCustomInvite(IntPtr handle, IntPtr options)
		{
			var _SetCustomInviteOptions = Marshal.PtrToStructure<SetCustomInviteOptions>(options);
        }
#endif
    }
}
