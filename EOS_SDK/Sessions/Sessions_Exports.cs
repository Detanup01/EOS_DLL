using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOS_SDK.Sessions
{
    public unsafe class Sessions_Exports
    {
#if false

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_Sessions_AddNotifyJoinSessionAccepted(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationFn)
		{
			var _AddNotifyJoinSessionAcceptedOptions = Marshal.PtrToStructure<AddNotifyJoinSessionAcceptedOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)notificationFn; //Delegate Class was: Sessions.OnJoinSessionAcceptedCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_Sessions_AddNotifyLeaveSessionRequested(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationFn)
		{
			var _AddNotifyLeaveSessionRequestedOptions = Marshal.PtrToStructure<AddNotifyLeaveSessionRequestedOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)notificationFn; //Delegate Class was: Sessions.OnLeaveSessionRequestedCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_Sessions_AddNotifySendSessionNativeInviteRequested(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationFn)
		{
			var _AddNotifySendSessionNativeInviteRequestedOptions = Marshal.PtrToStructure<AddNotifySendSessionNativeInviteRequestedOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)notificationFn; //Delegate Class was: Sessions.OnSendSessionNativeInviteRequestedCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_Sessions_AddNotifySessionInviteAccepted(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationFn)
		{
			var _AddNotifySessionInviteAcceptedOptions = Marshal.PtrToStructure<AddNotifySessionInviteAcceptedOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)notificationFn; //Delegate Class was: Sessions.OnSessionInviteAcceptedCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_Sessions_AddNotifySessionInviteReceived(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationFn)
		{
			var _AddNotifySessionInviteReceivedOptions = Marshal.PtrToStructure<AddNotifySessionInviteReceivedOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)notificationFn; //Delegate Class was: Sessions.OnSessionInviteReceivedCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_Sessions_AddNotifySessionInviteRejected(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationFn)
		{
			var _AddNotifySessionInviteRejectedOptions = Marshal.PtrToStructure<AddNotifySessionInviteRejectedOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)notificationFn; //Delegate Class was: Sessions.OnSessionInviteRejectedCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Sessions_CopyActiveSessionHandle(IntPtr handle, IntPtr options, IntPtr outSessionHandle)
		{
			var _CopyActiveSessionHandleOptions = Marshal.PtrToStructure<CopyActiveSessionHandleOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Sessions_CopySessionHandleByInviteId(IntPtr handle, IntPtr options, IntPtr outSessionHandle)
		{
			var _CopySessionHandleByInviteIdOptions = Marshal.PtrToStructure<CopySessionHandleByInviteIdOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Sessions_CopySessionHandleByUiEventId(IntPtr handle, IntPtr options, IntPtr outSessionHandle)
		{
			var _CopySessionHandleByUiEventIdOptions = Marshal.PtrToStructure<CopySessionHandleByUiEventIdOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Sessions_CopySessionHandleForPresence(IntPtr handle, IntPtr options, IntPtr outSessionHandle)
		{
			var _CopySessionHandleForPresenceOptions = Marshal.PtrToStructure<CopySessionHandleForPresenceOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Sessions_CreateSessionModification(IntPtr handle, IntPtr options, IntPtr outSessionModificationHandle)
		{
			var _CreateSessionModificationOptions = Marshal.PtrToStructure<CreateSessionModificationOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Sessions_CreateSessionSearch(IntPtr handle, IntPtr options, IntPtr outSessionSearchHandle)
		{
			var _CreateSessionSearchOptions = Marshal.PtrToStructure<CreateSessionSearchOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Sessions_DestroySession(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _DestroySessionOptions = Marshal.PtrToStructure<DestroySessionOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: Sessions.OnDestroySessionCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Sessions_DumpSessionState(IntPtr handle, IntPtr options)
		{
			var _DumpSessionStateOptions = Marshal.PtrToStructure<DumpSessionStateOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Sessions_EndSession(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _EndSessionOptions = Marshal.PtrToStructure<EndSessionOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: Sessions.OnEndSessionCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static uint EOS_Sessions_GetInviteCount(IntPtr handle, IntPtr options)
		{
			var _GetInviteCountOptions = Marshal.PtrToStructure<GetInviteCountOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Sessions_GetInviteIdByIndex(IntPtr handle, IntPtr options, IntPtr outBuffer, [Out] int inOutBufferLength)
		{
			var _GetInviteIdByIndexOptions = Marshal.PtrToStructure<GetInviteIdByIndexOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Sessions_IsUserInSession(IntPtr handle, IntPtr options)
		{
			var _IsUserInSessionOptions = Marshal.PtrToStructure<IsUserInSessionOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Sessions_JoinSession(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _JoinSessionOptions = Marshal.PtrToStructure<JoinSessionOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: Sessions.OnJoinSessionCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Sessions_QueryInvites(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _QueryInvitesOptions = Marshal.PtrToStructure<QueryInvitesOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: Sessions.OnQueryInvitesCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Sessions_RegisterPlayers(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _RegisterPlayersOptions = Marshal.PtrToStructure<RegisterPlayersOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: Sessions.OnRegisterPlayersCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Sessions_RejectInvite(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _RejectInviteOptions = Marshal.PtrToStructure<RejectInviteOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: Sessions.OnRejectInviteCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Sessions_RemoveNotifyJoinSessionAccepted(IntPtr handle, ulong inId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Sessions_RemoveNotifyLeaveSessionRequested(IntPtr handle, ulong inId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Sessions_RemoveNotifySendSessionNativeInviteRequested(IntPtr handle, ulong inId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Sessions_RemoveNotifySessionInviteAccepted(IntPtr handle, ulong inId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Sessions_RemoveNotifySessionInviteReceived(IntPtr handle, ulong inId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Sessions_RemoveNotifySessionInviteRejected(IntPtr handle, ulong inId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Sessions_SendInvite(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _SendInviteOptions = Marshal.PtrToStructure<SendInviteOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: Sessions.OnSendInviteCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Sessions_StartSession(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _StartSessionOptions = Marshal.PtrToStructure<StartSessionOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: Sessions.OnStartSessionCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Sessions_UnregisterPlayers(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _UnregisterPlayersOptions = Marshal.PtrToStructure<UnregisterPlayersOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: Sessions.OnUnregisterPlayersCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Sessions_UpdateSession(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _UpdateSessionOptions = Marshal.PtrToStructure<UpdateSessionOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: Sessions.OnUpdateSessionCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Sessions_UpdateSessionModification(IntPtr handle, IntPtr options, IntPtr outSessionModificationHandle)
		{
			var _UpdateSessionModificationOptions = Marshal.PtrToStructure<UpdateSessionModificationOptions>(options);
        }
#endif
    }
}
