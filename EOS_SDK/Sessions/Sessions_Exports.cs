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
        public static void EOS_SessionDetails_Attribute_Release(IntPtr sessionAttribute)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_SessionDetails_CopyInfo(IntPtr handle, IntPtr options, IntPtr outSessionInfo)
		{
			var _SessionDetailsCopyInfoOptions = Marshal.PtrToStructure<SessionDetailsCopyInfoOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_SessionDetails_CopySessionAttributeByIndex(IntPtr handle, IntPtr options, IntPtr outSessionAttribute)
		{
			var _SessionDetailsCopySessionAttributeByIndexOptions = Marshal.PtrToStructure<SessionDetailsCopySessionAttributeByIndexOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_SessionDetails_CopySessionAttributeByKey(IntPtr handle, IntPtr options, IntPtr outSessionAttribute)
		{
			var _SessionDetailsCopySessionAttributeByKeyOptions = Marshal.PtrToStructure<SessionDetailsCopySessionAttributeByKeyOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static uint EOS_SessionDetails_GetSessionAttributeCount(IntPtr handle, IntPtr options)
		{
			var _SessionDetailsGetSessionAttributeCountOptions = Marshal.PtrToStructure<SessionDetailsGetSessionAttributeCountOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_SessionDetails_Info_Release(IntPtr sessionInfo)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_SessionDetails_Release(IntPtr sessionHandle)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_SessionModification_AddAttribute(IntPtr handle, IntPtr options)
		{
			var _SessionModificationAddAttributeOptions = Marshal.PtrToStructure<SessionModificationAddAttributeOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_SessionModification_Release(IntPtr sessionModificationHandle)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_SessionModification_RemoveAttribute(IntPtr handle, IntPtr options)
		{
			var _SessionModificationRemoveAttributeOptions = Marshal.PtrToStructure<SessionModificationRemoveAttributeOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_SessionModification_SetAllowedPlatformIds(IntPtr handle, IntPtr options)
		{
			var _SessionModificationSetAllowedPlatformIdsOptions = Marshal.PtrToStructure<SessionModificationSetAllowedPlatformIdsOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_SessionModification_SetBucketId(IntPtr handle, IntPtr options)
		{
			var _SessionModificationSetBucketIdOptions = Marshal.PtrToStructure<SessionModificationSetBucketIdOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_SessionModification_SetHostAddress(IntPtr handle, IntPtr options)
		{
			var _SessionModificationSetHostAddressOptions = Marshal.PtrToStructure<SessionModificationSetHostAddressOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_SessionModification_SetInvitesAllowed(IntPtr handle, IntPtr options)
		{
			var _SessionModificationSetInvitesAllowedOptions = Marshal.PtrToStructure<SessionModificationSetInvitesAllowedOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_SessionModification_SetJoinInProgressAllowed(IntPtr handle, IntPtr options)
		{
			var _SessionModificationSetJoinInProgressAllowedOptions = Marshal.PtrToStructure<SessionModificationSetJoinInProgressAllowedOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_SessionModification_SetMaxPlayers(IntPtr handle, IntPtr options)
		{
			var _SessionModificationSetMaxPlayersOptions = Marshal.PtrToStructure<SessionModificationSetMaxPlayersOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_SessionModification_SetPermissionLevel(IntPtr handle, IntPtr options)
		{
			var _SessionModificationSetPermissionLevelOptions = Marshal.PtrToStructure<SessionModificationSetPermissionLevelOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_SessionSearch_CopySearchResultByIndex(IntPtr handle, IntPtr options, IntPtr outSessionHandle)
		{
			var _SessionSearchCopySearchResultByIndexOptions = Marshal.PtrToStructure<SessionSearchCopySearchResultByIndexOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_SessionSearch_Find(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _SessionSearchFindOptions = Marshal.PtrToStructure<SessionSearchFindOptions>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: Sessions.SessionSearchOnFindCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static uint EOS_SessionSearch_GetSearchResultCount(IntPtr handle, IntPtr options)
		{
			var _SessionSearchGetSearchResultCountOptions = Marshal.PtrToStructure<SessionSearchGetSearchResultCountOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_SessionSearch_Release(IntPtr sessionSearchHandle)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_SessionSearch_RemoveParameter(IntPtr handle, IntPtr options)
		{
			var _SessionSearchRemoveParameterOptions = Marshal.PtrToStructure<SessionSearchRemoveParameterOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_SessionSearch_SetMaxResults(IntPtr handle, IntPtr options)
		{
			var _SessionSearchSetMaxResultsOptions = Marshal.PtrToStructure<SessionSearchSetMaxResultsOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_SessionSearch_SetParameter(IntPtr handle, IntPtr options)
		{
			var _SessionSearchSetParameterOptions = Marshal.PtrToStructure<SessionSearchSetParameterOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_SessionSearch_SetSessionId(IntPtr handle, IntPtr options)
		{
			var _SessionSearchSetSessionIdOptions = Marshal.PtrToStructure<SessionSearchSetSessionIdOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_SessionSearch_SetTargetUserId(IntPtr handle, IntPtr options)
		{
			var _SessionSearchSetTargetUserIdOptions = Marshal.PtrToStructure<SessionSearchSetTargetUserIdOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_Sessions_AddNotifyJoinSessionAccepted(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationFn)
		{
			var _AddNotifyJoinSessionAcceptedOptions = Marshal.PtrToStructure<AddNotifyJoinSessionAcceptedOptions>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)notificationFn; //Delegate Class was: Sessions.OnJoinSessionAcceptedCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_Sessions_AddNotifyLeaveSessionRequested(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationFn)
		{
			var _AddNotifyLeaveSessionRequestedOptions = Marshal.PtrToStructure<AddNotifyLeaveSessionRequestedOptions>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)notificationFn; //Delegate Class was: Sessions.OnLeaveSessionRequestedCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_Sessions_AddNotifySendSessionNativeInviteRequested(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationFn)
		{
			var _AddNotifySendSessionNativeInviteRequestedOptions = Marshal.PtrToStructure<AddNotifySendSessionNativeInviteRequestedOptions>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)notificationFn; //Delegate Class was: Sessions.OnSendSessionNativeInviteRequestedCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_Sessions_AddNotifySessionInviteAccepted(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationFn)
		{
			var _AddNotifySessionInviteAcceptedOptions = Marshal.PtrToStructure<AddNotifySessionInviteAcceptedOptions>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)notificationFn; //Delegate Class was: Sessions.OnSessionInviteAcceptedCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_Sessions_AddNotifySessionInviteReceived(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationFn)
		{
			var _AddNotifySessionInviteReceivedOptions = Marshal.PtrToStructure<AddNotifySessionInviteReceivedOptions>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)notificationFn; //Delegate Class was: Sessions.OnSessionInviteReceivedCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_Sessions_AddNotifySessionInviteRejected(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationFn)
		{
			var _AddNotifySessionInviteRejectedOptions = Marshal.PtrToStructure<AddNotifySessionInviteRejectedOptions>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)notificationFn; //Delegate Class was: Sessions.OnSessionInviteRejectedCallback
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
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: Sessions.OnDestroySessionCallback
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
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: Sessions.OnEndSessionCallback
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
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: Sessions.OnJoinSessionCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Sessions_QueryInvites(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _QueryInvitesOptions = Marshal.PtrToStructure<QueryInvitesOptions>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: Sessions.OnQueryInvitesCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Sessions_RegisterPlayers(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _RegisterPlayersOptions = Marshal.PtrToStructure<RegisterPlayersOptions>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: Sessions.OnRegisterPlayersCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Sessions_RejectInvite(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _RejectInviteOptions = Marshal.PtrToStructure<RejectInviteOptions>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: Sessions.OnRejectInviteCallback
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
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: Sessions.OnSendInviteCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Sessions_StartSession(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _StartSessionOptions = Marshal.PtrToStructure<StartSessionOptions>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: Sessions.OnStartSessionCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Sessions_UnregisterPlayers(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _UnregisterPlayersOptions = Marshal.PtrToStructure<UnregisterPlayersOptions>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: Sessions.OnUnregisterPlayersCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Sessions_UpdateSession(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _UpdateSessionOptions = Marshal.PtrToStructure<UpdateSessionOptions>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: Sessions.OnUpdateSessionCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Sessions_UpdateSessionModification(IntPtr handle, IntPtr options, IntPtr outSessionModificationHandle)
		{
			var _UpdateSessionModificationOptions = Marshal.PtrToStructure<UpdateSessionModificationOptions>(options);
        }
#endif
    }
}
