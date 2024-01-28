using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOS_SDK.Lobby
{
    public unsafe class Lobby_Exports
    {
#if false

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_LobbyDetails_CopyAttributeByIndex(IntPtr handle, IntPtr options, IntPtr outAttribute)
		{
			var _LobbyDetailsCopyAttributeByIndexOptions = Marshal.PtrToStructure<LobbyDetailsCopyAttributeByIndexOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_LobbyDetails_CopyAttributeByKey(IntPtr handle, IntPtr options, IntPtr outAttribute)
		{
			var _LobbyDetailsCopyAttributeByKeyOptions = Marshal.PtrToStructure<LobbyDetailsCopyAttributeByKeyOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_LobbyDetails_CopyInfo(IntPtr handle, IntPtr options, IntPtr outLobbyDetailsInfo)
		{
			var _LobbyDetailsCopyInfoOptions = Marshal.PtrToStructure<LobbyDetailsCopyInfoOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_LobbyDetails_CopyMemberAttributeByIndex(IntPtr handle, IntPtr options, IntPtr outAttribute)
		{
			var _LobbyDetailsCopyMemberAttributeByIndexOptions = Marshal.PtrToStructure<LobbyDetailsCopyMemberAttributeByIndexOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_LobbyDetails_CopyMemberAttributeByKey(IntPtr handle, IntPtr options, IntPtr outAttribute)
		{
			var _LobbyDetailsCopyMemberAttributeByKeyOptions = Marshal.PtrToStructure<LobbyDetailsCopyMemberAttributeByKeyOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_LobbyDetails_CopyMemberInfo(IntPtr handle, IntPtr options, IntPtr outLobbyDetailsMemberInfo)
		{
			var _LobbyDetailsCopyMemberInfoOptions = Marshal.PtrToStructure<LobbyDetailsCopyMemberInfoOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static uint EOS_LobbyDetails_GetAttributeCount(IntPtr handle, IntPtr options)
		{
			var _LobbyDetailsGetAttributeCountOptions = Marshal.PtrToStructure<LobbyDetailsGetAttributeCountOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_LobbyDetails_GetLobbyOwner(IntPtr handle, IntPtr options)
		{
			var _LobbyDetailsGetLobbyOwnerOptions = Marshal.PtrToStructure<LobbyDetailsGetLobbyOwnerOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static uint EOS_LobbyDetails_GetMemberAttributeCount(IntPtr handle, IntPtr options)
		{
			var _LobbyDetailsGetMemberAttributeCountOptions = Marshal.PtrToStructure<LobbyDetailsGetMemberAttributeCountOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_LobbyDetails_GetMemberByIndex(IntPtr handle, IntPtr options)
		{
			var _LobbyDetailsGetMemberByIndexOptions = Marshal.PtrToStructure<LobbyDetailsGetMemberByIndexOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static uint EOS_LobbyDetails_GetMemberCount(IntPtr handle, IntPtr options)
		{
			var _LobbyDetailsGetMemberCountOptions = Marshal.PtrToStructure<LobbyDetailsGetMemberCountOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_LobbyDetails_Info_Release(IntPtr lobbyDetailsInfo)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_LobbyDetails_MemberInfo_Release(IntPtr lobbyDetailsMemberInfo)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_LobbyDetails_Release(IntPtr lobbyHandle)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_LobbyModification_AddAttribute(IntPtr handle, IntPtr options)
		{
			var _LobbyModificationAddAttributeOptions = Marshal.PtrToStructure<LobbyModificationAddAttributeOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_LobbyModification_AddMemberAttribute(IntPtr handle, IntPtr options)
		{
			var _LobbyModificationAddMemberAttributeOptions = Marshal.PtrToStructure<LobbyModificationAddMemberAttributeOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_LobbyModification_Release(IntPtr lobbyModificationHandle)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_LobbyModification_RemoveAttribute(IntPtr handle, IntPtr options)
		{
			var _LobbyModificationRemoveAttributeOptions = Marshal.PtrToStructure<LobbyModificationRemoveAttributeOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_LobbyModification_RemoveMemberAttribute(IntPtr handle, IntPtr options)
		{
			var _LobbyModificationRemoveMemberAttributeOptions = Marshal.PtrToStructure<LobbyModificationRemoveMemberAttributeOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_LobbyModification_SetAllowedPlatformIds(IntPtr handle, IntPtr options)
		{
			var _LobbyModificationSetAllowedPlatformIdsOptions = Marshal.PtrToStructure<LobbyModificationSetAllowedPlatformIdsOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_LobbyModification_SetBucketId(IntPtr handle, IntPtr options)
		{
			var _LobbyModificationSetBucketIdOptions = Marshal.PtrToStructure<LobbyModificationSetBucketIdOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_LobbyModification_SetInvitesAllowed(IntPtr handle, IntPtr options)
		{
			var _LobbyModificationSetInvitesAllowedOptions = Marshal.PtrToStructure<LobbyModificationSetInvitesAllowedOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_LobbyModification_SetMaxMembers(IntPtr handle, IntPtr options)
		{
			var _LobbyModificationSetMaxMembersOptions = Marshal.PtrToStructure<LobbyModificationSetMaxMembersOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_LobbyModification_SetPermissionLevel(IntPtr handle, IntPtr options)
		{
			var _LobbyModificationSetPermissionLevelOptions = Marshal.PtrToStructure<LobbyModificationSetPermissionLevelOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_LobbySearch_CopySearchResultByIndex(IntPtr handle, IntPtr options, IntPtr outLobbyDetailsHandle)
		{
			var _LobbySearchCopySearchResultByIndexOptions = Marshal.PtrToStructure<LobbySearchCopySearchResultByIndexOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_LobbySearch_Find(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _LobbySearchFindOptions = Marshal.PtrToStructure<LobbySearchFindOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: Lobby.LobbySearchOnFindCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static uint EOS_LobbySearch_GetSearchResultCount(IntPtr handle, IntPtr options)
		{
			var _LobbySearchGetSearchResultCountOptions = Marshal.PtrToStructure<LobbySearchGetSearchResultCountOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_LobbySearch_Release(IntPtr lobbySearchHandle)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_LobbySearch_RemoveParameter(IntPtr handle, IntPtr options)
		{
			var _LobbySearchRemoveParameterOptions = Marshal.PtrToStructure<LobbySearchRemoveParameterOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_LobbySearch_SetLobbyId(IntPtr handle, IntPtr options)
		{
			var _LobbySearchSetLobbyIdOptions = Marshal.PtrToStructure<LobbySearchSetLobbyIdOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_LobbySearch_SetMaxResults(IntPtr handle, IntPtr options)
		{
			var _LobbySearchSetMaxResultsOptions = Marshal.PtrToStructure<LobbySearchSetMaxResultsOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_LobbySearch_SetParameter(IntPtr handle, IntPtr options)
		{
			var _LobbySearchSetParameterOptions = Marshal.PtrToStructure<LobbySearchSetParameterOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_LobbySearch_SetTargetUserId(IntPtr handle, IntPtr options)
		{
			var _LobbySearchSetTargetUserIdOptions = Marshal.PtrToStructure<LobbySearchSetTargetUserIdOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_Lobby_AddNotifyJoinLobbyAccepted(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationFn)
		{
			var _AddNotifyJoinLobbyAcceptedOptions = Marshal.PtrToStructure<AddNotifyJoinLobbyAcceptedOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)notificationFn; //Delegate Class was: Lobby.OnJoinLobbyAcceptedCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_Lobby_AddNotifyLeaveLobbyRequested(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationFn)
		{
			var _AddNotifyLeaveLobbyRequestedOptions = Marshal.PtrToStructure<AddNotifyLeaveLobbyRequestedOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)notificationFn; //Delegate Class was: Lobby.OnLeaveLobbyRequestedCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_Lobby_AddNotifyLobbyInviteAccepted(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationFn)
		{
			var _AddNotifyLobbyInviteAcceptedOptions = Marshal.PtrToStructure<AddNotifyLobbyInviteAcceptedOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)notificationFn; //Delegate Class was: Lobby.OnLobbyInviteAcceptedCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_Lobby_AddNotifyLobbyInviteReceived(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationFn)
		{
			var _AddNotifyLobbyInviteReceivedOptions = Marshal.PtrToStructure<AddNotifyLobbyInviteReceivedOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)notificationFn; //Delegate Class was: Lobby.OnLobbyInviteReceivedCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_Lobby_AddNotifyLobbyInviteRejected(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationFn)
		{
			var _AddNotifyLobbyInviteRejectedOptions = Marshal.PtrToStructure<AddNotifyLobbyInviteRejectedOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)notificationFn; //Delegate Class was: Lobby.OnLobbyInviteRejectedCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_Lobby_AddNotifyLobbyMemberStatusReceived(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationFn)
		{
			var _AddNotifyLobbyMemberStatusReceivedOptions = Marshal.PtrToStructure<AddNotifyLobbyMemberStatusReceivedOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)notificationFn; //Delegate Class was: Lobby.OnLobbyMemberStatusReceivedCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_Lobby_AddNotifyLobbyMemberUpdateReceived(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationFn)
		{
			var _AddNotifyLobbyMemberUpdateReceivedOptions = Marshal.PtrToStructure<AddNotifyLobbyMemberUpdateReceivedOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)notificationFn; //Delegate Class was: Lobby.OnLobbyMemberUpdateReceivedCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_Lobby_AddNotifyLobbyUpdateReceived(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationFn)
		{
			var _AddNotifyLobbyUpdateReceivedOptions = Marshal.PtrToStructure<AddNotifyLobbyUpdateReceivedOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)notificationFn; //Delegate Class was: Lobby.OnLobbyUpdateReceivedCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_Lobby_AddNotifyRTCRoomConnectionChanged(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationFn)
		{
			var _AddNotifyRTCRoomConnectionChangedOptions = Marshal.PtrToStructure<AddNotifyRTCRoomConnectionChangedOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)notificationFn; //Delegate Class was: Lobby.OnRTCRoomConnectionChangedCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_Lobby_AddNotifySendLobbyNativeInviteRequested(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationFn)
		{
			var _AddNotifySendLobbyNativeInviteRequestedOptions = Marshal.PtrToStructure<AddNotifySendLobbyNativeInviteRequestedOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)notificationFn; //Delegate Class was: Lobby.OnSendLobbyNativeInviteRequestedCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Lobby_Attribute_Release(IntPtr lobbyAttribute)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Lobby_CopyLobbyDetailsHandle(IntPtr handle, IntPtr options, IntPtr outLobbyDetailsHandle)
		{
			var _CopyLobbyDetailsHandleOptions = Marshal.PtrToStructure<CopyLobbyDetailsHandleOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Lobby_CopyLobbyDetailsHandleByInviteId(IntPtr handle, IntPtr options, IntPtr outLobbyDetailsHandle)
		{
			var _CopyLobbyDetailsHandleByInviteIdOptions = Marshal.PtrToStructure<CopyLobbyDetailsHandleByInviteIdOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Lobby_CopyLobbyDetailsHandleByUiEventId(IntPtr handle, IntPtr options, IntPtr outLobbyDetailsHandle)
		{
			var _CopyLobbyDetailsHandleByUiEventIdOptions = Marshal.PtrToStructure<CopyLobbyDetailsHandleByUiEventIdOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Lobby_CreateLobby(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _CreateLobbyOptions = Marshal.PtrToStructure<CreateLobbyOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: Lobby.OnCreateLobbyCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Lobby_CreateLobbySearch(IntPtr handle, IntPtr options, IntPtr outLobbySearchHandle)
		{
			var _CreateLobbySearchOptions = Marshal.PtrToStructure<CreateLobbySearchOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Lobby_DestroyLobby(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _DestroyLobbyOptions = Marshal.PtrToStructure<DestroyLobbyOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: Lobby.OnDestroyLobbyCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Lobby_GetConnectString(IntPtr handle, IntPtr options, IntPtr outBuffer, [Out] uint inOutBufferLength)
		{
			var _GetConnectStringOptions = Marshal.PtrToStructure<GetConnectStringOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static uint EOS_Lobby_GetInviteCount(IntPtr handle, IntPtr options)
		{
			var _GetInviteCountOptions = Marshal.PtrToStructure<GetInviteCountOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Lobby_GetInviteIdByIndex(IntPtr handle, IntPtr options, IntPtr outBuffer, [Out] int inOutBufferLength)
		{
			var _GetInviteIdByIndexOptions = Marshal.PtrToStructure<GetInviteIdByIndexOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Lobby_GetRTCRoomName(IntPtr handle, IntPtr options, IntPtr outBuffer, [Out] uint inOutBufferLength)
		{
			var _GetRTCRoomNameOptions = Marshal.PtrToStructure<GetRTCRoomNameOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Lobby_HardMuteMember(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _HardMuteMemberOptions = Marshal.PtrToStructure<HardMuteMemberOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: Lobby.OnHardMuteMemberCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Lobby_IsRTCRoomConnected(IntPtr handle, IntPtr options, [Out] int bOutIsConnected)
		{
			var _IsRTCRoomConnectedOptions = Marshal.PtrToStructure<IsRTCRoomConnectedOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Lobby_JoinLobby(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _JoinLobbyOptions = Marshal.PtrToStructure<JoinLobbyOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: Lobby.OnJoinLobbyCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Lobby_JoinLobbyById(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _JoinLobbyByIdOptions = Marshal.PtrToStructure<JoinLobbyByIdOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: Lobby.OnJoinLobbyByIdCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Lobby_KickMember(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _KickMemberOptions = Marshal.PtrToStructure<KickMemberOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: Lobby.OnKickMemberCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Lobby_LeaveLobby(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _LeaveLobbyOptions = Marshal.PtrToStructure<LeaveLobbyOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: Lobby.OnLeaveLobbyCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Lobby_ParseConnectString(IntPtr handle, IntPtr options, IntPtr outBuffer, [Out] uint inOutBufferLength)
		{
			var _ParseConnectStringOptions = Marshal.PtrToStructure<ParseConnectStringOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Lobby_PromoteMember(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _PromoteMemberOptions = Marshal.PtrToStructure<PromoteMemberOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: Lobby.OnPromoteMemberCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Lobby_QueryInvites(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _QueryInvitesOptions = Marshal.PtrToStructure<QueryInvitesOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: Lobby.OnQueryInvitesCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Lobby_RejectInvite(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _RejectInviteOptions = Marshal.PtrToStructure<RejectInviteOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: Lobby.OnRejectInviteCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Lobby_RemoveNotifyJoinLobbyAccepted(IntPtr handle, ulong inId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Lobby_RemoveNotifyLeaveLobbyRequested(IntPtr handle, ulong inId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Lobby_RemoveNotifyLobbyInviteAccepted(IntPtr handle, ulong inId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Lobby_RemoveNotifyLobbyInviteReceived(IntPtr handle, ulong inId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Lobby_RemoveNotifyLobbyInviteRejected(IntPtr handle, ulong inId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Lobby_RemoveNotifyLobbyMemberStatusReceived(IntPtr handle, ulong inId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Lobby_RemoveNotifyLobbyMemberUpdateReceived(IntPtr handle, ulong inId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Lobby_RemoveNotifyLobbyUpdateReceived(IntPtr handle, ulong inId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Lobby_RemoveNotifyRTCRoomConnectionChanged(IntPtr handle, ulong inId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Lobby_RemoveNotifySendLobbyNativeInviteRequested(IntPtr handle, ulong inId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Lobby_SendInvite(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _SendInviteOptions = Marshal.PtrToStructure<SendInviteOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: Lobby.OnSendInviteCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Lobby_UpdateLobby(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _UpdateLobbyOptions = Marshal.PtrToStructure<UpdateLobbyOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: Lobby.OnUpdateLobbyCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Lobby_UpdateLobbyModification(IntPtr handle, IntPtr options, IntPtr outLobbyModificationHandle)
		{
			var _UpdateLobbyModificationOptions = Marshal.PtrToStructure<UpdateLobbyModificationOptions>(options);
        }
#endif
    }
}
