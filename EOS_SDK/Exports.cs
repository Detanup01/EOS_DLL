using EOS_SDK.Achievements;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EOS_SDK
{
    public unsafe class Exports
    {
#if false
        #region Exports

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_Achievements_AddNotifyAchievementsUnlocked(IntPtr handle, AddNotifyAchievementsUnlockedOptionsInternal* options, IntPtr clientData, delegate* unmanaged[Stdcall, Cdecl]<ref OnAchievementsUnlockedCallbackInfoInternal,void> notificationFn)
        {
            OnAchievementsUnlockedCallbackInfoInternal onAchievementsUnlockedCallbackInfoInternal = new()
            { 
                 m_ClientData = clientData,
                 m_AchievementIds = IntPtr.Zero,
                 m_AchievementsCount = 0,
                 m_UserId = IntPtr.Zero
            };
            notificationFn(ref onAchievementsUnlockedCallbackInfoInternal);
            return 0;
        }

        public static ulong EOS_Achievements_AddNotifyAchievementsUnlockedV2(IntPtr handle, ref Achievements.AddNotifyAchievementsUnlockedV2OptionsInternal options, IntPtr clientData, Achievements.OnAchievementsUnlockedCallbackV2Internal notificationFn)
        {
        }

        public static Result EOS_Achievements_CopyAchievementDefinitionByAchievementId(IntPtr handle, ref Achievements.CopyAchievementDefinitionByAchievementIdOptionsInternal options, ref IntPtr outDefinition)
        {
        }

        public static Result EOS_Achievements_CopyAchievementDefinitionByIndex(IntPtr handle, ref Achievements.CopyAchievementDefinitionByIndexOptionsInternal options, ref IntPtr outDefinition)
        {
        }

        public static Result EOS_Achievements_CopyAchievementDefinitionV2ByAchievementId(IntPtr handle, ref Achievements.CopyAchievementDefinitionV2ByAchievementIdOptionsInternal options, ref IntPtr outDefinition)
        {
        }

        public static Result EOS_Achievements_CopyAchievementDefinitionV2ByIndex(IntPtr handle, ref Achievements.CopyAchievementDefinitionV2ByIndexOptionsInternal options, ref IntPtr outDefinition)
        {
        }

        public static Result EOS_Achievements_CopyPlayerAchievementByAchievementId(IntPtr handle, ref Achievements.CopyPlayerAchievementByAchievementIdOptionsInternal options, ref IntPtr outAchievement)
        {
        }

        public static Result EOS_Achievements_CopyPlayerAchievementByIndex(IntPtr handle, ref Achievements.CopyPlayerAchievementByIndexOptionsInternal options, ref IntPtr outAchievement)
        {
        }

        public static Result EOS_Achievements_CopyUnlockedAchievementByAchievementId(IntPtr handle, ref Achievements.CopyUnlockedAchievementByAchievementIdOptionsInternal options, ref IntPtr outAchievement)
        {
        }

        public static Result EOS_Achievements_CopyUnlockedAchievementByIndex(IntPtr handle, ref Achievements.CopyUnlockedAchievementByIndexOptionsInternal options, ref IntPtr outAchievement)
        {
        }

        public static void EOS_Achievements_DefinitionV2_Release(IntPtr achievementDefinition)
        {
        }

        public static void EOS_Achievements_Definition_Release(IntPtr achievementDefinition)
        {
        }

        public static uint EOS_Achievements_GetAchievementDefinitionCount(IntPtr handle, ref Achievements.GetAchievementDefinitionCountOptionsInternal options)
        {
        }

        public static uint EOS_Achievements_GetPlayerAchievementCount(IntPtr handle, ref Achievements.GetPlayerAchievementCountOptionsInternal options)
        {
        }

        public static uint EOS_Achievements_GetUnlockedAchievementCount(IntPtr handle, ref Achievements.GetUnlockedAchievementCountOptionsInternal options)
        {
        }

        public static void EOS_Achievements_PlayerAchievement_Release(IntPtr achievement)
        {
        }

        public static void EOS_Achievements_QueryDefinitions(IntPtr handle, ref Achievements.QueryDefinitionsOptionsInternal options, IntPtr clientData, Achievements.OnQueryDefinitionsCompleteCallbackInternal completionDelegate)
        {
        }

        public static void EOS_Achievements_QueryPlayerAchievements(IntPtr handle, ref Achievements.QueryPlayerAchievementsOptionsInternal options, IntPtr clientData, Achievements.OnQueryPlayerAchievementsCompleteCallbackInternal completionDelegate)
        {
        }

        public static void EOS_Achievements_RemoveNotifyAchievementsUnlocked(IntPtr handle, ulong inId)
        {
        }

        public static void EOS_Achievements_UnlockAchievements(IntPtr handle, ref Achievements.UnlockAchievementsOptionsInternal options, IntPtr clientData, Achievements.OnUnlockAchievementsCompleteCallbackInternal completionDelegate)
        {
        }

        public static void EOS_Achievements_UnlockedAchievement_Release(IntPtr achievement)
        {
        }

        public static Result EOS_ActiveSession_CopyInfo(IntPtr handle, ref Sessions.ActiveSessionCopyInfoOptionsInternal options, ref IntPtr outActiveSessionInfo)
        {
        }

        public static IntPtr EOS_ActiveSession_GetRegisteredPlayerByIndex(IntPtr handle, ref Sessions.ActiveSessionGetRegisteredPlayerByIndexOptionsInternal options)
        {
        }

        public static uint EOS_ActiveSession_GetRegisteredPlayerCount(IntPtr handle, ref Sessions.ActiveSessionGetRegisteredPlayerCountOptionsInternal options)
        {
        }

        public static void EOS_ActiveSession_Info_Release(IntPtr activeSessionInfo)
        {
        }

        public static void EOS_ActiveSession_Release(IntPtr activeSessionHandle)
        {
        }

        public static Result EOS_AntiCheatClient_AddExternalIntegrityCatalog(IntPtr handle, ref AntiCheatClient.AddExternalIntegrityCatalogOptionsInternal options)
        {
        }

        public static ulong EOS_AntiCheatClient_AddNotifyClientIntegrityViolated(IntPtr handle, ref AntiCheatClient.AddNotifyClientIntegrityViolatedOptionsInternal options, IntPtr clientData, AntiCheatClient.OnClientIntegrityViolatedCallbackInternal notificationFn)
        {
        }

        public static ulong EOS_AntiCheatClient_AddNotifyMessageToPeer(IntPtr handle, ref AntiCheatClient.AddNotifyMessageToPeerOptionsInternal options, IntPtr clientData, AntiCheatClient.OnMessageToPeerCallbackInternal notificationFn)
        {
        }

        public static ulong EOS_AntiCheatClient_AddNotifyMessageToServer(IntPtr handle, ref AntiCheatClient.AddNotifyMessageToServerOptionsInternal options, IntPtr clientData, AntiCheatClient.OnMessageToServerCallbackInternal notificationFn)
        {
        }

        public static ulong EOS_AntiCheatClient_AddNotifyPeerActionRequired(IntPtr handle, ref AntiCheatClient.AddNotifyPeerActionRequiredOptionsInternal options, IntPtr clientData, AntiCheatClient.OnPeerActionRequiredCallbackInternal notificationFn)
        {
        }

        public static ulong EOS_AntiCheatClient_AddNotifyPeerAuthStatusChanged(IntPtr handle, ref AntiCheatClient.AddNotifyPeerAuthStatusChangedOptionsInternal options, IntPtr clientData, AntiCheatClient.OnPeerAuthStatusChangedCallbackInternal notificationFn)
        {
        }

        public static Result EOS_AntiCheatClient_BeginSession(IntPtr handle, ref AntiCheatClient.BeginSessionOptionsInternal options)
        {
        }

        public static Result EOS_AntiCheatClient_EndSession(IntPtr handle, ref AntiCheatClient.EndSessionOptionsInternal options)
        {
        }

        public static Result EOS_AntiCheatClient_GetProtectMessageOutputLength(IntPtr handle, ref AntiCheatClient.GetProtectMessageOutputLengthOptionsInternal options, ref uint outBufferSizeBytes)
        {
        }

        public static Result EOS_AntiCheatClient_PollStatus(IntPtr handle, ref AntiCheatClient.PollStatusOptionsInternal options, ref AntiCheatClient.AntiCheatClientViolationType outViolationType, IntPtr outMessage)
        {
        }

        public static Result EOS_AntiCheatClient_ProtectMessage(IntPtr handle, ref AntiCheatClient.ProtectMessageOptionsInternal options, IntPtr outBuffer, ref uint outBytesWritten)
        {
        }

        public static Result EOS_AntiCheatClient_ReceiveMessageFromPeer(IntPtr handle, ref AntiCheatClient.ReceiveMessageFromPeerOptionsInternal options)
        {
        }

        public static Result EOS_AntiCheatClient_ReceiveMessageFromServer(IntPtr handle, ref AntiCheatClient.ReceiveMessageFromServerOptionsInternal options)
        {
        }

        public static Result EOS_AntiCheatClient_RegisterPeer(IntPtr handle, ref AntiCheatClient.RegisterPeerOptionsInternal options)
        {
        }

        public static void EOS_AntiCheatClient_RemoveNotifyClientIntegrityViolated(IntPtr handle, ulong notificationId)
        {
        }

        public static void EOS_AntiCheatClient_RemoveNotifyMessageToPeer(IntPtr handle, ulong notificationId)
        {
        }

        public static void EOS_AntiCheatClient_RemoveNotifyMessageToServer(IntPtr handle, ulong notificationId)
        {
        }

        public static void EOS_AntiCheatClient_RemoveNotifyPeerActionRequired(IntPtr handle, ulong notificationId)
        {
        }

        public static void EOS_AntiCheatClient_RemoveNotifyPeerAuthStatusChanged(IntPtr handle, ulong notificationId)
        {
        }

        public static Result EOS_AntiCheatClient_UnprotectMessage(IntPtr handle, ref AntiCheatClient.UnprotectMessageOptionsInternal options, IntPtr outBuffer, ref uint outBytesWritten)
        {
        }

        public static Result EOS_AntiCheatClient_UnregisterPeer(IntPtr handle, ref AntiCheatClient.UnregisterPeerOptionsInternal options)
        {
        }

        public static ulong EOS_AntiCheatServer_AddNotifyClientActionRequired(IntPtr handle, ref AntiCheatServer.AddNotifyClientActionRequiredOptionsInternal options, IntPtr clientData, AntiCheatServer.OnClientActionRequiredCallbackInternal notificationFn)
        {
        }

        public static ulong EOS_AntiCheatServer_AddNotifyClientAuthStatusChanged(IntPtr handle, ref AntiCheatServer.AddNotifyClientAuthStatusChangedOptionsInternal options, IntPtr clientData, AntiCheatServer.OnClientAuthStatusChangedCallbackInternal notificationFn)
        {
        }

        public static ulong EOS_AntiCheatServer_AddNotifyMessageToClient(IntPtr handle, ref AntiCheatServer.AddNotifyMessageToClientOptionsInternal options, IntPtr clientData, AntiCheatServer.OnMessageToClientCallbackInternal notificationFn)
        {
        }

        public static Result EOS_AntiCheatServer_BeginSession(IntPtr handle, ref AntiCheatServer.BeginSessionOptionsInternal options)
        {
        }

        public static Result EOS_AntiCheatServer_EndSession(IntPtr handle, ref AntiCheatServer.EndSessionOptionsInternal options)
        {
        }

        public static Result EOS_AntiCheatServer_GetProtectMessageOutputLength(IntPtr handle, ref AntiCheatServer.GetProtectMessageOutputLengthOptionsInternal options, ref uint outBufferSizeBytes)
        {
        }

        public static Result EOS_AntiCheatServer_LogEvent(IntPtr handle, ref AntiCheatCommon.LogEventOptionsInternal options)
        {
        }

        public static Result EOS_AntiCheatServer_LogGameRoundEnd(IntPtr handle, ref AntiCheatCommon.LogGameRoundEndOptionsInternal options)
        {
        }

        public static Result EOS_AntiCheatServer_LogGameRoundStart(IntPtr handle, ref AntiCheatCommon.LogGameRoundStartOptionsInternal options)
        {
        }

        public static Result EOS_AntiCheatServer_LogPlayerDespawn(IntPtr handle, ref AntiCheatCommon.LogPlayerDespawnOptionsInternal options)
        {
        }

        public static Result EOS_AntiCheatServer_LogPlayerRevive(IntPtr handle, ref AntiCheatCommon.LogPlayerReviveOptionsInternal options)
        {
        }

        public static Result EOS_AntiCheatServer_LogPlayerSpawn(IntPtr handle, ref AntiCheatCommon.LogPlayerSpawnOptionsInternal options)
        {
        }

        public static Result EOS_AntiCheatServer_LogPlayerTakeDamage(IntPtr handle, ref AntiCheatCommon.LogPlayerTakeDamageOptionsInternal options)
        {
        }

        public static Result EOS_AntiCheatServer_LogPlayerTick(IntPtr handle, ref AntiCheatCommon.LogPlayerTickOptionsInternal options)
        {
        }

        public static Result EOS_AntiCheatServer_LogPlayerUseAbility(IntPtr handle, ref AntiCheatCommon.LogPlayerUseAbilityOptionsInternal options)
        {
        }

        public static Result EOS_AntiCheatServer_LogPlayerUseWeapon(IntPtr handle, ref AntiCheatCommon.LogPlayerUseWeaponOptionsInternal options)
        {
        }

        public static Result EOS_AntiCheatServer_ProtectMessage(IntPtr handle, ref AntiCheatServer.ProtectMessageOptionsInternal options, IntPtr outBuffer, ref uint outBytesWritten)
        {
        }

        public static Result EOS_AntiCheatServer_ReceiveMessageFromClient(IntPtr handle, ref AntiCheatServer.ReceiveMessageFromClientOptionsInternal options)
        {
        }

        public static Result EOS_AntiCheatServer_RegisterClient(IntPtr handle, ref AntiCheatServer.RegisterClientOptionsInternal options)
        {
        }

        public static Result EOS_AntiCheatServer_RegisterEvent(IntPtr handle, ref AntiCheatCommon.RegisterEventOptionsInternal options)
        {
        }

        public static void EOS_AntiCheatServer_RemoveNotifyClientActionRequired(IntPtr handle, ulong notificationId)
        {
        }

        public static void EOS_AntiCheatServer_RemoveNotifyClientAuthStatusChanged(IntPtr handle, ulong notificationId)
        {
        }

        public static void EOS_AntiCheatServer_RemoveNotifyMessageToClient(IntPtr handle, ulong notificationId)
        {
        }

        public static Result EOS_AntiCheatServer_SetClientDetails(IntPtr handle, ref AntiCheatCommon.SetClientDetailsOptionsInternal options)
        {
        }

        public static Result EOS_AntiCheatServer_SetClientNetworkState(IntPtr handle, ref AntiCheatServer.SetClientNetworkStateOptionsInternal options)
        {
        }

        public static Result EOS_AntiCheatServer_SetGameSessionId(IntPtr handle, ref AntiCheatCommon.SetGameSessionIdOptionsInternal options)
        {
        }

        public static Result EOS_AntiCheatServer_UnprotectMessage(IntPtr handle, ref AntiCheatServer.UnprotectMessageOptionsInternal options, IntPtr outBuffer, ref uint outBytesWritten)
        {
        }

        public static Result EOS_AntiCheatServer_UnregisterClient(IntPtr handle, ref AntiCheatServer.UnregisterClientOptionsInternal options)
        {
        }

        public static ulong EOS_Auth_AddNotifyLoginStatusChanged(IntPtr handle, ref Auth.AddNotifyLoginStatusChangedOptionsInternal options, IntPtr clientData, Auth.OnLoginStatusChangedCallbackInternal notification)
        {
        }

        public static Result EOS_Auth_CopyIdToken(IntPtr handle, ref Auth.CopyIdTokenOptionsInternal options, ref IntPtr outIdToken)
        {
        }

        public static Result EOS_Auth_CopyUserAuthToken(IntPtr handle, ref Auth.CopyUserAuthTokenOptionsInternal options, IntPtr localUserId, ref IntPtr outUserAuthToken)
        {
        }

        public static void EOS_Auth_DeletePersistentAuth(IntPtr handle, ref Auth.DeletePersistentAuthOptionsInternal options, IntPtr clientData, Auth.OnDeletePersistentAuthCallbackInternal completionDelegate)
        {
        }

        public static IntPtr EOS_Auth_GetLoggedInAccountByIndex(IntPtr handle, int index)
        {
        }

        public static int EOS_Auth_GetLoggedInAccountsCount(IntPtr handle)
        {
        }

        public static LoginStatus EOS_Auth_GetLoginStatus(IntPtr handle, IntPtr localUserId)
        {
        }

        public static IntPtr EOS_Auth_GetMergedAccountByIndex(IntPtr handle, IntPtr localUserId, uint index)
        {
        }

        public static uint EOS_Auth_GetMergedAccountsCount(IntPtr handle, IntPtr localUserId)
        {
        }

        public static Result EOS_Auth_GetSelectedAccountId(IntPtr handle, IntPtr localUserId, ref IntPtr outSelectedAccountId)
        {
        }

        public static void EOS_Auth_IdToken_Release(IntPtr idToken)
        {
        }

        public static void EOS_Auth_LinkAccount(IntPtr handle, ref Auth.LinkAccountOptionsInternal options, IntPtr clientData, Auth.OnLinkAccountCallbackInternal completionDelegate)
        {
        }

        public static void EOS_Auth_Login(IntPtr handle, ref Auth.LoginOptionsInternal options, IntPtr clientData, Auth.OnLoginCallbackInternal completionDelegate)
        {
        }

        public static void EOS_Auth_Logout(IntPtr handle, ref Auth.LogoutOptionsInternal options, IntPtr clientData, Auth.OnLogoutCallbackInternal completionDelegate)
        {
        }

        public static void EOS_Auth_QueryIdToken(IntPtr handle, ref Auth.QueryIdTokenOptionsInternal options, IntPtr clientData, Auth.OnQueryIdTokenCallbackInternal completionDelegate)
        {
        }

        public static void EOS_Auth_RemoveNotifyLoginStatusChanged(IntPtr handle, ulong inId)
        {
        }

        public static void EOS_Auth_Token_Release(IntPtr authToken)
        {
        }

        public static void EOS_Auth_VerifyIdToken(IntPtr handle, ref Auth.VerifyIdTokenOptionsInternal options, IntPtr clientData, Auth.OnVerifyIdTokenCallbackInternal completionDelegate)
        {
        }

        public static void EOS_Auth_VerifyUserAuth(IntPtr handle, ref Auth.VerifyUserAuthOptionsInternal options, IntPtr clientData, Auth.OnVerifyUserAuthCallbackInternal completionDelegate)
        {
        }

        public static Result EOS_ByteArray_ToString(IntPtr byteArray, uint length, IntPtr outBuffer, ref uint inOutBufferLength)
        {
        }

        public static ulong EOS_Connect_AddNotifyAuthExpiration(IntPtr handle, ref Connect.AddNotifyAuthExpirationOptionsInternal options, IntPtr clientData, Connect.OnAuthExpirationCallbackInternal notification)
        {
        }

        public static ulong EOS_Connect_AddNotifyLoginStatusChanged(IntPtr handle, ref Connect.AddNotifyLoginStatusChangedOptionsInternal options, IntPtr clientData, Connect.OnLoginStatusChangedCallbackInternal notification)
        {
        }

        public static Result EOS_Connect_CopyIdToken(IntPtr handle, ref Connect.CopyIdTokenOptionsInternal options, ref IntPtr outIdToken)
        {
        }

        public static Result EOS_Connect_CopyProductUserExternalAccountByAccountId(IntPtr handle, ref Connect.CopyProductUserExternalAccountByAccountIdOptionsInternal options, ref IntPtr outExternalAccountInfo)
        {
        }

        public static Result EOS_Connect_CopyProductUserExternalAccountByAccountType(IntPtr handle, ref Connect.CopyProductUserExternalAccountByAccountTypeOptionsInternal options, ref IntPtr outExternalAccountInfo)
        {
        }

        public static Result EOS_Connect_CopyProductUserExternalAccountByIndex(IntPtr handle, ref Connect.CopyProductUserExternalAccountByIndexOptionsInternal options, ref IntPtr outExternalAccountInfo)
        {
        }

        public static Result EOS_Connect_CopyProductUserInfo(IntPtr handle, ref Connect.CopyProductUserInfoOptionsInternal options, ref IntPtr outExternalAccountInfo)
        {
        }

        public static void EOS_Connect_CreateDeviceId(IntPtr handle, ref Connect.CreateDeviceIdOptionsInternal options, IntPtr clientData, Connect.OnCreateDeviceIdCallbackInternal completionDelegate)
        {
        }

        public static void EOS_Connect_CreateUser(IntPtr handle, ref Connect.CreateUserOptionsInternal options, IntPtr clientData, Connect.OnCreateUserCallbackInternal completionDelegate)
        {
        }

        public static void EOS_Connect_DeleteDeviceId(IntPtr handle, ref Connect.DeleteDeviceIdOptionsInternal options, IntPtr clientData, Connect.OnDeleteDeviceIdCallbackInternal completionDelegate)
        {
        }

        public static void EOS_Connect_ExternalAccountInfo_Release(IntPtr externalAccountInfo)
        {
        }

        public static IntPtr EOS_Connect_GetExternalAccountMapping(IntPtr handle, ref Connect.GetExternalAccountMappingsOptionsInternal options)
        {
        }

        public static IntPtr EOS_Connect_GetLoggedInUserByIndex(IntPtr handle, int index)
        {
        }

        public static int EOS_Connect_GetLoggedInUsersCount(IntPtr handle)
        {
        }

        public static LoginStatus EOS_Connect_GetLoginStatus(IntPtr handle, IntPtr localUserId)
        {
        }

        public static uint EOS_Connect_GetProductUserExternalAccountCount(IntPtr handle, ref Connect.GetProductUserExternalAccountCountOptionsInternal options)
        {
        }

        public static Result EOS_Connect_GetProductUserIdMapping(IntPtr handle, ref Connect.GetProductUserIdMappingOptionsInternal options, IntPtr outBuffer, ref int inOutBufferLength)
        {
        }

        public static void EOS_Connect_IdToken_Release(IntPtr idToken)
        {
        }

        public static void EOS_Connect_LinkAccount(IntPtr handle, ref Connect.LinkAccountOptionsInternal options, IntPtr clientData, Connect.OnLinkAccountCallbackInternal completionDelegate)
        {
        }

        public static void EOS_Connect_Login(IntPtr handle, ref Connect.LoginOptionsInternal options, IntPtr clientData, Connect.OnLoginCallbackInternal completionDelegate)
        {
        }

        public static void EOS_Connect_QueryExternalAccountMappings(IntPtr handle, ref Connect.QueryExternalAccountMappingsOptionsInternal options, IntPtr clientData, Connect.OnQueryExternalAccountMappingsCallbackInternal completionDelegate)
        {
        }

        public static void EOS_Connect_QueryProductUserIdMappings(IntPtr handle, ref Connect.QueryProductUserIdMappingsOptionsInternal options, IntPtr clientData, Connect.OnQueryProductUserIdMappingsCallbackInternal completionDelegate)
        {
        }

        public static void EOS_Connect_RemoveNotifyAuthExpiration(IntPtr handle, ulong inId)
        {
        }

        public static void EOS_Connect_RemoveNotifyLoginStatusChanged(IntPtr handle, ulong inId)
        {
        }

        public static void EOS_Connect_TransferDeviceIdAccount(IntPtr handle, ref Connect.TransferDeviceIdAccountOptionsInternal options, IntPtr clientData, Connect.OnTransferDeviceIdAccountCallbackInternal completionDelegate)
        {
        }

        public static void EOS_Connect_UnlinkAccount(IntPtr handle, ref Connect.UnlinkAccountOptionsInternal options, IntPtr clientData, Connect.OnUnlinkAccountCallbackInternal completionDelegate)
        {
        }

        public static void EOS_Connect_VerifyIdToken(IntPtr handle, ref Connect.VerifyIdTokenOptionsInternal options, IntPtr clientData, Connect.OnVerifyIdTokenCallbackInternal completionDelegate)
        {
        }

        public static Result EOS_ContinuanceToken_ToString(IntPtr continuanceToken, IntPtr outBuffer, ref int inOutBufferLength)
        {
        }

        public static void EOS_CustomInvites_AcceptRequestToJoin(IntPtr handle, ref CustomInvites.AcceptRequestToJoinOptionsInternal options, IntPtr clientData, CustomInvites.OnAcceptRequestToJoinCallbackInternal completionDelegate)
        {
        }

        public static ulong EOS_CustomInvites_AddNotifyCustomInviteAccepted(IntPtr handle, ref CustomInvites.AddNotifyCustomInviteAcceptedOptionsInternal options, IntPtr clientData, CustomInvites.OnCustomInviteAcceptedCallbackInternal notificationFn)
        {
        }

        public static ulong EOS_CustomInvites_AddNotifyCustomInviteReceived(IntPtr handle, ref CustomInvites.AddNotifyCustomInviteReceivedOptionsInternal options, IntPtr clientData, CustomInvites.OnCustomInviteReceivedCallbackInternal notificationFn)
        {
        }

        public static ulong EOS_CustomInvites_AddNotifyCustomInviteRejected(IntPtr handle, ref CustomInvites.AddNotifyCustomInviteRejectedOptionsInternal options, IntPtr clientData, CustomInvites.OnCustomInviteRejectedCallbackInternal notificationFn)
        {
        }

        public static ulong EOS_CustomInvites_AddNotifyRequestToJoinAccepted(IntPtr handle, ref CustomInvites.AddNotifyRequestToJoinAcceptedOptionsInternal options, IntPtr clientData, CustomInvites.OnRequestToJoinAcceptedCallbackInternal notificationFn)
        {
        }

        public static ulong EOS_CustomInvites_AddNotifyRequestToJoinReceived(IntPtr handle, ref CustomInvites.AddNotifyRequestToJoinReceivedOptionsInternal options, IntPtr clientData, CustomInvites.OnRequestToJoinReceivedCallbackInternal notificationFn)
        {
        }

        public static ulong EOS_CustomInvites_AddNotifyRequestToJoinRejected(IntPtr handle, ref CustomInvites.AddNotifyRequestToJoinRejectedOptionsInternal options, IntPtr clientData, CustomInvites.OnRequestToJoinRejectedCallbackInternal notificationFn)
        {
        }

        public static ulong EOS_CustomInvites_AddNotifyRequestToJoinResponseReceived(IntPtr handle, ref CustomInvites.AddNotifyRequestToJoinResponseReceivedOptionsInternal options, IntPtr clientData, CustomInvites.OnRequestToJoinResponseReceivedCallbackInternal notificationFn)
        {
        }

        public static ulong EOS_CustomInvites_AddNotifySendCustomNativeInviteRequested(IntPtr handle, ref CustomInvites.AddNotifySendCustomNativeInviteRequestedOptionsInternal options, IntPtr clientData, CustomInvites.OnSendCustomNativeInviteRequestedCallbackInternal notificationFn)
        {
        }

        public static Result EOS_CustomInvites_FinalizeInvite(IntPtr handle, ref CustomInvites.FinalizeInviteOptionsInternal options)
        {
        }

        public static void EOS_CustomInvites_RejectRequestToJoin(IntPtr handle, ref CustomInvites.RejectRequestToJoinOptionsInternal options, IntPtr clientData, CustomInvites.OnRejectRequestToJoinCallbackInternal completionDelegate)
        {
        }

        public static void EOS_CustomInvites_RemoveNotifyCustomInviteAccepted(IntPtr handle, ulong inId)
        {
        }

        public static void EOS_CustomInvites_RemoveNotifyCustomInviteReceived(IntPtr handle, ulong inId)
        {
        }

        public static void EOS_CustomInvites_RemoveNotifyCustomInviteRejected(IntPtr handle, ulong inId)
        {
        }

        public static void EOS_CustomInvites_RemoveNotifyRequestToJoinAccepted(IntPtr handle, ulong inId)
        {
        }

        public static void EOS_CustomInvites_RemoveNotifyRequestToJoinReceived(IntPtr handle, ulong inId)
        {
        }

        public static void EOS_CustomInvites_RemoveNotifyRequestToJoinRejected(IntPtr handle, ulong inId)
        {
        }

        public static void EOS_CustomInvites_RemoveNotifyRequestToJoinResponseReceived(IntPtr handle, ulong inId)
        {
        }

        public static void EOS_CustomInvites_RemoveNotifySendCustomNativeInviteRequested(IntPtr handle, ulong inId)
        {
        }

        public static void EOS_CustomInvites_SendCustomInvite(IntPtr handle, ref CustomInvites.SendCustomInviteOptionsInternal options, IntPtr clientData, CustomInvites.OnSendCustomInviteCallbackInternal completionDelegate)
        {
        }

        public static void EOS_CustomInvites_SendRequestToJoin(IntPtr handle, ref CustomInvites.SendRequestToJoinOptionsInternal options, IntPtr clientData, CustomInvites.OnSendRequestToJoinCallbackInternal completionDelegate)
        {
        }

        public static Result EOS_CustomInvites_SetCustomInvite(IntPtr handle, ref CustomInvites.SetCustomInviteOptionsInternal options)
        {
        }

        public static IntPtr EOS_EApplicationStatus_ToString(Platform.ApplicationStatus applicationStatus)
        {
        }

        public static IntPtr EOS_ENetworkStatus_ToString(Platform.NetworkStatus networkStatus)
        {
        }

        public static int EOS_EResult_IsOperationComplete(Result result)
        {
        }

        public static IntPtr EOS_EResult_ToString(Result result)
        {
        }

        public static void EOS_Ecom_CatalogItem_Release(IntPtr catalogItem)
        {
        }

        public static void EOS_Ecom_CatalogOffer_Release(IntPtr catalogOffer)
        {
        }

        public static void EOS_Ecom_CatalogRelease_Release(IntPtr catalogRelease)
        {
        }

        public static void EOS_Ecom_Checkout(IntPtr handle, ref Ecom.CheckoutOptionsInternal options, IntPtr clientData, Ecom.OnCheckoutCallbackInternal completionDelegate)
        {
        }

        public static Result EOS_Ecom_CopyEntitlementById(IntPtr handle, ref Ecom.CopyEntitlementByIdOptionsInternal options, ref IntPtr outEntitlement)
        {
        }

        public static Result EOS_Ecom_CopyEntitlementByIndex(IntPtr handle, ref Ecom.CopyEntitlementByIndexOptionsInternal options, ref IntPtr outEntitlement)
        {
        }

        public static Result EOS_Ecom_CopyEntitlementByNameAndIndex(IntPtr handle, ref Ecom.CopyEntitlementByNameAndIndexOptionsInternal options, ref IntPtr outEntitlement)
        {
        }

        public static Result EOS_Ecom_CopyItemById(IntPtr handle, ref Ecom.CopyItemByIdOptionsInternal options, ref IntPtr outItem)
        {
        }

        public static Result EOS_Ecom_CopyItemImageInfoByIndex(IntPtr handle, ref Ecom.CopyItemImageInfoByIndexOptionsInternal options, ref IntPtr outImageInfo)
        {
        }

        public static Result EOS_Ecom_CopyItemReleaseByIndex(IntPtr handle, ref Ecom.CopyItemReleaseByIndexOptionsInternal options, ref IntPtr outRelease)
        {
        }

        public static Result EOS_Ecom_CopyLastRedeemedEntitlementByIndex(IntPtr handle, ref Ecom.CopyLastRedeemedEntitlementByIndexOptionsInternal options, IntPtr outRedeemedEntitlementId, ref int inOutRedeemedEntitlementIdLength)
        {
        }

        public static Result EOS_Ecom_CopyOfferById(IntPtr handle, ref Ecom.CopyOfferByIdOptionsInternal options, ref IntPtr outOffer)
        {
        }

        public static Result EOS_Ecom_CopyOfferByIndex(IntPtr handle, ref Ecom.CopyOfferByIndexOptionsInternal options, ref IntPtr outOffer)
        {
        }

        public static Result EOS_Ecom_CopyOfferImageInfoByIndex(IntPtr handle, ref Ecom.CopyOfferImageInfoByIndexOptionsInternal options, ref IntPtr outImageInfo)
        {
        }

        public static Result EOS_Ecom_CopyOfferItemByIndex(IntPtr handle, ref Ecom.CopyOfferItemByIndexOptionsInternal options, ref IntPtr outItem)
        {
        }

        public static Result EOS_Ecom_CopyTransactionById(IntPtr handle, ref Ecom.CopyTransactionByIdOptionsInternal options, ref IntPtr outTransaction)
        {
        }

        public static Result EOS_Ecom_CopyTransactionByIndex(IntPtr handle, ref Ecom.CopyTransactionByIndexOptionsInternal options, ref IntPtr outTransaction)
        {
        }

        public static void EOS_Ecom_Entitlement_Release(IntPtr entitlement)
        {
        }

        public static uint EOS_Ecom_GetEntitlementsByNameCount(IntPtr handle, ref Ecom.GetEntitlementsByNameCountOptionsInternal options)
        {
        }

        public static uint EOS_Ecom_GetEntitlementsCount(IntPtr handle, ref Ecom.GetEntitlementsCountOptionsInternal options)
        {
        }

        public static uint EOS_Ecom_GetItemImageInfoCount(IntPtr handle, ref Ecom.GetItemImageInfoCountOptionsInternal options)
        {
        }

        public static uint EOS_Ecom_GetItemReleaseCount(IntPtr handle, ref Ecom.GetItemReleaseCountOptionsInternal options)
        {
        }

        public static uint EOS_Ecom_GetLastRedeemedEntitlementsCount(IntPtr handle, ref Ecom.GetLastRedeemedEntitlementsCountOptionsInternal options)
        {
        }

        public static uint EOS_Ecom_GetOfferCount(IntPtr handle, ref Ecom.GetOfferCountOptionsInternal options)
        {
        }

        public static uint EOS_Ecom_GetOfferImageInfoCount(IntPtr handle, ref Ecom.GetOfferImageInfoCountOptionsInternal options)
        {
        }

        public static uint EOS_Ecom_GetOfferItemCount(IntPtr handle, ref Ecom.GetOfferItemCountOptionsInternal options)
        {
        }

        public static uint EOS_Ecom_GetTransactionCount(IntPtr handle, ref Ecom.GetTransactionCountOptionsInternal options)
        {
        }

        public static void EOS_Ecom_KeyImageInfo_Release(IntPtr keyImageInfo)
        {
        }

        public static void EOS_Ecom_QueryEntitlementToken(IntPtr handle, ref Ecom.QueryEntitlementTokenOptionsInternal options, IntPtr clientData, Ecom.OnQueryEntitlementTokenCallbackInternal completionDelegate)
        {
        }

        public static void EOS_Ecom_QueryEntitlements(IntPtr handle, ref Ecom.QueryEntitlementsOptionsInternal options, IntPtr clientData, Ecom.OnQueryEntitlementsCallbackInternal completionDelegate)
        {
        }

        public static void EOS_Ecom_QueryOffers(IntPtr handle, ref Ecom.QueryOffersOptionsInternal options, IntPtr clientData, Ecom.OnQueryOffersCallbackInternal completionDelegate)
        {
        }

        public static void EOS_Ecom_QueryOwnership(IntPtr handle, ref Ecom.QueryOwnershipOptionsInternal options, IntPtr clientData, Ecom.OnQueryOwnershipCallbackInternal completionDelegate)
        {
        }

        public static void EOS_Ecom_QueryOwnershipBySandboxIds(IntPtr handle, ref Ecom.QueryOwnershipBySandboxIdsOptionsInternal options, IntPtr clientData, Ecom.OnQueryOwnershipBySandboxIdsCallbackInternal completionDelegate)
        {
        }

        public static void EOS_Ecom_QueryOwnershipToken(IntPtr handle, ref Ecom.QueryOwnershipTokenOptionsInternal options, IntPtr clientData, Ecom.OnQueryOwnershipTokenCallbackInternal completionDelegate)
        {
        }

        public static void EOS_Ecom_RedeemEntitlements(IntPtr handle, ref Ecom.RedeemEntitlementsOptionsInternal options, IntPtr clientData, Ecom.OnRedeemEntitlementsCallbackInternal completionDelegate)
        {
        }

        public static Result EOS_Ecom_Transaction_CopyEntitlementByIndex(IntPtr handle, ref Ecom.TransactionCopyEntitlementByIndexOptionsInternal options, ref IntPtr outEntitlement)
        {
        }

        public static uint EOS_Ecom_Transaction_GetEntitlementsCount(IntPtr handle, ref Ecom.TransactionGetEntitlementsCountOptionsInternal options)
        {
        }

        public static Result EOS_Ecom_Transaction_GetTransactionId(IntPtr handle, IntPtr outBuffer, ref int inOutBufferLength)
        {
        }

        public static void EOS_Ecom_Transaction_Release(IntPtr transaction)
        {
        }

        public static IntPtr EOS_EpicAccountId_FromString(IntPtr accountIdString)
        {
        }

        public static int EOS_EpicAccountId_IsValid(IntPtr accountId)
        {
        }

        public static Result EOS_EpicAccountId_ToString(IntPtr accountId, IntPtr outBuffer, ref int inOutBufferLength)
        {
        }

        public static void EOS_Friends_AcceptInvite(IntPtr handle, ref Friends.AcceptInviteOptionsInternal options, IntPtr clientData, Friends.OnAcceptInviteCallbackInternal completionDelegate)
        {
        }

        public static ulong EOS_Friends_AddNotifyBlockedUsersUpdate(IntPtr handle, ref Friends.AddNotifyBlockedUsersUpdateOptionsInternal options, IntPtr clientData, Friends.OnBlockedUsersUpdateCallbackInternal blockedUsersUpdateHandler)
        {
        }

        public static ulong EOS_Friends_AddNotifyFriendsUpdate(IntPtr handle, ref Friends.AddNotifyFriendsUpdateOptionsInternal options, IntPtr clientData, Friends.OnFriendsUpdateCallbackInternal friendsUpdateHandler)
        {
        }

        public static IntPtr EOS_Friends_GetBlockedUserAtIndex(IntPtr handle, ref Friends.GetBlockedUserAtIndexOptionsInternal options)
        {
        }

        public static int EOS_Friends_GetBlockedUsersCount(IntPtr handle, ref Friends.GetBlockedUsersCountOptionsInternal options)
        {
        }

        public static IntPtr EOS_Friends_GetFriendAtIndex(IntPtr handle, ref Friends.GetFriendAtIndexOptionsInternal options)
        {
        }

        public static int EOS_Friends_GetFriendsCount(IntPtr handle, ref Friends.GetFriendsCountOptionsInternal options)
        {
        }

        public static Friends.FriendsStatus EOS_Friends_GetStatus(IntPtr handle, ref Friends.GetStatusOptionsInternal options)
        {
        }

        public static void EOS_Friends_QueryFriends(IntPtr handle, ref Friends.QueryFriendsOptionsInternal options, IntPtr clientData, Friends.OnQueryFriendsCallbackInternal completionDelegate)
        {
        }

        public static void EOS_Friends_RejectInvite(IntPtr handle, ref Friends.RejectInviteOptionsInternal options, IntPtr clientData, Friends.OnRejectInviteCallbackInternal completionDelegate)
        {
        }

        public static void EOS_Friends_RemoveNotifyBlockedUsersUpdate(IntPtr handle, ulong notificationId)
        {
        }

        public static void EOS_Friends_RemoveNotifyFriendsUpdate(IntPtr handle, ulong notificationId)
        {
        }

        public static void EOS_Friends_SendInvite(IntPtr handle, ref Friends.SendInviteOptionsInternal options, IntPtr clientData, Friends.OnSendInviteCallbackInternal completionDelegate)
        {
        }

        public static IntPtr EOS_GetVersion()
        {
        }

        public static Result EOS_Initialize(ref Platform.InitializeOptionsInternal options)
        {
        }

        public static Result EOS_IntegratedPlatformOptionsContainer_Add(IntPtr handle, ref IntegratedPlatform.IntegratedPlatformOptionsContainerAddOptionsInternal inOptions)
        {
        }

        public static void EOS_IntegratedPlatformOptionsContainer_Release(IntPtr integratedPlatformOptionsContainerHandle)
        {
        }

        public static ulong EOS_IntegratedPlatform_AddNotifyUserLoginStatusChanged(IntPtr handle, ref IntegratedPlatform.AddNotifyUserLoginStatusChangedOptionsInternal options, IntPtr clientData, IntegratedPlatform.OnUserLoginStatusChangedCallbackInternal callbackFunction)
        {
        }

        public static void EOS_IntegratedPlatform_ClearUserPreLogoutCallback(IntPtr handle, ref IntegratedPlatform.ClearUserPreLogoutCallbackOptionsInternal options)
        {
        }

        public static Result EOS_IntegratedPlatform_CreateIntegratedPlatformOptionsContainer(ref IntegratedPlatform.CreateIntegratedPlatformOptionsContainerOptionsInternal options, ref IntPtr outIntegratedPlatformOptionsContainerHandle)
        {
        }

        public static Result EOS_IntegratedPlatform_FinalizeDeferredUserLogout(IntPtr handle, ref IntegratedPlatform.FinalizeDeferredUserLogoutOptionsInternal options)
        {
        }

        public static void EOS_IntegratedPlatform_RemoveNotifyUserLoginStatusChanged(IntPtr handle, ulong notificationId)
        {
        }

        public static Result EOS_IntegratedPlatform_SetUserLoginStatus(IntPtr handle, ref IntegratedPlatform.SetUserLoginStatusOptionsInternal options)
        {
        }

        public static Result EOS_IntegratedPlatform_SetUserPreLogoutCallback(IntPtr handle, ref IntegratedPlatform.SetUserPreLogoutCallbackOptionsInternal options, IntPtr clientData, IntegratedPlatform.OnUserPreLogoutCallbackInternal callbackFunction)
        {
        }

        public static ulong EOS_KWS_AddNotifyPermissionsUpdateReceived(IntPtr handle, ref KWS.AddNotifyPermissionsUpdateReceivedOptionsInternal options, IntPtr clientData, KWS.OnPermissionsUpdateReceivedCallbackInternal notificationFn)
        {
        }

        public static Result EOS_KWS_CopyPermissionByIndex(IntPtr handle, ref KWS.CopyPermissionByIndexOptionsInternal options, ref IntPtr outPermission)
        {
        }

        public static void EOS_KWS_CreateUser(IntPtr handle, ref KWS.CreateUserOptionsInternal options, IntPtr clientData, KWS.OnCreateUserCallbackInternal completionDelegate)
        {
        }

        public static Result EOS_KWS_GetPermissionByKey(IntPtr handle, ref KWS.GetPermissionByKeyOptionsInternal options, ref KWS.KWSPermissionStatus outPermission)
        {
        }

        public static int EOS_KWS_GetPermissionsCount(IntPtr handle, ref KWS.GetPermissionsCountOptionsInternal options)
        {
        }

        public static void EOS_KWS_PermissionStatus_Release(IntPtr permissionStatus)
        {
        }

        public static void EOS_KWS_QueryAgeGate(IntPtr handle, ref KWS.QueryAgeGateOptionsInternal options, IntPtr clientData, KWS.OnQueryAgeGateCallbackInternal completionDelegate)
        {
        }

        public static void EOS_KWS_QueryPermissions(IntPtr handle, ref KWS.QueryPermissionsOptionsInternal options, IntPtr clientData, KWS.OnQueryPermissionsCallbackInternal completionDelegate)
        {
        }

        public static void EOS_KWS_RemoveNotifyPermissionsUpdateReceived(IntPtr handle, ulong inId)
        {
        }

        public static void EOS_KWS_RequestPermissions(IntPtr handle, ref KWS.RequestPermissionsOptionsInternal options, IntPtr clientData, KWS.OnRequestPermissionsCallbackInternal completionDelegate)
        {
        }

        public static void EOS_KWS_UpdateParentEmail(IntPtr handle, ref KWS.UpdateParentEmailOptionsInternal options, IntPtr clientData, KWS.OnUpdateParentEmailCallbackInternal completionDelegate)
        {
        }

        public static Result EOS_Leaderboards_CopyLeaderboardDefinitionByIndex(IntPtr handle, ref Leaderboards.CopyLeaderboardDefinitionByIndexOptionsInternal options, ref IntPtr outLeaderboardDefinition)
        {
        }

        public static Result EOS_Leaderboards_CopyLeaderboardDefinitionByLeaderboardId(IntPtr handle, ref Leaderboards.CopyLeaderboardDefinitionByLeaderboardIdOptionsInternal options, ref IntPtr outLeaderboardDefinition)
        {
        }

        public static Result EOS_Leaderboards_CopyLeaderboardRecordByIndex(IntPtr handle, ref Leaderboards.CopyLeaderboardRecordByIndexOptionsInternal options, ref IntPtr outLeaderboardRecord)
        {
        }

        public static Result EOS_Leaderboards_CopyLeaderboardRecordByUserId(IntPtr handle, ref Leaderboards.CopyLeaderboardRecordByUserIdOptionsInternal options, ref IntPtr outLeaderboardRecord)
        {
        }

        public static Result EOS_Leaderboards_CopyLeaderboardUserScoreByIndex(IntPtr handle, ref Leaderboards.CopyLeaderboardUserScoreByIndexOptionsInternal options, ref IntPtr outLeaderboardUserScore)
        {
        }

        public static Result EOS_Leaderboards_CopyLeaderboardUserScoreByUserId(IntPtr handle, ref Leaderboards.CopyLeaderboardUserScoreByUserIdOptionsInternal options, ref IntPtr outLeaderboardUserScore)
        {
        }

        public static void EOS_Leaderboards_Definition_Release(IntPtr leaderboardDefinition)
        {
        }

        public static uint EOS_Leaderboards_GetLeaderboardDefinitionCount(IntPtr handle, ref Leaderboards.GetLeaderboardDefinitionCountOptionsInternal options)
        {
        }

        public static uint EOS_Leaderboards_GetLeaderboardRecordCount(IntPtr handle, ref Leaderboards.GetLeaderboardRecordCountOptionsInternal options)
        {
        }

        public static uint EOS_Leaderboards_GetLeaderboardUserScoreCount(IntPtr handle, ref Leaderboards.GetLeaderboardUserScoreCountOptionsInternal options)
        {
        }

        public static void EOS_Leaderboards_LeaderboardDefinition_Release(IntPtr leaderboardDefinition)
        {
        }

        public static void EOS_Leaderboards_LeaderboardRecord_Release(IntPtr leaderboardRecord)
        {
        }

        public static void EOS_Leaderboards_LeaderboardUserScore_Release(IntPtr leaderboardUserScore)
        {
        }

        public static void EOS_Leaderboards_QueryLeaderboardDefinitions(IntPtr handle, ref Leaderboards.QueryLeaderboardDefinitionsOptionsInternal options, IntPtr clientData, Leaderboards.OnQueryLeaderboardDefinitionsCompleteCallbackInternal completionDelegate)
        {
        }

        public static void EOS_Leaderboards_QueryLeaderboardRanks(IntPtr handle, ref Leaderboards.QueryLeaderboardRanksOptionsInternal options, IntPtr clientData, Leaderboards.OnQueryLeaderboardRanksCompleteCallbackInternal completionDelegate)
        {
        }

        public static void EOS_Leaderboards_QueryLeaderboardUserScores(IntPtr handle, ref Leaderboards.QueryLeaderboardUserScoresOptionsInternal options, IntPtr clientData, Leaderboards.OnQueryLeaderboardUserScoresCompleteCallbackInternal completionDelegate)
        {
        }

        public static Result EOS_LobbyDetails_CopyAttributeByIndex(IntPtr handle, ref Lobby.LobbyDetailsCopyAttributeByIndexOptionsInternal options, ref IntPtr outAttribute)
        {
        }

        public static Result EOS_LobbyDetails_CopyAttributeByKey(IntPtr handle, ref Lobby.LobbyDetailsCopyAttributeByKeyOptionsInternal options, ref IntPtr outAttribute)
        {
        }

        public static Result EOS_LobbyDetails_CopyInfo(IntPtr handle, ref Lobby.LobbyDetailsCopyInfoOptionsInternal options, ref IntPtr outLobbyDetailsInfo)
        {
        }

        public static Result EOS_LobbyDetails_CopyMemberAttributeByIndex(IntPtr handle, ref Lobby.LobbyDetailsCopyMemberAttributeByIndexOptionsInternal options, ref IntPtr outAttribute)
        {
        }

        public static Result EOS_LobbyDetails_CopyMemberAttributeByKey(IntPtr handle, ref Lobby.LobbyDetailsCopyMemberAttributeByKeyOptionsInternal options, ref IntPtr outAttribute)
        {
        }

        public static Result EOS_LobbyDetails_CopyMemberInfo(IntPtr handle, ref Lobby.LobbyDetailsCopyMemberInfoOptionsInternal options, ref IntPtr outLobbyDetailsMemberInfo)
        {
        }

        public static uint EOS_LobbyDetails_GetAttributeCount(IntPtr handle, ref Lobby.LobbyDetailsGetAttributeCountOptionsInternal options)
        {
        }

        public static IntPtr EOS_LobbyDetails_GetLobbyOwner(IntPtr handle, ref Lobby.LobbyDetailsGetLobbyOwnerOptionsInternal options)
        {
        }

        public static uint EOS_LobbyDetails_GetMemberAttributeCount(IntPtr handle, ref Lobby.LobbyDetailsGetMemberAttributeCountOptionsInternal options)
        {
        }

        public static IntPtr EOS_LobbyDetails_GetMemberByIndex(IntPtr handle, ref Lobby.LobbyDetailsGetMemberByIndexOptionsInternal options)
        {
        }

        public static uint EOS_LobbyDetails_GetMemberCount(IntPtr handle, ref Lobby.LobbyDetailsGetMemberCountOptionsInternal options)
        {
        }

        public static void EOS_LobbyDetails_Info_Release(IntPtr lobbyDetailsInfo)
        {
        }

        public static void EOS_LobbyDetails_MemberInfo_Release(IntPtr lobbyDetailsMemberInfo)
        {
        }

        public static void EOS_LobbyDetails_Release(IntPtr lobbyHandle)
        {
        }

        public static Result EOS_LobbyModification_AddAttribute(IntPtr handle, ref Lobby.LobbyModificationAddAttributeOptionsInternal options)
        {
        }

        public static Result EOS_LobbyModification_AddMemberAttribute(IntPtr handle, ref Lobby.LobbyModificationAddMemberAttributeOptionsInternal options)
        {
        }

        public static void EOS_LobbyModification_Release(IntPtr lobbyModificationHandle)
        {
        }

        public static Result EOS_LobbyModification_RemoveAttribute(IntPtr handle, ref Lobby.LobbyModificationRemoveAttributeOptionsInternal options)
        {
        }

        public static Result EOS_LobbyModification_RemoveMemberAttribute(IntPtr handle, ref Lobby.LobbyModificationRemoveMemberAttributeOptionsInternal options)
        {
        }

        public static Result EOS_LobbyModification_SetAllowedPlatformIds(IntPtr handle, ref Lobby.LobbyModificationSetAllowedPlatformIdsOptionsInternal options)
        {
        }

        public static Result EOS_LobbyModification_SetBucketId(IntPtr handle, ref Lobby.LobbyModificationSetBucketIdOptionsInternal options)
        {
        }

        public static Result EOS_LobbyModification_SetInvitesAllowed(IntPtr handle, ref Lobby.LobbyModificationSetInvitesAllowedOptionsInternal options)
        {
        }

        public static Result EOS_LobbyModification_SetMaxMembers(IntPtr handle, ref Lobby.LobbyModificationSetMaxMembersOptionsInternal options)
        {
        }

        public static Result EOS_LobbyModification_SetPermissionLevel(IntPtr handle, ref Lobby.LobbyModificationSetPermissionLevelOptionsInternal options)
        {
        }

        public static Result EOS_LobbySearch_CopySearchResultByIndex(IntPtr handle, ref Lobby.LobbySearchCopySearchResultByIndexOptionsInternal options, ref IntPtr outLobbyDetailsHandle)
        {
        }

        public static void EOS_LobbySearch_Find(IntPtr handle, ref Lobby.LobbySearchFindOptionsInternal options, IntPtr clientData, Lobby.LobbySearchOnFindCallbackInternal completionDelegate)
        {
        }

        public static uint EOS_LobbySearch_GetSearchResultCount(IntPtr handle, ref Lobby.LobbySearchGetSearchResultCountOptionsInternal options)
        {
        }

        public static void EOS_LobbySearch_Release(IntPtr lobbySearchHandle)
        {
        }

        public static Result EOS_LobbySearch_RemoveParameter(IntPtr handle, ref Lobby.LobbySearchRemoveParameterOptionsInternal options)
        {
        }

        public static Result EOS_LobbySearch_SetLobbyId(IntPtr handle, ref Lobby.LobbySearchSetLobbyIdOptionsInternal options)
        {
        }

        public static Result EOS_LobbySearch_SetMaxResults(IntPtr handle, ref Lobby.LobbySearchSetMaxResultsOptionsInternal options)
        {
        }

        public static Result EOS_LobbySearch_SetParameter(IntPtr handle, ref Lobby.LobbySearchSetParameterOptionsInternal options)
        {
        }

        public static Result EOS_LobbySearch_SetTargetUserId(IntPtr handle, ref Lobby.LobbySearchSetTargetUserIdOptionsInternal options)
        {
        }

        public static ulong EOS_Lobby_AddNotifyJoinLobbyAccepted(IntPtr handle, ref Lobby.AddNotifyJoinLobbyAcceptedOptionsInternal options, IntPtr clientData, Lobby.OnJoinLobbyAcceptedCallbackInternal notificationFn)
        {
        }

        public static ulong EOS_Lobby_AddNotifyLeaveLobbyRequested(IntPtr handle, ref Lobby.AddNotifyLeaveLobbyRequestedOptionsInternal options, IntPtr clientData, Lobby.OnLeaveLobbyRequestedCallbackInternal notificationFn)
        {
        }

        public static ulong EOS_Lobby_AddNotifyLobbyInviteAccepted(IntPtr handle, ref Lobby.AddNotifyLobbyInviteAcceptedOptionsInternal options, IntPtr clientData, Lobby.OnLobbyInviteAcceptedCallbackInternal notificationFn)
        {
        }

        public static ulong EOS_Lobby_AddNotifyLobbyInviteReceived(IntPtr handle, ref Lobby.AddNotifyLobbyInviteReceivedOptionsInternal options, IntPtr clientData, Lobby.OnLobbyInviteReceivedCallbackInternal notificationFn)
        {
        }

        public static ulong EOS_Lobby_AddNotifyLobbyInviteRejected(IntPtr handle, ref Lobby.AddNotifyLobbyInviteRejectedOptionsInternal options, IntPtr clientData, Lobby.OnLobbyInviteRejectedCallbackInternal notificationFn)
        {
        }

        public static ulong EOS_Lobby_AddNotifyLobbyMemberStatusReceived(IntPtr handle, ref Lobby.AddNotifyLobbyMemberStatusReceivedOptionsInternal options, IntPtr clientData, Lobby.OnLobbyMemberStatusReceivedCallbackInternal notificationFn)
        {
        }

        public static ulong EOS_Lobby_AddNotifyLobbyMemberUpdateReceived(IntPtr handle, ref Lobby.AddNotifyLobbyMemberUpdateReceivedOptionsInternal options, IntPtr clientData, Lobby.OnLobbyMemberUpdateReceivedCallbackInternal notificationFn)
        {
        }

        public static ulong EOS_Lobby_AddNotifyLobbyUpdateReceived(IntPtr handle, ref Lobby.AddNotifyLobbyUpdateReceivedOptionsInternal options, IntPtr clientData, Lobby.OnLobbyUpdateReceivedCallbackInternal notificationFn)
        {
        }

        public static ulong EOS_Lobby_AddNotifyRTCRoomConnectionChanged(IntPtr handle, ref Lobby.AddNotifyRTCRoomConnectionChangedOptionsInternal options, IntPtr clientData, Lobby.OnRTCRoomConnectionChangedCallbackInternal notificationFn)
        {
        }

        public static ulong EOS_Lobby_AddNotifySendLobbyNativeInviteRequested(IntPtr handle, ref Lobby.AddNotifySendLobbyNativeInviteRequestedOptionsInternal options, IntPtr clientData, Lobby.OnSendLobbyNativeInviteRequestedCallbackInternal notificationFn)
        {
        }

        public static void EOS_Lobby_Attribute_Release(IntPtr lobbyAttribute)
        {
        }

        public static Result EOS_Lobby_CopyLobbyDetailsHandle(IntPtr handle, ref Lobby.CopyLobbyDetailsHandleOptionsInternal options, ref IntPtr outLobbyDetailsHandle)
        {
        }

        public static Result EOS_Lobby_CopyLobbyDetailsHandleByInviteId(IntPtr handle, ref Lobby.CopyLobbyDetailsHandleByInviteIdOptionsInternal options, ref IntPtr outLobbyDetailsHandle)
        {
        }

        public static Result EOS_Lobby_CopyLobbyDetailsHandleByUiEventId(IntPtr handle, ref Lobby.CopyLobbyDetailsHandleByUiEventIdOptionsInternal options, ref IntPtr outLobbyDetailsHandle)
        {
        }

        public static void EOS_Lobby_CreateLobby(IntPtr handle, ref Lobby.CreateLobbyOptionsInternal options, IntPtr clientData, Lobby.OnCreateLobbyCallbackInternal completionDelegate)
        {
        }

        public static Result EOS_Lobby_CreateLobbySearch(IntPtr handle, ref Lobby.CreateLobbySearchOptionsInternal options, ref IntPtr outLobbySearchHandle)
        {
        }

        public static void EOS_Lobby_DestroyLobby(IntPtr handle, ref Lobby.DestroyLobbyOptionsInternal options, IntPtr clientData, Lobby.OnDestroyLobbyCallbackInternal completionDelegate)
        {
        }

        public static Result EOS_Lobby_GetConnectString(IntPtr handle, ref Lobby.GetConnectStringOptionsInternal options, IntPtr outBuffer, ref uint inOutBufferLength)
        {
        }

        public static uint EOS_Lobby_GetInviteCount(IntPtr handle, ref Lobby.GetInviteCountOptionsInternal options)
        {
        }

        public static Result EOS_Lobby_GetInviteIdByIndex(IntPtr handle, ref Lobby.GetInviteIdByIndexOptionsInternal options, IntPtr outBuffer, ref int inOutBufferLength)
        {
        }

        public static Result EOS_Lobby_GetRTCRoomName(IntPtr handle, ref Lobby.GetRTCRoomNameOptionsInternal options, IntPtr outBuffer, ref uint inOutBufferLength)
        {
        }

        public static void EOS_Lobby_HardMuteMember(IntPtr handle, ref Lobby.HardMuteMemberOptionsInternal options, IntPtr clientData, Lobby.OnHardMuteMemberCallbackInternal completionDelegate)
        {
        }

        public static Result EOS_Lobby_IsRTCRoomConnected(IntPtr handle, ref Lobby.IsRTCRoomConnectedOptionsInternal options, ref int bOutIsConnected)
        {
        }

        public static void EOS_Lobby_JoinLobby(IntPtr handle, ref Lobby.JoinLobbyOptionsInternal options, IntPtr clientData, Lobby.OnJoinLobbyCallbackInternal completionDelegate)
        {
        }

        public static void EOS_Lobby_JoinLobbyById(IntPtr handle, ref Lobby.JoinLobbyByIdOptionsInternal options, IntPtr clientData, Lobby.OnJoinLobbyByIdCallbackInternal completionDelegate)
        {
        }

        public static void EOS_Lobby_KickMember(IntPtr handle, ref Lobby.KickMemberOptionsInternal options, IntPtr clientData, Lobby.OnKickMemberCallbackInternal completionDelegate)
        {
        }

        public static void EOS_Lobby_LeaveLobby(IntPtr handle, ref Lobby.LeaveLobbyOptionsInternal options, IntPtr clientData, Lobby.OnLeaveLobbyCallbackInternal completionDelegate)
        {
        }

        public static Result EOS_Lobby_ParseConnectString(IntPtr handle, ref Lobby.ParseConnectStringOptionsInternal options, IntPtr outBuffer, ref uint inOutBufferLength)
        {
        }

        public static void EOS_Lobby_PromoteMember(IntPtr handle, ref Lobby.PromoteMemberOptionsInternal options, IntPtr clientData, Lobby.OnPromoteMemberCallbackInternal completionDelegate)
        {
        }

        public static void EOS_Lobby_QueryInvites(IntPtr handle, ref Lobby.QueryInvitesOptionsInternal options, IntPtr clientData, Lobby.OnQueryInvitesCallbackInternal completionDelegate)
        {
        }

        public static void EOS_Lobby_RejectInvite(IntPtr handle, ref Lobby.RejectInviteOptionsInternal options, IntPtr clientData, Lobby.OnRejectInviteCallbackInternal completionDelegate)
        {
        }

        public static void EOS_Lobby_RemoveNotifyJoinLobbyAccepted(IntPtr handle, ulong inId)
        {
        }

        public static void EOS_Lobby_RemoveNotifyLeaveLobbyRequested(IntPtr handle, ulong inId)
        {
        }

        public static void EOS_Lobby_RemoveNotifyLobbyInviteAccepted(IntPtr handle, ulong inId)
        {
        }

        public static void EOS_Lobby_RemoveNotifyLobbyInviteReceived(IntPtr handle, ulong inId)
        {
        }

        public static void EOS_Lobby_RemoveNotifyLobbyInviteRejected(IntPtr handle, ulong inId)
        {
        }

        public static void EOS_Lobby_RemoveNotifyLobbyMemberStatusReceived(IntPtr handle, ulong inId)
        {
        }

        public static void EOS_Lobby_RemoveNotifyLobbyMemberUpdateReceived(IntPtr handle, ulong inId)
        {
        }

        public static void EOS_Lobby_RemoveNotifyLobbyUpdateReceived(IntPtr handle, ulong inId)
        {
        }

        public static void EOS_Lobby_RemoveNotifyRTCRoomConnectionChanged(IntPtr handle, ulong inId)
        {
        }

        public static void EOS_Lobby_RemoveNotifySendLobbyNativeInviteRequested(IntPtr handle, ulong inId)
        {
        }

        public static void EOS_Lobby_SendInvite(IntPtr handle, ref Lobby.SendInviteOptionsInternal options, IntPtr clientData, Lobby.OnSendInviteCallbackInternal completionDelegate)
        {
        }

        public static void EOS_Lobby_UpdateLobby(IntPtr handle, ref Lobby.UpdateLobbyOptionsInternal options, IntPtr clientData, Lobby.OnUpdateLobbyCallbackInternal completionDelegate)
        {
        }

        public static Result EOS_Lobby_UpdateLobbyModification(IntPtr handle, ref Lobby.UpdateLobbyModificationOptionsInternal options, ref IntPtr outLobbyModificationHandle)
        {
        }

        public static Result EOS_Logging_SetCallback(Logging.LogMessageFuncInternal callback)
        {
        }

        public static Result EOS_Logging_SetLogLevel(Logging.LogCategory logCategory, Logging.LogLevel logLevel)
        {
        }

        public static Result EOS_Metrics_BeginPlayerSession(IntPtr handle, ref Metrics.BeginPlayerSessionOptionsInternal options)
        {
        }

        public static Result EOS_Metrics_EndPlayerSession(IntPtr handle, ref Metrics.EndPlayerSessionOptionsInternal options)
        {
        }

        public static Result EOS_Mods_CopyModInfo(IntPtr handle, ref Mods.CopyModInfoOptionsInternal options, ref IntPtr outEnumeratedMods)
        {
        }

        public static void EOS_Mods_EnumerateMods(IntPtr handle, ref Mods.EnumerateModsOptionsInternal options, IntPtr clientData, Mods.OnEnumerateModsCallbackInternal completionDelegate)
        {
        }

        public static void EOS_Mods_InstallMod(IntPtr handle, ref Mods.InstallModOptionsInternal options, IntPtr clientData, Mods.OnInstallModCallbackInternal completionDelegate)
        {
        }

        public static void EOS_Mods_ModInfo_Release(IntPtr modInfo)
        {
        }

        public static void EOS_Mods_UninstallMod(IntPtr handle, ref Mods.UninstallModOptionsInternal options, IntPtr clientData, Mods.OnUninstallModCallbackInternal completionDelegate)
        {
        }

        public static void EOS_Mods_UpdateMod(IntPtr handle, ref Mods.UpdateModOptionsInternal options, IntPtr clientData, Mods.OnUpdateModCallbackInternal completionDelegate)
        {
        }

        public static Result EOS_P2P_AcceptConnection(IntPtr handle, ref P2P.AcceptConnectionOptionsInternal options)
        {
        }

        public static ulong EOS_P2P_AddNotifyIncomingPacketQueueFull(IntPtr handle, ref P2P.AddNotifyIncomingPacketQueueFullOptionsInternal options, IntPtr clientData, P2P.OnIncomingPacketQueueFullCallbackInternal incomingPacketQueueFullHandler)
        {
        }

        public static ulong EOS_P2P_AddNotifyPeerConnectionClosed(IntPtr handle, ref P2P.AddNotifyPeerConnectionClosedOptionsInternal options, IntPtr clientData, P2P.OnRemoteConnectionClosedCallbackInternal connectionClosedHandler)
        {
        }

        public static ulong EOS_P2P_AddNotifyPeerConnectionEstablished(IntPtr handle, ref P2P.AddNotifyPeerConnectionEstablishedOptionsInternal options, IntPtr clientData, P2P.OnPeerConnectionEstablishedCallbackInternal connectionEstablishedHandler)
        {
        }

        public static ulong EOS_P2P_AddNotifyPeerConnectionInterrupted(IntPtr handle, ref P2P.AddNotifyPeerConnectionInterruptedOptionsInternal options, IntPtr clientData, P2P.OnPeerConnectionInterruptedCallbackInternal connectionInterruptedHandler)
        {
        }

        public static ulong EOS_P2P_AddNotifyPeerConnectionRequest(IntPtr handle, ref P2P.AddNotifyPeerConnectionRequestOptionsInternal options, IntPtr clientData, P2P.OnIncomingConnectionRequestCallbackInternal connectionRequestHandler)
        {
        }

        public static Result EOS_P2P_ClearPacketQueue(IntPtr handle, ref P2P.ClearPacketQueueOptionsInternal options)
        {
        }

        public static Result EOS_P2P_CloseConnection(IntPtr handle, ref P2P.CloseConnectionOptionsInternal options)
        {
        }

        public static Result EOS_P2P_CloseConnections(IntPtr handle, ref P2P.CloseConnectionsOptionsInternal options)
        {
        }

        public static Result EOS_P2P_GetNATType(IntPtr handle, ref P2P.GetNATTypeOptionsInternal options, ref P2P.NATType outNATType)
        {
        }

        public static Result EOS_P2P_GetNextReceivedPacketSize(IntPtr handle, ref P2P.GetNextReceivedPacketSizeOptionsInternal options, ref uint outPacketSizeBytes)
        {
        }

        public static Result EOS_P2P_GetPacketQueueInfo(IntPtr handle, ref P2P.GetPacketQueueInfoOptionsInternal options, ref P2P.PacketQueueInfoInternal outPacketQueueInfo)
        {
        }

        public static Result EOS_P2P_GetPortRange(IntPtr handle, ref P2P.GetPortRangeOptionsInternal options, ref ushort outPort, ref ushort outNumAdditionalPortsToTry)
        {
        }

        public static Result EOS_P2P_GetRelayControl(IntPtr handle, ref P2P.GetRelayControlOptionsInternal options, ref P2P.RelayControl outRelayControl)
        {
        }

        public static void EOS_P2P_QueryNATType(IntPtr handle, ref P2P.QueryNATTypeOptionsInternal options, IntPtr clientData, P2P.OnQueryNATTypeCompleteCallbackInternal completionDelegate)
        {
        }

        public static Result EOS_P2P_ReceivePacket(IntPtr handle, ref P2P.ReceivePacketOptionsInternal options, ref IntPtr outPeerId, ref P2P.SocketIdInternal outSocketId, ref byte outChannel, IntPtr outData, ref uint outBytesWritten)
        {
        }

        public static void EOS_P2P_RemoveNotifyIncomingPacketQueueFull(IntPtr handle, ulong notificationId)
        {
        }

        public static void EOS_P2P_RemoveNotifyPeerConnectionClosed(IntPtr handle, ulong notificationId)
        {
        }

        public static void EOS_P2P_RemoveNotifyPeerConnectionEstablished(IntPtr handle, ulong notificationId)
        {
        }

        public static void EOS_P2P_RemoveNotifyPeerConnectionInterrupted(IntPtr handle, ulong notificationId)
        {
        }

        public static void EOS_P2P_RemoveNotifyPeerConnectionRequest(IntPtr handle, ulong notificationId)
        {
        }

        public static Result EOS_P2P_SendPacket(IntPtr handle, ref P2P.SendPacketOptionsInternal options)
        {
        }

        public static Result EOS_P2P_SetPacketQueueSize(IntPtr handle, ref P2P.SetPacketQueueSizeOptionsInternal options)
        {
        }

        public static Result EOS_P2P_SetPortRange(IntPtr handle, ref P2P.SetPortRangeOptionsInternal options)
        {
        }

        public static Result EOS_P2P_SetRelayControl(IntPtr handle, ref P2P.SetRelayControlOptionsInternal options)
        {
        }

        public static Result EOS_Platform_CheckForLauncherAndRestart(IntPtr handle)
        {
        }

        public static IntPtr EOS_Platform_Create(ref Platform.OptionsInternal options)
        {
        }

        public static IntPtr EOS_Platform_GetAchievementsInterface(IntPtr handle)
        {
        }

        public static Result EOS_Platform_GetActiveCountryCode(IntPtr handle, IntPtr localUserId, IntPtr outBuffer, ref int inOutBufferLength)
        {
        }

        public static Result EOS_Platform_GetActiveLocaleCode(IntPtr handle, IntPtr localUserId, IntPtr outBuffer, ref int inOutBufferLength)
        {
        }

        public static IntPtr EOS_Platform_GetAntiCheatClientInterface(IntPtr handle)
        {
        }

        public static IntPtr EOS_Platform_GetAntiCheatServerInterface(IntPtr handle)
        {
        }

        public static Platform.ApplicationStatus EOS_Platform_GetApplicationStatus(IntPtr handle)
        {
        }

        public static IntPtr EOS_Platform_GetAuthInterface(IntPtr handle)
        {
        }

        public static IntPtr EOS_Platform_GetConnectInterface(IntPtr handle)
        {
        }

        public static IntPtr EOS_Platform_GetCustomInvitesInterface(IntPtr handle)
        {
        }

        public static Result EOS_Platform_GetDesktopCrossplayStatus(IntPtr handle, ref Platform.GetDesktopCrossplayStatusOptionsInternal options, ref Platform.DesktopCrossplayStatusInfoInternal outDesktopCrossplayStatusInfo)
        {
        }

        public static IntPtr EOS_Platform_GetEcomInterface(IntPtr handle)
        {
        }

        public static IntPtr EOS_Platform_GetFriendsInterface(IntPtr handle)
        {
        }

        public static IntPtr EOS_Platform_GetIntegratedPlatformInterface(IntPtr handle)
        {
        }

        public static IntPtr EOS_Platform_GetKWSInterface(IntPtr handle)
        {
        }

        public static IntPtr EOS_Platform_GetLeaderboardsInterface(IntPtr handle)
        {
        }

        public static IntPtr EOS_Platform_GetLobbyInterface(IntPtr handle)
        {
        }

        public static IntPtr EOS_Platform_GetMetricsInterface(IntPtr handle)
        {
        }

        public static IntPtr EOS_Platform_GetModsInterface(IntPtr handle)
        {
        }

        public static Platform.NetworkStatus EOS_Platform_GetNetworkStatus(IntPtr handle)
        {
        }

        public static Result EOS_Platform_GetOverrideCountryCode(IntPtr handle, IntPtr outBuffer, ref int inOutBufferLength)
        {
        }

        public static Result EOS_Platform_GetOverrideLocaleCode(IntPtr handle, IntPtr outBuffer, ref int inOutBufferLength)
        {
        }

        public static IntPtr EOS_Platform_GetP2PInterface(IntPtr handle)
        {
        }

        public static IntPtr EOS_Platform_GetPlayerDataStorageInterface(IntPtr handle)
        {
        }

        public static IntPtr EOS_Platform_GetPresenceInterface(IntPtr handle)
        {
        }

        public static IntPtr EOS_Platform_GetProgressionSnapshotInterface(IntPtr handle)
        {
        }

        public static IntPtr EOS_Platform_GetRTCAdminInterface(IntPtr handle)
        {
        }

        public static IntPtr EOS_Platform_GetRTCInterface(IntPtr handle)
        {
        }

        public static IntPtr EOS_Platform_GetReportsInterface(IntPtr handle)
        {
        }

        public static IntPtr EOS_Platform_GetSanctionsInterface(IntPtr handle)
        {
        }

        public static IntPtr EOS_Platform_GetSessionsInterface(IntPtr handle)
        {
        }

        public static IntPtr EOS_Platform_GetStatsInterface(IntPtr handle)
        {
        }

        public static IntPtr EOS_Platform_GetTitleStorageInterface(IntPtr handle)
        {
        }

        public static IntPtr EOS_Platform_GetUIInterface(IntPtr handle)
        {
        }

        public static IntPtr EOS_Platform_GetUserInfoInterface(IntPtr handle)
        {
        }

        public static void EOS_Platform_Release(IntPtr handle)
        {
        }

        public static Result EOS_Platform_SetApplicationStatus(IntPtr handle, Platform.ApplicationStatus newStatus)
        {
        }

        public static Result EOS_Platform_SetNetworkStatus(IntPtr handle, Platform.NetworkStatus newStatus)
        {
        }

        public static Result EOS_Platform_SetOverrideCountryCode(IntPtr handle, IntPtr newCountryCode)
        {
        }

        public static Result EOS_Platform_SetOverrideLocaleCode(IntPtr handle, IntPtr newLocaleCode)
        {
        }

        public static void EOS_Platform_Tick(IntPtr handle)
        {
        }

        public static Result EOS_PlayerDataStorageFileTransferRequest_CancelRequest(IntPtr handle)
        {
        }

        public static Result EOS_PlayerDataStorageFileTransferRequest_GetFileRequestState(IntPtr handle)
        {
        }

        public static Result EOS_PlayerDataStorageFileTransferRequest_GetFilename(IntPtr handle, uint filenameStringBufferSizeBytes, IntPtr outStringBuffer, ref int outStringLength)
        {
        }

        public static void EOS_PlayerDataStorageFileTransferRequest_Release(IntPtr playerDataStorageFileTransferHandle)
        {
        }

        public static Result EOS_PlayerDataStorage_CopyFileMetadataAtIndex(IntPtr handle, ref PlayerDataStorage.CopyFileMetadataAtIndexOptionsInternal copyFileMetadataOptions, ref IntPtr outMetadata)
        {
        }

        public static Result EOS_PlayerDataStorage_CopyFileMetadataByFilename(IntPtr handle, ref PlayerDataStorage.CopyFileMetadataByFilenameOptionsInternal copyFileMetadataOptions, ref IntPtr outMetadata)
        {
        }

        public static Result EOS_PlayerDataStorage_DeleteCache(IntPtr handle, ref PlayerDataStorage.DeleteCacheOptionsInternal options, IntPtr clientData, PlayerDataStorage.OnDeleteCacheCompleteCallbackInternal completionCallback)
        {
        }

        public static void EOS_PlayerDataStorage_DeleteFile(IntPtr handle, ref PlayerDataStorage.DeleteFileOptionsInternal deleteOptions, IntPtr clientData, PlayerDataStorage.OnDeleteFileCompleteCallbackInternal completionCallback)
        {
        }

        public static void EOS_PlayerDataStorage_DuplicateFile(IntPtr handle, ref PlayerDataStorage.DuplicateFileOptionsInternal duplicateOptions, IntPtr clientData, PlayerDataStorage.OnDuplicateFileCompleteCallbackInternal completionCallback)
        {
        }

        public static void EOS_PlayerDataStorage_FileMetadata_Release(IntPtr fileMetadata)
        {
        }

        public static Result EOS_PlayerDataStorage_GetFileMetadataCount(IntPtr handle, ref PlayerDataStorage.GetFileMetadataCountOptionsInternal getFileMetadataCountOptions, ref int outFileMetadataCount)
        {
        }

        public static void EOS_PlayerDataStorage_QueryFile(IntPtr handle, ref PlayerDataStorage.QueryFileOptionsInternal queryFileOptions, IntPtr clientData, PlayerDataStorage.OnQueryFileCompleteCallbackInternal completionCallback)
        {
        }

        public static void EOS_PlayerDataStorage_QueryFileList(IntPtr handle, ref PlayerDataStorage.QueryFileListOptionsInternal queryFileListOptions, IntPtr clientData, PlayerDataStorage.OnQueryFileListCompleteCallbackInternal completionCallback)
        {
        }

        public static IntPtr EOS_PlayerDataStorage_ReadFile(IntPtr handle, ref PlayerDataStorage.ReadFileOptionsInternal readOptions, IntPtr clientData, PlayerDataStorage.OnReadFileCompleteCallbackInternal completionCallback)
        {
        }

        public static IntPtr EOS_PlayerDataStorage_WriteFile(IntPtr handle, ref PlayerDataStorage.WriteFileOptionsInternal writeOptions, IntPtr clientData, PlayerDataStorage.OnWriteFileCompleteCallbackInternal completionCallback)
        {
        }

        public static Result EOS_PresenceModification_DeleteData(IntPtr handle, ref Presence.PresenceModificationDeleteDataOptionsInternal options)
        {
        }

        public static void EOS_PresenceModification_Release(IntPtr presenceModificationHandle)
        {
        }

        public static Result EOS_PresenceModification_SetData(IntPtr handle, ref Presence.PresenceModificationSetDataOptionsInternal options)
        {
        }

        public static Result EOS_PresenceModification_SetJoinInfo(IntPtr handle, ref Presence.PresenceModificationSetJoinInfoOptionsInternal options)
        {
        }

        public static Result EOS_PresenceModification_SetRawRichText(IntPtr handle, ref Presence.PresenceModificationSetRawRichTextOptionsInternal options)
        {
        }

        public static Result EOS_PresenceModification_SetStatus(IntPtr handle, ref Presence.PresenceModificationSetStatusOptionsInternal options)
        {
        }

        public static ulong EOS_Presence_AddNotifyJoinGameAccepted(IntPtr handle, ref Presence.AddNotifyJoinGameAcceptedOptionsInternal options, IntPtr clientData, Presence.OnJoinGameAcceptedCallbackInternal notificationFn)
        {
        }

        public static ulong EOS_Presence_AddNotifyOnPresenceChanged(IntPtr handle, ref Presence.AddNotifyOnPresenceChangedOptionsInternal options, IntPtr clientData, Presence.OnPresenceChangedCallbackInternal notificationHandler)
        {
        }

        public static Result EOS_Presence_CopyPresence(IntPtr handle, ref Presence.CopyPresenceOptionsInternal options, ref IntPtr outPresence)
        {
        }

        public static Result EOS_Presence_CreatePresenceModification(IntPtr handle, ref Presence.CreatePresenceModificationOptionsInternal options, ref IntPtr outPresenceModificationHandle)
        {
        }

        public static Result EOS_Presence_GetJoinInfo(IntPtr handle, ref Presence.GetJoinInfoOptionsInternal options, IntPtr outBuffer, ref int inOutBufferLength)
        {
        }

        public static int EOS_Presence_HasPresence(IntPtr handle, ref Presence.HasPresenceOptionsInternal options)
        {
        }

        public static void EOS_Presence_Info_Release(IntPtr presenceInfo)
        {
        }

        public static void EOS_Presence_QueryPresence(IntPtr handle, ref Presence.QueryPresenceOptionsInternal options, IntPtr clientData, Presence.OnQueryPresenceCompleteCallbackInternal completionDelegate)
        {
        }

        public static void EOS_Presence_RemoveNotifyJoinGameAccepted(IntPtr handle, ulong inId)
        {
        }

        public static void EOS_Presence_RemoveNotifyOnPresenceChanged(IntPtr handle, ulong notificationId)
        {
        }

        public static void EOS_Presence_SetPresence(IntPtr handle, ref Presence.SetPresenceOptionsInternal options, IntPtr clientData, Presence.SetPresenceCompleteCallbackInternal completionDelegate)
        {
        }

        public static IntPtr EOS_ProductUserId_FromString(IntPtr productUserIdString)
        {
        }

        public static int EOS_ProductUserId_IsValid(IntPtr accountId)
        {
        }

        public static Result EOS_ProductUserId_ToString(IntPtr accountId, IntPtr outBuffer, ref int inOutBufferLength)
        {
        }

        public static Result EOS_ProgressionSnapshot_AddProgression(IntPtr handle, ref ProgressionSnapshot.AddProgressionOptionsInternal options)
        {
        }

        public static Result EOS_ProgressionSnapshot_BeginSnapshot(IntPtr handle, ref ProgressionSnapshot.BeginSnapshotOptionsInternal options, ref uint outSnapshotId)
        {
        }

        public static void EOS_ProgressionSnapshot_DeleteSnapshot(IntPtr handle, ref ProgressionSnapshot.DeleteSnapshotOptionsInternal options, IntPtr clientData, ProgressionSnapshot.OnDeleteSnapshotCallbackInternal completionDelegate)
        {
        }

        public static Result EOS_ProgressionSnapshot_EndSnapshot(IntPtr handle, ref ProgressionSnapshot.EndSnapshotOptionsInternal options)
        {
        }

        public static void EOS_ProgressionSnapshot_SubmitSnapshot(IntPtr handle, ref ProgressionSnapshot.SubmitSnapshotOptionsInternal options, IntPtr clientData, ProgressionSnapshot.OnSubmitSnapshotCallbackInternal completionDelegate)
        {
        }

        public static Result EOS_RTCAdmin_CopyUserTokenByIndex(IntPtr handle, ref RTCAdmin.CopyUserTokenByIndexOptionsInternal options, ref IntPtr outUserToken)
        {
        }

        public static Result EOS_RTCAdmin_CopyUserTokenByUserId(IntPtr handle, ref RTCAdmin.CopyUserTokenByUserIdOptionsInternal options, ref IntPtr outUserToken)
        {
        }

        public static void EOS_RTCAdmin_Kick(IntPtr handle, ref RTCAdmin.KickOptionsInternal options, IntPtr clientData, RTCAdmin.OnKickCompleteCallbackInternal completionDelegate)
        {
        }

        public static void EOS_RTCAdmin_QueryJoinRoomToken(IntPtr handle, ref RTCAdmin.QueryJoinRoomTokenOptionsInternal options, IntPtr clientData, RTCAdmin.OnQueryJoinRoomTokenCompleteCallbackInternal completionDelegate)
        {
        }

        public static void EOS_RTCAdmin_SetParticipantHardMute(IntPtr handle, ref RTCAdmin.SetParticipantHardMuteOptionsInternal options, IntPtr clientData, RTCAdmin.OnSetParticipantHardMuteCompleteCallbackInternal completionDelegate)
        {
        }

        public static void EOS_RTCAdmin_UserToken_Release(IntPtr userToken)
        {
        }

        public static ulong EOS_RTCAudio_AddNotifyAudioBeforeRender(IntPtr handle, ref RTCAudio.AddNotifyAudioBeforeRenderOptionsInternal options, IntPtr clientData, RTCAudio.OnAudioBeforeRenderCallbackInternal completionDelegate)
        {
        }

        public static ulong EOS_RTCAudio_AddNotifyAudioBeforeSend(IntPtr handle, ref RTCAudio.AddNotifyAudioBeforeSendOptionsInternal options, IntPtr clientData, RTCAudio.OnAudioBeforeSendCallbackInternal completionDelegate)
        {
        }

        public static ulong EOS_RTCAudio_AddNotifyAudioDevicesChanged(IntPtr handle, ref RTCAudio.AddNotifyAudioDevicesChangedOptionsInternal options, IntPtr clientData, RTCAudio.OnAudioDevicesChangedCallbackInternal completionDelegate)
        {
        }

        public static ulong EOS_RTCAudio_AddNotifyAudioInputState(IntPtr handle, ref RTCAudio.AddNotifyAudioInputStateOptionsInternal options, IntPtr clientData, RTCAudio.OnAudioInputStateCallbackInternal completionDelegate)
        {
        }

        public static ulong EOS_RTCAudio_AddNotifyAudioOutputState(IntPtr handle, ref RTCAudio.AddNotifyAudioOutputStateOptionsInternal options, IntPtr clientData, RTCAudio.OnAudioOutputStateCallbackInternal completionDelegate)
        {
        }

        public static ulong EOS_RTCAudio_AddNotifyParticipantUpdated(IntPtr handle, ref RTCAudio.AddNotifyParticipantUpdatedOptionsInternal options, IntPtr clientData, RTCAudio.OnParticipantUpdatedCallbackInternal completionDelegate)
        {
        }

        public static Result EOS_RTCAudio_CopyInputDeviceInformationByIndex(IntPtr handle, ref RTCAudio.CopyInputDeviceInformationByIndexOptionsInternal options, ref IntPtr outInputDeviceInformation)
        {
        }

        public static Result EOS_RTCAudio_CopyOutputDeviceInformationByIndex(IntPtr handle, ref RTCAudio.CopyOutputDeviceInformationByIndexOptionsInternal options, ref IntPtr outOutputDeviceInformation)
        {
        }

        public static IntPtr EOS_RTCAudio_GetAudioInputDeviceByIndex(IntPtr handle, ref RTCAudio.GetAudioInputDeviceByIndexOptionsInternal options)
        {
        }

        public static uint EOS_RTCAudio_GetAudioInputDevicesCount(IntPtr handle, ref RTCAudio.GetAudioInputDevicesCountOptionsInternal options)
        {
        }

        public static IntPtr EOS_RTCAudio_GetAudioOutputDeviceByIndex(IntPtr handle, ref RTCAudio.GetAudioOutputDeviceByIndexOptionsInternal options)
        {
        }

        public static uint EOS_RTCAudio_GetAudioOutputDevicesCount(IntPtr handle, ref RTCAudio.GetAudioOutputDevicesCountOptionsInternal options)
        {
        }

        public static uint EOS_RTCAudio_GetInputDevicesCount(IntPtr handle, ref RTCAudio.GetInputDevicesCountOptionsInternal options)
        {
        }

        public static uint EOS_RTCAudio_GetOutputDevicesCount(IntPtr handle, ref RTCAudio.GetOutputDevicesCountOptionsInternal options)
        {
        }

        public static void EOS_RTCAudio_InputDeviceInformation_Release(IntPtr deviceInformation)
        {
        }

        public static void EOS_RTCAudio_OutputDeviceInformation_Release(IntPtr deviceInformation)
        {
        }

        public static void EOS_RTCAudio_QueryInputDevicesInformation(IntPtr handle, ref RTCAudio.QueryInputDevicesInformationOptionsInternal options, IntPtr clientData, RTCAudio.OnQueryInputDevicesInformationCallbackInternal completionDelegate)
        {
        }

        public static void EOS_RTCAudio_QueryOutputDevicesInformation(IntPtr handle, ref RTCAudio.QueryOutputDevicesInformationOptionsInternal options, IntPtr clientData, RTCAudio.OnQueryOutputDevicesInformationCallbackInternal completionDelegate)
        {
        }

        public static Result EOS_RTCAudio_RegisterPlatformAudioUser(IntPtr handle, ref RTCAudio.RegisterPlatformAudioUserOptionsInternal options)
        {
        }

        public static void EOS_RTCAudio_RegisterPlatformUser(IntPtr handle, ref RTCAudio.RegisterPlatformUserOptionsInternal options, IntPtr clientData, RTCAudio.OnRegisterPlatformUserCallbackInternal completionDelegate)
        {
        }

        public static void EOS_RTCAudio_RemoveNotifyAudioBeforeRender(IntPtr handle, ulong notificationId)
        {
        }

        public static void EOS_RTCAudio_RemoveNotifyAudioBeforeSend(IntPtr handle, ulong notificationId)
        {
        }

        public static void EOS_RTCAudio_RemoveNotifyAudioDevicesChanged(IntPtr handle, ulong notificationId)
        {
        }

        public static void EOS_RTCAudio_RemoveNotifyAudioInputState(IntPtr handle, ulong notificationId)
        {
        }

        public static void EOS_RTCAudio_RemoveNotifyAudioOutputState(IntPtr handle, ulong notificationId)
        {
        }

        public static void EOS_RTCAudio_RemoveNotifyParticipantUpdated(IntPtr handle, ulong notificationId)
        {
        }

        public static Result EOS_RTCAudio_SendAudio(IntPtr handle, ref RTCAudio.SendAudioOptionsInternal options)
        {
        }

        public static Result EOS_RTCAudio_SetAudioInputSettings(IntPtr handle, ref RTCAudio.SetAudioInputSettingsOptionsInternal options)
        {
        }

        public static Result EOS_RTCAudio_SetAudioOutputSettings(IntPtr handle, ref RTCAudio.SetAudioOutputSettingsOptionsInternal options)
        {
        }

        public static void EOS_RTCAudio_SetInputDeviceSettings(IntPtr handle, ref RTCAudio.SetInputDeviceSettingsOptionsInternal options, IntPtr clientData, RTCAudio.OnSetInputDeviceSettingsCallbackInternal completionDelegate)
        {
        }

        public static void EOS_RTCAudio_SetOutputDeviceSettings(IntPtr handle, ref RTCAudio.SetOutputDeviceSettingsOptionsInternal options, IntPtr clientData, RTCAudio.OnSetOutputDeviceSettingsCallbackInternal completionDelegate)
        {
        }

        public static Result EOS_RTCAudio_UnregisterPlatformAudioUser(IntPtr handle, ref RTCAudio.UnregisterPlatformAudioUserOptionsInternal options)
        {
        }

        public static void EOS_RTCAudio_UnregisterPlatformUser(IntPtr handle, ref RTCAudio.UnregisterPlatformUserOptionsInternal options, IntPtr clientData, RTCAudio.OnUnregisterPlatformUserCallbackInternal completionDelegate)
        {
        }

        public static void EOS_RTCAudio_UpdateParticipantVolume(IntPtr handle, ref RTCAudio.UpdateParticipantVolumeOptionsInternal options, IntPtr clientData, RTCAudio.OnUpdateParticipantVolumeCallbackInternal completionDelegate)
        {
        }

        public static void EOS_RTCAudio_UpdateReceiving(IntPtr handle, ref RTCAudio.UpdateReceivingOptionsInternal options, IntPtr clientData, RTCAudio.OnUpdateReceivingCallbackInternal completionDelegate)
        {
        }

        public static void EOS_RTCAudio_UpdateReceivingVolume(IntPtr handle, ref RTCAudio.UpdateReceivingVolumeOptionsInternal options, IntPtr clientData, RTCAudio.OnUpdateReceivingVolumeCallbackInternal completionDelegate)
        {
        }

        public static void EOS_RTCAudio_UpdateSending(IntPtr handle, ref RTCAudio.UpdateSendingOptionsInternal options, IntPtr clientData, RTCAudio.OnUpdateSendingCallbackInternal completionDelegate)
        {
        }

        public static void EOS_RTCAudio_UpdateSendingVolume(IntPtr handle, ref RTCAudio.UpdateSendingVolumeOptionsInternal options, IntPtr clientData, RTCAudio.OnUpdateSendingVolumeCallbackInternal completionDelegate)
        {
        }

        public static ulong EOS_RTC_AddNotifyDisconnected(IntPtr handle, ref RTC.AddNotifyDisconnectedOptionsInternal options, IntPtr clientData, RTC.OnDisconnectedCallbackInternal completionDelegate)
        {
        }

        public static ulong EOS_RTC_AddNotifyParticipantStatusChanged(IntPtr handle, ref RTC.AddNotifyParticipantStatusChangedOptionsInternal options, IntPtr clientData, RTC.OnParticipantStatusChangedCallbackInternal completionDelegate)
        {
        }

        public static ulong EOS_RTC_AddNotifyRoomStatisticsUpdated(IntPtr handle, ref RTC.AddNotifyRoomStatisticsUpdatedOptionsInternal options, IntPtr clientData, RTC.OnRoomStatisticsUpdatedCallbackInternal statisticsUpdateHandler)
        {
        }

        public static void EOS_RTC_BlockParticipant(IntPtr handle, ref RTC.BlockParticipantOptionsInternal options, IntPtr clientData, RTC.OnBlockParticipantCallbackInternal completionDelegate)
        {
        }

        public static IntPtr EOS_RTC_GetAudioInterface(IntPtr handle)
        {
        }

        public static void EOS_RTC_JoinRoom(IntPtr handle, ref RTC.JoinRoomOptionsInternal options, IntPtr clientData, RTC.OnJoinRoomCallbackInternal completionDelegate)
        {
        }

        public static void EOS_RTC_LeaveRoom(IntPtr handle, ref RTC.LeaveRoomOptionsInternal options, IntPtr clientData, RTC.OnLeaveRoomCallbackInternal completionDelegate)
        {
        }

        public static void EOS_RTC_RemoveNotifyDisconnected(IntPtr handle, ulong notificationId)
        {
        }

        public static void EOS_RTC_RemoveNotifyParticipantStatusChanged(IntPtr handle, ulong notificationId)
        {
        }

        public static void EOS_RTC_RemoveNotifyRoomStatisticsUpdated(IntPtr handle, ulong notificationId)
        {
        }

        public static Result EOS_RTC_SetRoomSetting(IntPtr handle, ref RTC.SetRoomSettingOptionsInternal options)
        {
        }

        public static Result EOS_RTC_SetSetting(IntPtr handle, ref RTC.SetSettingOptionsInternal options)
        {
        }

        public static void EOS_Reports_SendPlayerBehaviorReport(IntPtr handle, ref Reports.SendPlayerBehaviorReportOptionsInternal options, IntPtr clientData, Reports.OnSendPlayerBehaviorReportCompleteCallbackInternal completionDelegate)
        {
        }

        public static Result EOS_Sanctions_CopyPlayerSanctionByIndex(IntPtr handle, ref Sanctions.CopyPlayerSanctionByIndexOptionsInternal options, ref IntPtr outSanction)
        {
        }

        public static uint EOS_Sanctions_GetPlayerSanctionCount(IntPtr handle, ref Sanctions.GetPlayerSanctionCountOptionsInternal options)
        {
        }

        public static void EOS_Sanctions_PlayerSanction_Release(IntPtr sanction)
        {
        }

        public static void EOS_Sanctions_QueryActivePlayerSanctions(IntPtr handle, ref Sanctions.QueryActivePlayerSanctionsOptionsInternal options, IntPtr clientData, Sanctions.OnQueryActivePlayerSanctionsCallbackInternal completionDelegate)
        {
        }

        public static void EOS_SessionDetails_Attribute_Release(IntPtr sessionAttribute)
        {
        }

        public static Result EOS_SessionDetails_CopyInfo(IntPtr handle, ref Sessions.SessionDetailsCopyInfoOptionsInternal options, ref IntPtr outSessionInfo)
        {
        }

        public static Result EOS_SessionDetails_CopySessionAttributeByIndex(IntPtr handle, ref Sessions.SessionDetailsCopySessionAttributeByIndexOptionsInternal options, ref IntPtr outSessionAttribute)
        {
        }

        public static Result EOS_SessionDetails_CopySessionAttributeByKey(IntPtr handle, ref Sessions.SessionDetailsCopySessionAttributeByKeyOptionsInternal options, ref IntPtr outSessionAttribute)
        {
        }

        public static uint EOS_SessionDetails_GetSessionAttributeCount(IntPtr handle, ref Sessions.SessionDetailsGetSessionAttributeCountOptionsInternal options)
        {
        }

        public static void EOS_SessionDetails_Info_Release(IntPtr sessionInfo)
        {
        }

        public static void EOS_SessionDetails_Release(IntPtr sessionHandle)
        {
        }

        public static Result EOS_SessionModification_AddAttribute(IntPtr handle, ref Sessions.SessionModificationAddAttributeOptionsInternal options)
        {
        }

        public static void EOS_SessionModification_Release(IntPtr sessionModificationHandle)
        {
        }

        public static Result EOS_SessionModification_RemoveAttribute(IntPtr handle, ref Sessions.SessionModificationRemoveAttributeOptionsInternal options)
        {
        }

        public static Result EOS_SessionModification_SetAllowedPlatformIds(IntPtr handle, ref Sessions.SessionModificationSetAllowedPlatformIdsOptionsInternal options)
        {
        }

        public static Result EOS_SessionModification_SetBucketId(IntPtr handle, ref Sessions.SessionModificationSetBucketIdOptionsInternal options)
        {
        }

        public static Result EOS_SessionModification_SetHostAddress(IntPtr handle, ref Sessions.SessionModificationSetHostAddressOptionsInternal options)
        {
        }

        public static Result EOS_SessionModification_SetInvitesAllowed(IntPtr handle, ref Sessions.SessionModificationSetInvitesAllowedOptionsInternal options)
        {
        }

        public static Result EOS_SessionModification_SetJoinInProgressAllowed(IntPtr handle, ref Sessions.SessionModificationSetJoinInProgressAllowedOptionsInternal options)
        {
        }

        public static Result EOS_SessionModification_SetMaxPlayers(IntPtr handle, ref Sessions.SessionModificationSetMaxPlayersOptionsInternal options)
        {
        }

        public static Result EOS_SessionModification_SetPermissionLevel(IntPtr handle, ref Sessions.SessionModificationSetPermissionLevelOptionsInternal options)
        {
        }

        public static Result EOS_SessionSearch_CopySearchResultByIndex(IntPtr handle, ref Sessions.SessionSearchCopySearchResultByIndexOptionsInternal options, ref IntPtr outSessionHandle)
        {
        }

        public static void EOS_SessionSearch_Find(IntPtr handle, ref Sessions.SessionSearchFindOptionsInternal options, IntPtr clientData, Sessions.SessionSearchOnFindCallbackInternal completionDelegate)
        {
        }

        public static uint EOS_SessionSearch_GetSearchResultCount(IntPtr handle, ref Sessions.SessionSearchGetSearchResultCountOptionsInternal options)
        {
        }

        public static void EOS_SessionSearch_Release(IntPtr sessionSearchHandle)
        {
        }

        public static Result EOS_SessionSearch_RemoveParameter(IntPtr handle, ref Sessions.SessionSearchRemoveParameterOptionsInternal options)
        {
        }

        public static Result EOS_SessionSearch_SetMaxResults(IntPtr handle, ref Sessions.SessionSearchSetMaxResultsOptionsInternal options)
        {
        }

        public static Result EOS_SessionSearch_SetParameter(IntPtr handle, ref Sessions.SessionSearchSetParameterOptionsInternal options)
        {
        }

        public static Result EOS_SessionSearch_SetSessionId(IntPtr handle, ref Sessions.SessionSearchSetSessionIdOptionsInternal options)
        {
        }

        public static Result EOS_SessionSearch_SetTargetUserId(IntPtr handle, ref Sessions.SessionSearchSetTargetUserIdOptionsInternal options)
        {
        }

        public static ulong EOS_Sessions_AddNotifyJoinSessionAccepted(IntPtr handle, ref Sessions.AddNotifyJoinSessionAcceptedOptionsInternal options, IntPtr clientData, Sessions.OnJoinSessionAcceptedCallbackInternal notificationFn)
        {
        }

        public static ulong EOS_Sessions_AddNotifyLeaveSessionRequested(IntPtr handle, ref Sessions.AddNotifyLeaveSessionRequestedOptionsInternal options, IntPtr clientData, Sessions.OnLeaveSessionRequestedCallbackInternal notificationFn)
        {
        }

        public static ulong EOS_Sessions_AddNotifySendSessionNativeInviteRequested(IntPtr handle, ref Sessions.AddNotifySendSessionNativeInviteRequestedOptionsInternal options, IntPtr clientData, Sessions.OnSendSessionNativeInviteRequestedCallbackInternal notificationFn)
        {
        }

        public static ulong EOS_Sessions_AddNotifySessionInviteAccepted(IntPtr handle, ref Sessions.AddNotifySessionInviteAcceptedOptionsInternal options, IntPtr clientData, Sessions.OnSessionInviteAcceptedCallbackInternal notificationFn)
        {
        }

        public static ulong EOS_Sessions_AddNotifySessionInviteReceived(IntPtr handle, ref Sessions.AddNotifySessionInviteReceivedOptionsInternal options, IntPtr clientData, Sessions.OnSessionInviteReceivedCallbackInternal notificationFn)
        {
        }

        public static ulong EOS_Sessions_AddNotifySessionInviteRejected(IntPtr handle, ref Sessions.AddNotifySessionInviteRejectedOptionsInternal options, IntPtr clientData, Sessions.OnSessionInviteRejectedCallbackInternal notificationFn)
        {
        }

        public static Result EOS_Sessions_CopyActiveSessionHandle(IntPtr handle, ref Sessions.CopyActiveSessionHandleOptionsInternal options, ref IntPtr outSessionHandle)
        {
        }

        public static Result EOS_Sessions_CopySessionHandleByInviteId(IntPtr handle, ref Sessions.CopySessionHandleByInviteIdOptionsInternal options, ref IntPtr outSessionHandle)
        {
        }

        public static Result EOS_Sessions_CopySessionHandleByUiEventId(IntPtr handle, ref Sessions.CopySessionHandleByUiEventIdOptionsInternal options, ref IntPtr outSessionHandle)
        {
        }

        public static Result EOS_Sessions_CopySessionHandleForPresence(IntPtr handle, ref Sessions.CopySessionHandleForPresenceOptionsInternal options, ref IntPtr outSessionHandle)
        {
        }

        public static Result EOS_Sessions_CreateSessionModification(IntPtr handle, ref Sessions.CreateSessionModificationOptionsInternal options, ref IntPtr outSessionModificationHandle)
        {
        }

        public static Result EOS_Sessions_CreateSessionSearch(IntPtr handle, ref Sessions.CreateSessionSearchOptionsInternal options, ref IntPtr outSessionSearchHandle)
        {
        }

        public static void EOS_Sessions_DestroySession(IntPtr handle, ref Sessions.DestroySessionOptionsInternal options, IntPtr clientData, Sessions.OnDestroySessionCallbackInternal completionDelegate)
        {
        }

        public static Result EOS_Sessions_DumpSessionState(IntPtr handle, ref Sessions.DumpSessionStateOptionsInternal options)
        {
        }

        public static void EOS_Sessions_EndSession(IntPtr handle, ref Sessions.EndSessionOptionsInternal options, IntPtr clientData, Sessions.OnEndSessionCallbackInternal completionDelegate)
        {
        }

        public static uint EOS_Sessions_GetInviteCount(IntPtr handle, ref Sessions.GetInviteCountOptionsInternal options)
        {
        }

        public static Result EOS_Sessions_GetInviteIdByIndex(IntPtr handle, ref Sessions.GetInviteIdByIndexOptionsInternal options, IntPtr outBuffer, ref int inOutBufferLength)
        {
        }

        public static Result EOS_Sessions_IsUserInSession(IntPtr handle, ref Sessions.IsUserInSessionOptionsInternal options)
        {
        }

        public static void EOS_Sessions_JoinSession(IntPtr handle, ref Sessions.JoinSessionOptionsInternal options, IntPtr clientData, Sessions.OnJoinSessionCallbackInternal completionDelegate)
        {
        }

        public static void EOS_Sessions_QueryInvites(IntPtr handle, ref Sessions.QueryInvitesOptionsInternal options, IntPtr clientData, Sessions.OnQueryInvitesCallbackInternal completionDelegate)
        {
        }

        public static void EOS_Sessions_RegisterPlayers(IntPtr handle, ref Sessions.RegisterPlayersOptionsInternal options, IntPtr clientData, Sessions.OnRegisterPlayersCallbackInternal completionDelegate)
        {
        }

        public static void EOS_Sessions_RejectInvite(IntPtr handle, ref Sessions.RejectInviteOptionsInternal options, IntPtr clientData, Sessions.OnRejectInviteCallbackInternal completionDelegate)
        {
        }

        public static void EOS_Sessions_RemoveNotifyJoinSessionAccepted(IntPtr handle, ulong inId)
        {
        }

        public static void EOS_Sessions_RemoveNotifyLeaveSessionRequested(IntPtr handle, ulong inId)
        {
        }

        public static void EOS_Sessions_RemoveNotifySendSessionNativeInviteRequested(IntPtr handle, ulong inId)
        {
        }

        public static void EOS_Sessions_RemoveNotifySessionInviteAccepted(IntPtr handle, ulong inId)
        {
        }

        public static void EOS_Sessions_RemoveNotifySessionInviteReceived(IntPtr handle, ulong inId)
        {
        }

        public static void EOS_Sessions_RemoveNotifySessionInviteRejected(IntPtr handle, ulong inId)
        {
        }

        public static void EOS_Sessions_SendInvite(IntPtr handle, ref Sessions.SendInviteOptionsInternal options, IntPtr clientData, Sessions.OnSendInviteCallbackInternal completionDelegate)
        {
        }

        public static void EOS_Sessions_StartSession(IntPtr handle, ref Sessions.StartSessionOptionsInternal options, IntPtr clientData, Sessions.OnStartSessionCallbackInternal completionDelegate)
        {
        }

        public static void EOS_Sessions_UnregisterPlayers(IntPtr handle, ref Sessions.UnregisterPlayersOptionsInternal options, IntPtr clientData, Sessions.OnUnregisterPlayersCallbackInternal completionDelegate)
        {
        }

        public static void EOS_Sessions_UpdateSession(IntPtr handle, ref Sessions.UpdateSessionOptionsInternal options, IntPtr clientData, Sessions.OnUpdateSessionCallbackInternal completionDelegate)
        {
        }

        public static Result EOS_Sessions_UpdateSessionModification(IntPtr handle, ref Sessions.UpdateSessionModificationOptionsInternal options, ref IntPtr outSessionModificationHandle)
        {
        }

        public static Result EOS_Shutdown()
        {
        }

        public static Result EOS_Stats_CopyStatByIndex(IntPtr handle, ref Stats.CopyStatByIndexOptionsInternal options, ref IntPtr outStat)
        {
        }

        public static Result EOS_Stats_CopyStatByName(IntPtr handle, ref Stats.CopyStatByNameOptionsInternal options, ref IntPtr outStat)
        {
        }

        public static uint EOS_Stats_GetStatsCount(IntPtr handle, ref Stats.GetStatCountOptionsInternal options)
        {
        }

        public static void EOS_Stats_IngestStat(IntPtr handle, ref Stats.IngestStatOptionsInternal options, IntPtr clientData, Stats.OnIngestStatCompleteCallbackInternal completionDelegate)
        {
        }

        public static void EOS_Stats_QueryStats(IntPtr handle, ref Stats.QueryStatsOptionsInternal options, IntPtr clientData, Stats.OnQueryStatsCompleteCallbackInternal completionDelegate)
        {
        }

        public static void EOS_Stats_Stat_Release(IntPtr stat)
        {
        }

        public static Result EOS_TitleStorageFileTransferRequest_CancelRequest(IntPtr handle)
        {
        }

        public static Result EOS_TitleStorageFileTransferRequest_GetFileRequestState(IntPtr handle)
        {
        }

        public static Result EOS_TitleStorageFileTransferRequest_GetFilename(IntPtr handle, uint filenameStringBufferSizeBytes, IntPtr outStringBuffer, ref int outStringLength)
        {
        }

        public static void EOS_TitleStorageFileTransferRequest_Release(IntPtr titleStorageFileTransferHandle)
        {
        }

        public static Result EOS_TitleStorage_CopyFileMetadataAtIndex(IntPtr handle, ref TitleStorage.CopyFileMetadataAtIndexOptionsInternal options, ref IntPtr outMetadata)
        {
        }

        public static Result EOS_TitleStorage_CopyFileMetadataByFilename(IntPtr handle, ref TitleStorage.CopyFileMetadataByFilenameOptionsInternal options, ref IntPtr outMetadata)
        {
        }

        public static Result EOS_TitleStorage_DeleteCache(IntPtr handle, ref TitleStorage.DeleteCacheOptionsInternal options, IntPtr clientData, TitleStorage.OnDeleteCacheCompleteCallbackInternal completionCallback)
        {
        }

        public static void EOS_TitleStorage_FileMetadata_Release(IntPtr fileMetadata)
        {
        }

        public static uint EOS_TitleStorage_GetFileMetadataCount(IntPtr handle, ref TitleStorage.GetFileMetadataCountOptionsInternal options)
        {
        }

        public static void EOS_TitleStorage_QueryFile(IntPtr handle, ref TitleStorage.QueryFileOptionsInternal options, IntPtr clientData, TitleStorage.OnQueryFileCompleteCallbackInternal completionCallback)
        {
        }

        public static void EOS_TitleStorage_QueryFileList(IntPtr handle, ref TitleStorage.QueryFileListOptionsInternal options, IntPtr clientData, TitleStorage.OnQueryFileListCompleteCallbackInternal completionCallback)
        {
        }

        public static IntPtr EOS_TitleStorage_ReadFile(IntPtr handle, ref TitleStorage.ReadFileOptionsInternal options, IntPtr clientData, TitleStorage.OnReadFileCompleteCallbackInternal completionCallback)
        {
        }

        public static Result EOS_UI_AcknowledgeEventId(IntPtr handle, ref UI.AcknowledgeEventIdOptionsInternal options)
        {
        }

        public static ulong EOS_UI_AddNotifyDisplaySettingsUpdated(IntPtr handle, ref UI.AddNotifyDisplaySettingsUpdatedOptionsInternal options, IntPtr clientData, UI.OnDisplaySettingsUpdatedCallbackInternal notificationFn)
        {
        }

        public static ulong EOS_UI_AddNotifyMemoryMonitor(IntPtr handle, ref UI.AddNotifyMemoryMonitorOptionsInternal options, IntPtr clientData, UI.OnMemoryMonitorCallbackInternal notificationFn)
        {
        }

        public static int EOS_UI_GetFriendsExclusiveInput(IntPtr handle, ref UI.GetFriendsExclusiveInputOptionsInternal options)
        {
        }

        public static int EOS_UI_GetFriendsVisible(IntPtr handle, ref UI.GetFriendsVisibleOptionsInternal options)
        {
        }

        public static UI.NotificationLocation EOS_UI_GetNotificationLocationPreference(IntPtr handle)
        {
        }

        public static UI.InputStateButtonFlags EOS_UI_GetToggleFriendsButton(IntPtr handle, ref UI.GetToggleFriendsButtonOptionsInternal options)
        {
        }

        public static UI.KeyCombination EOS_UI_GetToggleFriendsKey(IntPtr handle, ref UI.GetToggleFriendsKeyOptionsInternal options)
        {
        }

        public static void EOS_UI_HideFriends(IntPtr handle, ref UI.HideFriendsOptionsInternal options, IntPtr clientData, UI.OnHideFriendsCallbackInternal completionDelegate)
        {
        }

        public static int EOS_UI_IsSocialOverlayPaused(IntPtr handle, ref UI.IsSocialOverlayPausedOptionsInternal options)
        {
        }

        public static int EOS_UI_IsValidButtonCombination(IntPtr handle, UI.InputStateButtonFlags buttonCombination)
        {
        }

        public static int EOS_UI_IsValidKeyCombination(IntPtr handle, UI.KeyCombination keyCombination)
        {
        }

        public static Result EOS_UI_PauseSocialOverlay(IntPtr handle, ref UI.PauseSocialOverlayOptionsInternal options)
        {
        }

        public static Result EOS_UI_PrePresent(IntPtr handle, ref UI.PrePresentOptionsInternal options)
        {
        }

        public static void EOS_UI_RemoveNotifyDisplaySettingsUpdated(IntPtr handle, ulong id)
        {
        }

        public static void EOS_UI_RemoveNotifyMemoryMonitor(IntPtr handle, ulong id)
        {
        }

        public static Result EOS_UI_ReportInputState(IntPtr handle, ref UI.ReportInputStateOptionsInternal options)
        {
        }

        public static Result EOS_UI_SetDisplayPreference(IntPtr handle, ref UI.SetDisplayPreferenceOptionsInternal options)
        {
        }

        public static Result EOS_UI_SetToggleFriendsButton(IntPtr handle, ref UI.SetToggleFriendsButtonOptionsInternal options)
        {
        }

        public static Result EOS_UI_SetToggleFriendsKey(IntPtr handle, ref UI.SetToggleFriendsKeyOptionsInternal options)
        {
        }

        public static void EOS_UI_ShowBlockPlayer(IntPtr handle, ref UI.ShowBlockPlayerOptionsInternal options, IntPtr clientData, UI.OnShowBlockPlayerCallbackInternal completionDelegate)
        {
        }

        public static void EOS_UI_ShowFriends(IntPtr handle, ref UI.ShowFriendsOptionsInternal options, IntPtr clientData, UI.OnShowFriendsCallbackInternal completionDelegate)
        {
        }

        public static void EOS_UI_ShowNativeProfile(IntPtr handle, ref UI.ShowNativeProfileOptionsInternal options, IntPtr clientData, UI.OnShowNativeProfileCallbackInternal completionDelegate)
        {
        }

        public static void EOS_UI_ShowReportPlayer(IntPtr handle, ref UI.ShowReportPlayerOptionsInternal options, IntPtr clientData, UI.OnShowReportPlayerCallbackInternal completionDelegate)
        {
        }

        public static void EOS_UserInfo_BestDisplayName_Release(IntPtr bestDisplayName)
        {
        }

        public static Result EOS_UserInfo_CopyBestDisplayName(IntPtr handle, ref UserInfo.CopyBestDisplayNameOptionsInternal options, ref IntPtr outBestDisplayName)
        {
        }

        public static Result EOS_UserInfo_CopyBestDisplayNameWithPlatform(IntPtr handle, ref UserInfo.CopyBestDisplayNameWithPlatformOptionsInternal options, ref IntPtr outBestDisplayName)
        {
        }

        public static Result EOS_UserInfo_CopyExternalUserInfoByAccountId(IntPtr handle, ref UserInfo.CopyExternalUserInfoByAccountIdOptionsInternal options, ref IntPtr outExternalUserInfo)
        {
        }

        public static Result EOS_UserInfo_CopyExternalUserInfoByAccountType(IntPtr handle, ref UserInfo.CopyExternalUserInfoByAccountTypeOptionsInternal options, ref IntPtr outExternalUserInfo)
        {
        }

        public static Result EOS_UserInfo_CopyExternalUserInfoByIndex(IntPtr handle, ref UserInfo.CopyExternalUserInfoByIndexOptionsInternal options, ref IntPtr outExternalUserInfo)
        {
        }

        public static Result EOS_UserInfo_CopyUserInfo(IntPtr handle, ref UserInfo.CopyUserInfoOptionsInternal options, ref IntPtr outUserInfo)
        {
        }

        public static void EOS_UserInfo_ExternalUserInfo_Release(IntPtr externalUserInfo)
        {
        }

        public static uint EOS_UserInfo_GetExternalUserInfoCount(IntPtr handle, ref UserInfo.GetExternalUserInfoCountOptionsInternal options)
        {
        }

        public static uint EOS_UserInfo_GetLocalPlatformType(IntPtr handle, ref UserInfo.GetLocalPlatformTypeOptionsInternal options)
        {
        }

        public static void EOS_UserInfo_QueryUserInfo(IntPtr handle, ref UserInfo.QueryUserInfoOptionsInternal options, IntPtr clientData, UserInfo.OnQueryUserInfoCallbackInternal completionDelegate)
        {
        }

        public static void EOS_UserInfo_QueryUserInfoByDisplayName(IntPtr handle, ref UserInfo.QueryUserInfoByDisplayNameOptionsInternal options, IntPtr clientData, UserInfo.OnQueryUserInfoByDisplayNameCallbackInternal completionDelegate)
        {
        }

        public static void EOS_UserInfo_QueryUserInfoByExternalAccount(IntPtr handle, ref UserInfo.QueryUserInfoByExternalAccountOptionsInternal options, IntPtr clientData, UserInfo.OnQueryUserInfoByExternalAccountCallbackInternal completionDelegate)
        {
        }

        public static void EOS_UserInfo_Release(IntPtr userInfo)
        {
        }

        #endregion
#endif
    }
}
