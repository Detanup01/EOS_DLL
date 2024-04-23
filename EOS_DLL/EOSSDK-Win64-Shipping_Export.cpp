#include "EOSSDK-Win64-Shipping_native.h"



DNNE_EXTERN_C DNNE_API uint64_t DNNE_CALLTYPE_STDCALL TESTAddNotify(int32_t number, intptr_t completionDelegate)
{
	return _TESTAddNotify(number, completionDelegate);
}

DNNE_EXTERN_C DNNE_API void DNNE_CALLTYPE_STDCALL TESTRemoveNotify(uint64_t id)
{
	_TESTRemoveNotify(id);
}

DNNE_EXTERN_C DNNE_API void DNNE_CALLTYPE_STDCALL TESTTriggerNotify(intptr_t completionDelegate)
{
	_TESTTriggerNotify(completionDelegate);
}

DNNE_EXTERN_C DNNE_API int32_t DNNE_CALLTYPE_STDCALL EOS_ByteArray_ToString(intptr_t byteArray, uint32_t length, intptr_t outBuffer, uint32_t inOutBufferLength)
{
	return _EOS_ByteArray_ToString(byteArray, length, outBuffer, inOutBufferLength);
}

DNNE_EXTERN_C DNNE_API int32_t DNNE_CALLTYPE_STDCALL EOS_ContinuanceToken_ToString(intptr_t continuanceToken, intptr_t outBuffer, int32_t inOutBufferLength)
{
	return _EOS_ContinuanceToken_ToString(continuanceToken, outBuffer, inOutBufferLength);
}

DNNE_EXTERN_C DNNE_API intptr_t DNNE_CALLTYPE_STDCALL EOS_EApplicationStatus_ToString(int32_t applicationStatus)
{
	return _EOS_EApplicationStatus_ToString(applicationStatus);
}

DNNE_EXTERN_C DNNE_API intptr_t DNNE_CALLTYPE_STDCALL EOS_ENetworkStatus_ToString(int32_t networkStatus)
{
	return _EOS_ENetworkStatus_ToString(networkStatus);
}

DNNE_EXTERN_C DNNE_API int32_t DNNE_CALLTYPE_STDCALL EOS_EResult_IsOperationComplete(int32_t result)
{
	return _EOS_EResult_IsOperationComplete(result);
}

DNNE_EXTERN_C DNNE_API intptr_t DNNE_CALLTYPE_STDCALL EOS_EResult_ToString(int32_t result)
{
	return _EOS_EResult_ToString(result);
}

DNNE_EXTERN_C DNNE_API int32_t DNNE_CALLTYPE_STDCALL EOS_Initialize(intptr_t options)
{
	return _EOS_Initialize(options);
}

DNNE_EXTERN_C DNNE_API int32_t DNNE_CALLTYPE_STDCALL EOS_Shutdown(void)
{
	return _EOS_Shutdown();
}

DNNE_EXTERN_C DNNE_API intptr_t DNNE_CALLTYPE_STDCALL EOS_EpicAccountId_FromString(intptr_t accountIdString)
{
	return EOS_EpicAccountId_FromString(accountIdString);
}

DNNE_EXTERN_C DNNE_API int32_t DNNE_CALLTYPE_STDCALL EOS_EpicAccountId_IsValid(intptr_t accountId)
{
	return EOS_EpicAccountId_IsValid(accountId);
}

DNNE_EXTERN_C DNNE_API int32_t DNNE_CALLTYPE_STDCALL EOS_EpicAccountId_ToString(intptr_t accountId, intptr_t outBuffer, int32_t inOutBufferLength)
{
	return EOS_EpicAccountId_ToString(accountId, outBuffer, inOutBufferLength);
}

DNNE_EXTERN_C DNNE_API intptr_t DNNE_CALLTYPE_STDCALL EOS_ProductUserId_FromString(intptr_t productUserIdString)
{
	return EOS_ProductUserId_FromString(productUserIdString);
}

DNNE_EXTERN_C DNNE_API int32_t DNNE_CALLTYPE_STDCALL EOS_ProductUserId_IsValid(intptr_t accountId)
{
	return EOS_ProductUserId_IsValid(accountId);
}

DNNE_EXTERN_C DNNE_API int32_t DNNE_CALLTYPE_STDCALL EOS_ProductUserId_ToString(intptr_t accountId, intptr_t outBuffer, int32_t inOutBufferLength)
{
	return EOS_ProductUserId_ToString(accountId, outBuffer, inOutBufferLength);
}

DNNE_EXTERN_C DNNE_API intptr_t DNNE_CALLTYPE_STDCALL EOS_GetVersion(void)
{
	return _EOS_GetVersion();
}

DNNE_EXTERN_C DNNE_API int32_t DNNE_CALLTYPE_STDCALL EOS_Platform_CheckForLauncherAndRestart(intptr_t handle)
{
	return _EOS_Platform_CheckForLauncherAndRestart(handle);
}

DNNE_EXTERN_C DNNE_API intptr_t DNNE_CALLTYPE_STDCALL EOS_Platform_Create(intptr_t options)
{
	return _EOS_Platform_Create(options);
}

DNNE_EXTERN_C DNNE_API intptr_t DNNE_CALLTYPE_STDCALL EOS_Platform_GetAchievementsInterface(intptr_t handle)
{
	return _EOS_Platform_GetAchievementsInterface(handle);
}

DNNE_EXTERN_C DNNE_API int32_t DNNE_CALLTYPE_STDCALL EOS_Platform_GetActiveCountryCode(intptr_t handle, intptr_t localUserId, intptr_t outBuffer, int32_t inOutBufferLength)
{
	return _EOS_Platform_GetActiveCountryCode(handle, localUserId, outBuffer, inOutBufferLength);
}

DNNE_EXTERN_C DNNE_API int32_t DNNE_CALLTYPE_STDCALL EOS_Platform_GetActiveLocaleCode(intptr_t handle, intptr_t localUserId, intptr_t outBuffer, int32_t inOutBufferLength)
{
	return _EOS_Platform_GetActiveLocaleCode(handle, localUserId, outBuffer, inOutBufferLength);
}

DNNE_EXTERN_C DNNE_API intptr_t DNNE_CALLTYPE_STDCALL EOS_Platform_GetAntiCheatClientInterface(intptr_t handle)
{
	return _EOS_Platform_GetAntiCheatClientInterface(handle);
}

DNNE_EXTERN_C DNNE_API intptr_t DNNE_CALLTYPE_STDCALL EOS_Platform_GetAntiCheatServerInterface(intptr_t handle)
{
	return _EOS_Platform_GetAntiCheatServerInterface(handle);
}

DNNE_EXTERN_C DNNE_API int32_t DNNE_CALLTYPE_STDCALL EOS_Platform_GetApplicationStatus(intptr_t handle)
{
	return _EOS_Platform_GetApplicationStatus(handle);
}

DNNE_EXTERN_C DNNE_API intptr_t DNNE_CALLTYPE_STDCALL EOS_Platform_GetAuthInterface(intptr_t handle)
{
	return _EOS_Platform_GetAuthInterface(handle);
}

DNNE_EXTERN_C DNNE_API intptr_t DNNE_CALLTYPE_STDCALL EOS_Platform_GetConnectInterface(intptr_t handle)
{
	return _EOS_Platform_GetConnectInterface(handle);
}

DNNE_EXTERN_C DNNE_API intptr_t DNNE_CALLTYPE_STDCALL EOS_Platform_GetCustomInvitesInterface(intptr_t handle)
{
	return _EOS_Platform_GetCustomInvitesInterface(handle);
}

DNNE_EXTERN_C DNNE_API int32_t DNNE_CALLTYPE_STDCALL EOS_Platform_GetDesktopCrossplayStatus(intptr_t handle, intptr_t options, intptr_t outDesktopCrossplayStatusInfo)
{
	return _EOS_Platform_GetDesktopCrossplayStatus(handle, options, outDesktopCrossplayStatusInfo);
}

DNNE_EXTERN_C DNNE_API intptr_t DNNE_CALLTYPE_STDCALL EOS_Platform_GetEcomInterface(intptr_t handle)
{
	return _EOS_Platform_GetEcomInterface(handle);
}

DNNE_EXTERN_C DNNE_API intptr_t DNNE_CALLTYPE_STDCALL EOS_Platform_GetFriendsInterface(intptr_t handle)
{
	return _EOS_Platform_GetFriendsInterface(handle);
}

DNNE_EXTERN_C DNNE_API intptr_t DNNE_CALLTYPE_STDCALL EOS_Platform_GetIntegratedPlatformInterface(intptr_t handle)
{
	return _EOS_Platform_GetIntegratedPlatformInterface(handle);
}

DNNE_EXTERN_C DNNE_API intptr_t DNNE_CALLTYPE_STDCALL EOS_Platform_GetKWSInterface(intptr_t handle)
{
	return _EOS_Platform_GetKWSInterface(handle);
}

DNNE_EXTERN_C DNNE_API intptr_t DNNE_CALLTYPE_STDCALL EOS_Platform_GetLeaderboardsInterface(intptr_t handle)
{
	return _EOS_Platform_GetLeaderboardsInterface(handle);
}

DNNE_EXTERN_C DNNE_API intptr_t DNNE_CALLTYPE_STDCALL EOS_Platform_GetLobbyInterface(intptr_t handle)
{
	return _EOS_Platform_GetLobbyInterface(handle);
}

DNNE_EXTERN_C DNNE_API intptr_t DNNE_CALLTYPE_STDCALL EOS_Platform_GetMetricsInterface(intptr_t handle)
{
	return _EOS_Platform_GetMetricsInterface(handle);
}

DNNE_EXTERN_C DNNE_API intptr_t DNNE_CALLTYPE_STDCALL EOS_Platform_GetModsInterface(intptr_t handle)
{
	return _EOS_Platform_GetModsInterface(handle);
}

DNNE_EXTERN_C DNNE_API int32_t DNNE_CALLTYPE_STDCALL EOS_Platform_GetNetworkStatus(intptr_t handle)
{
	return _EOS_Platform_GetNetworkStatus(handle);
}

DNNE_EXTERN_C DNNE_API int32_t DNNE_CALLTYPE_STDCALL EOS_Platform_GetOverrideCountryCode(intptr_t handle, intptr_t outBuffer, int32_t inOutBufferLength)
{
	return _EOS_Platform_GetOverrideCountryCode(handle, outBuffer, inOutBufferLength);
}

DNNE_EXTERN_C DNNE_API int32_t DNNE_CALLTYPE_STDCALL EOS_Platform_GetOverrideLocaleCode(intptr_t handle, intptr_t outBuffer, int32_t inOutBufferLength)
{
	return _EOS_Platform_GetOverrideLocaleCode(handle, outBuffer, inOutBufferLength);
}

DNNE_EXTERN_C DNNE_API intptr_t DNNE_CALLTYPE_STDCALL EOS_Platform_GetP2PInterface(intptr_t handle)
{
	return _EOS_Platform_GetP2PInterface(handle);
}

DNNE_EXTERN_C DNNE_API intptr_t DNNE_CALLTYPE_STDCALL EOS_Platform_GetPlayerDataStorageInterface(intptr_t handle)
{
	return _EOS_Platform_GetPlayerDataStorageInterface(handle);
}

DNNE_EXTERN_C DNNE_API intptr_t DNNE_CALLTYPE_STDCALL EOS_Platform_GetPresenceInterface(intptr_t handle)
{
	return _EOS_Platform_GetPresenceInterface(handle);
}

DNNE_EXTERN_C DNNE_API intptr_t DNNE_CALLTYPE_STDCALL EOS_Platform_GetProgressionSnapshotInterface(intptr_t handle)
{
	return _EOS_Platform_GetProgressionSnapshotInterface(handle);
}

DNNE_EXTERN_C DNNE_API intptr_t DNNE_CALLTYPE_STDCALL EOS_Platform_GetRTCAdminInterface(intptr_t handle)
{
	return _EOS_Platform_GetRTCAdminInterface(handle);
}

DNNE_EXTERN_C DNNE_API intptr_t DNNE_CALLTYPE_STDCALL EOS_Platform_GetRTCInterface(intptr_t handle)
{
	return _EOS_Platform_GetRTCInterface(handle);
}

DNNE_EXTERN_C DNNE_API intptr_t DNNE_CALLTYPE_STDCALL EOS_Platform_GetReportsInterface(intptr_t handle)
{
	return _EOS_Platform_GetReportsInterface(handle);
}

DNNE_EXTERN_C DNNE_API intptr_t DNNE_CALLTYPE_STDCALL EOS_Platform_GetSanctionsInterface(intptr_t handle)
{
	return _EOS_Platform_GetSanctionsInterface(handle);
}

DNNE_EXTERN_C DNNE_API intptr_t DNNE_CALLTYPE_STDCALL EOS_Platform_GetSessionsInterface(intptr_t handle)
{
	return _EOS_Platform_GetSessionsInterface(handle);
}

DNNE_EXTERN_C DNNE_API intptr_t DNNE_CALLTYPE_STDCALL EOS_Platform_GetStatsInterface(intptr_t handle)
{
	return _EOS_Platform_GetStatsInterface(handle);
}

DNNE_EXTERN_C DNNE_API intptr_t DNNE_CALLTYPE_STDCALL EOS_Platform_GetTitleStorageInterface(intptr_t handle)
{
	return _EOS_Platform_GetTitleStorageInterface(handle);
}

DNNE_EXTERN_C DNNE_API intptr_t DNNE_CALLTYPE_STDCALL EOS_Platform_GetUIInterface(intptr_t handle)
{
	return _EOS_Platform_GetUIInterface(handle);
}

DNNE_EXTERN_C DNNE_API intptr_t DNNE_CALLTYPE_STDCALL EOS_Platform_GetUserInfoInterface(intptr_t handle)
{
	return _EOS_Platform_GetUserInfoInterface(handle);
}

DNNE_EXTERN_C DNNE_API void DNNE_CALLTYPE_STDCALL EOS_Platform_Release(intptr_t handle)
{
	_EOS_Platform_Release(handle);
}

DNNE_EXTERN_C DNNE_API int32_t DNNE_CALLTYPE_STDCALL EOS_Platform_SetApplicationStatus(intptr_t handle, int32_t newStatus)
{
	return _EOS_Platform_SetApplicationStatus(handle, newStatus);
}

DNNE_EXTERN_C DNNE_API int32_t DNNE_CALLTYPE_STDCALL EOS_Platform_SetNetworkStatus(intptr_t handle, int32_t newStatus)
{
	return _EOS_Platform_SetNetworkStatus(handle, newStatus);
}

DNNE_EXTERN_C DNNE_API int32_t DNNE_CALLTYPE_STDCALL EOS_Platform_SetOverrideCountryCode(intptr_t handle, intptr_t newCountryCode)
{
	return _EOS_Platform_SetOverrideCountryCode(handle, newCountryCode);
}

DNNE_EXTERN_C DNNE_API int32_t DNNE_CALLTYPE_STDCALL EOS_Platform_SetOverrideLocaleCode(intptr_t handle, intptr_t newLocaleCode)
{
	return _EOS_Platform_SetOverrideLocaleCode(handle, newLocaleCode);
}

DNNE_EXTERN_C DNNE_API void DNNE_CALLTYPE_STDCALL EOS_Platform_Tick(intptr_t handle)
{
	_EOS_Platform_Tick(handle);
}

DNNE_EXTERN_C DNNE_API int32_t DNNE_CALLTYPE_STDCALL EOS_Logging_SetCallback(intptr_t callback)
{
	return EOS_Logging_SetCallback(callback);
}

DNNE_EXTERN_C DNNE_API int32_t DNNE_CALLTYPE_STDCALL EOS_Logging_SetLogLevel(int32_t logCategory, int32_t logLevel)
{
	return EOS_Logging_SetLogLevel(logCategory, logLevel);
}

DNNE_EXTERN_C DNNE_API uint64_t DNNE_CALLTYPE_STDCALL EOS_Connect_AddNotifyAuthExpiration(intptr_t handle, intptr_t options, intptr_t clientData, intptr_t notification)
{
	return EOS_Connect_AddNotifyAuthExpiration(handle, options, clientData, notification);
}

DNNE_EXTERN_C DNNE_API void DNNE_CALLTYPE_STDCALL EOS_Connect_RemoveNotifyAuthExpiration(intptr_t handle, uint64_t inId)
{
	EOS_Connect_RemoveNotifyAuthExpiration(handle, inId);
}

DNNE_EXTERN_C DNNE_API uint64_t DNNE_CALLTYPE_STDCALL EOS_Connect_AddNotifyLoginStatusChanged(intptr_t handle, intptr_t options, intptr_t clientData, intptr_t notification)
{
	return EOS_Connect_AddNotifyLoginStatusChanged(handle, options, clientData, notification);
}

DNNE_EXTERN_C DNNE_API void DNNE_CALLTYPE_STDCALL EOS_Connect_RemoveNotifyLoginStatusChanged(intptr_t handle, uint64_t inId)
{
	EOS_Connect_RemoveNotifyLoginStatusChanged(handle, inId);
}

DNNE_EXTERN_C DNNE_API int32_t DNNE_CALLTYPE_STDCALL EOS_Connect_CopyIdToken(intptr_t handle, intptr_t options, intptr_t outIdToken)
{
	return EOS_Connect_CopyIdToken(handle, options, outIdToken);
}

DNNE_EXTERN_C DNNE_API void DNNE_CALLTYPE_STDCALL EOS_Connect_IdToken_Release(intptr_t idToken)
{
	EOS_Connect_IdToken_Release(idToken);
}

DNNE_EXTERN_C DNNE_API int32_t DNNE_CALLTYPE_STDCALL EOS_Connect_CopyProductUserExternalAccountByAccountId(intptr_t handle, intptr_t options, intptr_t outExternalAccountInfo)
{
	return EOS_Connect_CopyProductUserExternalAccountByAccountId(handle, options, outExternalAccountInfo);
}

DNNE_EXTERN_C DNNE_API int32_t DNNE_CALLTYPE_STDCALL EOS_Connect_CopyProductUserExternalAccountByAccountType(intptr_t handle, intptr_t options, intptr_t outExternalAccountInfo)
{
	return EOS_Connect_CopyProductUserExternalAccountByAccountType(handle, options, outExternalAccountInfo);
}

DNNE_EXTERN_C DNNE_API int32_t DNNE_CALLTYPE_STDCALL EOS_Connect_CopyProductUserExternalAccountByIndex(intptr_t handle, intptr_t options, intptr_t outExternalAccountInfo)
{
	return EOS_Connect_CopyProductUserExternalAccountByIndex(handle, options, outExternalAccountInfo);
}

DNNE_EXTERN_C DNNE_API int32_t DNNE_CALLTYPE_STDCALL EOS_Connect_CopyProductUserInfo(intptr_t handle, intptr_t options, intptr_t outExternalAccountInfo)
{
	return EOS_Connect_CopyProductUserInfo(handle, options, outExternalAccountInfo);
}

DNNE_EXTERN_C DNNE_API void DNNE_CALLTYPE_STDCALL EOS_Connect_ExternalAccountInfo_Release(intptr_t externalAccountInfo)
{
	EOS_Connect_ExternalAccountInfo_Release(externalAccountInfo);
}

DNNE_EXTERN_C DNNE_API void DNNE_CALLTYPE_STDCALL EOS_Connect_CreateDeviceId(intptr_t handle, intptr_t options, intptr_t clientData, intptr_t completionDelegate)
{
	EOS_Connect_CreateDeviceId(handle, options, clientData, completionDelegate);
}

DNNE_EXTERN_C DNNE_API void DNNE_CALLTYPE_STDCALL EOS_Connect_DeleteDeviceId(intptr_t handle, intptr_t options, intptr_t clientData, intptr_t completionDelegate)
{
	EOS_Connect_DeleteDeviceId(handle, options, clientData, completionDelegate);
}

DNNE_EXTERN_C DNNE_API intptr_t DNNE_CALLTYPE_STDCALL EOS_Connect_GetExternalAccountMapping(intptr_t handle, intptr_t options)
{
	return EOS_Connect_GetExternalAccountMapping(handle, options);
}

DNNE_EXTERN_C DNNE_API intptr_t DNNE_CALLTYPE_STDCALL EOS_Connect_GetLoggedInUserByIndex(intptr_t handle, int32_t index)
{
	return EOS_Connect_GetLoggedInUserByIndex(handle, index);
}

DNNE_EXTERN_C DNNE_API int32_t DNNE_CALLTYPE_STDCALL EOS_Connect_GetLoggedInUsersCount(intptr_t handle)
{
	return EOS_Connect_GetLoggedInUsersCount(handle);
}

DNNE_EXTERN_C DNNE_API int32_t DNNE_CALLTYPE_STDCALL EOS_Connect_GetLoginStatus(intptr_t handle, intptr_t localUserId)
{
	return EOS_Connect_GetLoginStatus(handle, localUserId);
}

DNNE_EXTERN_C DNNE_API uint32_t DNNE_CALLTYPE_STDCALL EOS_Connect_GetProductUserExternalAccountCount(intptr_t handle, intptr_t options)
{
	return EOS_Connect_GetProductUserExternalAccountCount(handle, options);
}

DNNE_EXTERN_C DNNE_API int32_t DNNE_CALLTYPE_STDCALL EOS_Connect_GetProductUserIdMapping(intptr_t handle, intptr_t options, intptr_t outBuffer, int32_t inOutBufferLength)
{
	return EOS_Connect_GetProductUserIdMapping(handle, options, outBuffer, inOutBufferLength);
}

DNNE_EXTERN_C DNNE_API void DNNE_CALLTYPE_STDCALL EOS_Connect_QueryExternalAccountMappings(intptr_t handle, intptr_t options, intptr_t clientData, intptr_t completionDelegate)
{
	EOS_Connect_QueryExternalAccountMappings(handle, options, clientData, completionDelegate);
}

DNNE_EXTERN_C DNNE_API void DNNE_CALLTYPE_STDCALL EOS_Connect_QueryProductUserIdMappings(intptr_t handle, intptr_t options, intptr_t clientData, intptr_t completionDelegate)
{
	EOS_Connect_QueryProductUserIdMappings(handle, options, clientData, completionDelegate);
}

DNNE_EXTERN_C DNNE_API void DNNE_CALLTYPE_STDCALL EOS_Connect_LinkAccount(intptr_t handle, intptr_t options, intptr_t clientData, intptr_t completionDelegate)
{
	EOS_Connect_LinkAccount(handle, options, clientData, completionDelegate);
}

DNNE_EXTERN_C DNNE_API void DNNE_CALLTYPE_STDCALL EOS_Connect_UnlinkAccount(intptr_t handle, intptr_t options, intptr_t clientData, intptr_t completionDelegate)
{
	EOS_Connect_UnlinkAccount(handle, options, clientData, completionDelegate);
}

DNNE_EXTERN_C DNNE_API void DNNE_CALLTYPE_STDCALL EOS_Connect_CreateUser(intptr_t handle, intptr_t options, intptr_t clientData, intptr_t completionDelegate)
{
	EOS_Connect_CreateUser(handle, options, clientData, completionDelegate);
}

DNNE_EXTERN_C DNNE_API void DNNE_CALLTYPE_STDCALL EOS_Connect_Login(intptr_t handle, intptr_t options, intptr_t clientData, intptr_t completionDelegate)
{
	EOS_Connect_Login(handle, options, clientData, completionDelegate);
}

DNNE_EXTERN_C DNNE_API void DNNE_CALLTYPE_STDCALL EOS_Connect_TransferDeviceIdAccount(intptr_t handle, intptr_t options, intptr_t clientData, intptr_t completionDelegate)
{
	EOS_Connect_TransferDeviceIdAccount(handle, options, clientData, completionDelegate);
}

DNNE_EXTERN_C DNNE_API void DNNE_CALLTYPE_STDCALL EOS_Connect_VerifyIdToken(intptr_t handle, intptr_t options, intptr_t clientData, intptr_t completionDelegate)
{
	EOS_Connect_VerifyIdToken(handle, options, clientData, completionDelegate);
}

DNNE_EXTERN_C DNNE_API uint64_t DNNE_CALLTYPE_STDCALL EOS_Auth_AddNotifyLoginStatusChanged(intptr_t handle, intptr_t options, intptr_t clientData, intptr_t notification)
{
	return _EOS_Auth_AddNotifyLoginStatusChanged(handle, options, clientData, notification);
}

DNNE_EXTERN_C DNNE_API void DNNE_CALLTYPE_STDCALL EOS_Auth_RemoveNotifyLoginStatusChanged(intptr_t handle, uint64_t inId)
{
	_EOS_Auth_RemoveNotifyLoginStatusChanged(handle, inId);
}

DNNE_EXTERN_C DNNE_API int32_t DNNE_CALLTYPE_STDCALL EOS_Auth_CopyIdToken(intptr_t handle, intptr_t options, intptr_t outIdToken)
{
	return _EOS_Auth_CopyIdToken(handle, options, outIdToken);
}

DNNE_EXTERN_C DNNE_API void DNNE_CALLTYPE_STDCALL EOS_Auth_QueryIdToken(intptr_t handle, intptr_t options, intptr_t clientData, intptr_t completionDelegate)
{
	_EOS_Auth_QueryIdToken(handle, options, clientData, completionDelegate);
}

DNNE_EXTERN_C DNNE_API void DNNE_CALLTYPE_STDCALL EOS_Auth_IdToken_Release(intptr_t idToken)
{
	_EOS_Auth_IdToken_Release(idToken);
}

DNNE_EXTERN_C DNNE_API int32_t DNNE_CALLTYPE_STDCALL EOS_Auth_CopyUserAuthToken(intptr_t handle, intptr_t options, intptr_t localUserId, intptr_t outUserAuthToken)
{
	return _EOS_Auth_CopyUserAuthToken(handle, options, localUserId, outUserAuthToken);
}

DNNE_EXTERN_C DNNE_API void DNNE_CALLTYPE_STDCALL EOS_Auth_Token_Release(intptr_t authToken)
{
	_EOS_Auth_Token_Release(authToken);
}

DNNE_EXTERN_C DNNE_API intptr_t DNNE_CALLTYPE_STDCALL EOS_Auth_GetLoggedInAccountByIndex(intptr_t handle, int32_t index)
{
	return _EOS_Auth_GetLoggedInAccountByIndex(handle, index);
}

DNNE_EXTERN_C DNNE_API int32_t DNNE_CALLTYPE_STDCALL EOS_Auth_GetLoggedInAccountsCount(intptr_t handle)
{
	return _EOS_Auth_GetLoggedInAccountsCount(handle);
}

DNNE_EXTERN_C DNNE_API intptr_t DNNE_CALLTYPE_STDCALL EOS_Auth_GetMergedAccountByIndex(intptr_t handle, intptr_t localUserId, uint32_t index)
{
	return _EOS_Auth_GetMergedAccountByIndex(handle, localUserId, index);
}

DNNE_EXTERN_C DNNE_API uint32_t DNNE_CALLTYPE_STDCALL EOS_Auth_GetMergedAccountsCount(intptr_t handle, intptr_t localUserId)
{
	return _EOS_Auth_GetMergedAccountsCount(handle, localUserId);
}

DNNE_EXTERN_C DNNE_API void DNNE_CALLTYPE_STDCALL EOS_Auth_LinkAccount(intptr_t handle, intptr_t options, intptr_t clientData, intptr_t completionDelegate)
{
	_EOS_Auth_LinkAccount(handle, options, clientData, completionDelegate);
}

DNNE_EXTERN_C DNNE_API void DNNE_CALLTYPE_STDCALL EOS_Auth_Login(intptr_t handle, intptr_t options, intptr_t clientData, intptr_t completionDelegate)
{
	_EOS_Auth_Login(handle, options, clientData, completionDelegate);
}

DNNE_EXTERN_C DNNE_API void DNNE_CALLTYPE_STDCALL EOS_Auth_Logout(intptr_t handle, intptr_t options, intptr_t clientData, intptr_t completionDelegate)
{
	_EOS_Auth_Logout(handle, options, clientData, completionDelegate);
}

DNNE_EXTERN_C DNNE_API void DNNE_CALLTYPE_STDCALL EOS_Auth_VerifyIdToken(intptr_t handle, intptr_t options, intptr_t clientData, intptr_t completionDelegate)
{
	_EOS_Auth_VerifyIdToken(handle, options, clientData, completionDelegate);
}

DNNE_EXTERN_C DNNE_API void DNNE_CALLTYPE_STDCALL EOS_Auth_VerifyUserAuth(intptr_t handle, intptr_t options, intptr_t clientData, intptr_t completionDelegate)
{
	_EOS_Auth_VerifyUserAuth(handle, options, clientData, completionDelegate);
}

DNNE_EXTERN_C DNNE_API int32_t DNNE_CALLTYPE_STDCALL EOS_Auth_GetSelectedAccountId(intptr_t handle, intptr_t localUserId, intptr_t outSelectedAccountId)
{
	return _EOS_Auth_GetSelectedAccountId(handle, localUserId, outSelectedAccountId);
}

DNNE_EXTERN_C DNNE_API int32_t DNNE_CALLTYPE_STDCALL EOS_Auth_GetLoginStatus(intptr_t handle, intptr_t localUserId)
{
	return _EOS_Auth_GetLoginStatus(handle, localUserId);
}

DNNE_EXTERN_C DNNE_API void DNNE_CALLTYPE_STDCALL EOS_Auth_DeletePersistentAuth(intptr_t handle, intptr_t options, intptr_t clientData, intptr_t completionDelegate)
{
	_EOS_Auth_DeletePersistentAuth(handle, options, clientData, completionDelegate);
}

DNNE_EXTERN_C DNNE_API uint64_t DNNE_CALLTYPE_STDCALL EOS_AntiCheatServer_AddNotifyClientActionRequired(intptr_t handle, intptr_t options, intptr_t clientData, intptr_t notificationFn)
{
	return _EOS_AntiCheatServer_AddNotifyClientActionRequired(handle, options, clientData, notificationFn);
}

DNNE_EXTERN_C DNNE_API uint64_t DNNE_CALLTYPE_STDCALL EOS_AntiCheatServer_AddNotifyClientAuthStatusChanged(intptr_t handle, intptr_t options, intptr_t clientData, intptr_t notificationFn)
{
	return _EOS_AntiCheatServer_AddNotifyClientAuthStatusChanged(handle, options, clientData, notificationFn);
}

DNNE_EXTERN_C DNNE_API uint64_t DNNE_CALLTYPE_STDCALL EOS_AntiCheatServer_AddNotifyMessageToClient(intptr_t handle, intptr_t options, intptr_t clientData, intptr_t notificationFn)
{
	return _EOS_AntiCheatServer_AddNotifyMessageToClient(handle, options, clientData, notificationFn);
}

DNNE_EXTERN_C DNNE_API int32_t DNNE_CALLTYPE_STDCALL EOS_AntiCheatServer_BeginSession(intptr_t handle, intptr_t options)
{
	return _EOS_AntiCheatServer_BeginSession(handle, options);
}

DNNE_EXTERN_C DNNE_API int32_t DNNE_CALLTYPE_STDCALL EOS_AntiCheatServer_EndSession(intptr_t handle, intptr_t options)
{
	return _EOS_AntiCheatServer_EndSession(handle, options);
}

DNNE_EXTERN_C DNNE_API int32_t DNNE_CALLTYPE_STDCALL EOS_AntiCheatServer_GetProtectMessageOutputLength(intptr_t handle, intptr_t options, uint32_t outBufferSizeBytes)
{
	return _EOS_AntiCheatServer_GetProtectMessageOutputLength(handle, options, outBufferSizeBytes);
}

DNNE_EXTERN_C DNNE_API int32_t DNNE_CALLTYPE_STDCALL EOS_AntiCheatServer_LogEvent(intptr_t handle, intptr_t options)
{
	return _EOS_AntiCheatServer_LogEvent(handle, options);
}

DNNE_EXTERN_C DNNE_API int32_t DNNE_CALLTYPE_STDCALL EOS_AntiCheatServer_LogGameRoundEnd(intptr_t handle, intptr_t options)
{
	return _EOS_AntiCheatServer_LogGameRoundEnd(handle, options);
}

DNNE_EXTERN_C DNNE_API int32_t DNNE_CALLTYPE_STDCALL EOS_AntiCheatServer_LogGameRoundStart(intptr_t handle, intptr_t options)
{
	return _EOS_AntiCheatServer_LogGameRoundStart(handle, options);
}

DNNE_EXTERN_C DNNE_API int32_t DNNE_CALLTYPE_STDCALL EOS_AntiCheatServer_LogPlayerDespawn(intptr_t handle, intptr_t options)
{
	return _EOS_AntiCheatServer_LogPlayerDespawn(handle, options);
}

DNNE_EXTERN_C DNNE_API int32_t DNNE_CALLTYPE_STDCALL EOS_AntiCheatServer_LogPlayerRevive(intptr_t handle, intptr_t options)
{
	return _EOS_AntiCheatServer_LogPlayerRevive(handle, options);
}

DNNE_EXTERN_C DNNE_API int32_t DNNE_CALLTYPE_STDCALL EOS_AntiCheatServer_LogPlayerSpawn(intptr_t handle, intptr_t options)
{
	return _EOS_AntiCheatServer_LogPlayerSpawn(handle, options);
}

DNNE_EXTERN_C DNNE_API int32_t DNNE_CALLTYPE_STDCALL EOS_AntiCheatServer_LogPlayerTakeDamage(intptr_t handle, intptr_t options)
{
	return _EOS_AntiCheatServer_LogPlayerTakeDamage(handle, options);
}

DNNE_EXTERN_C DNNE_API int32_t DNNE_CALLTYPE_STDCALL EOS_AntiCheatServer_LogPlayerTick(intptr_t handle, intptr_t options)
{
	return _EOS_AntiCheatServer_LogPlayerTick(handle, options);
}

DNNE_EXTERN_C DNNE_API int32_t DNNE_CALLTYPE_STDCALL EOS_AntiCheatServer_LogPlayerUseAbility(intptr_t handle, intptr_t options)
{
	return _EOS_AntiCheatServer_LogPlayerUseAbility(handle, options);
}

DNNE_EXTERN_C DNNE_API int32_t DNNE_CALLTYPE_STDCALL EOS_AntiCheatServer_LogPlayerUseWeapon(intptr_t handle, intptr_t options)
{
	return _EOS_AntiCheatServer_LogPlayerUseWeapon(handle, options);
}

DNNE_EXTERN_C DNNE_API int32_t DNNE_CALLTYPE_STDCALL EOS_AntiCheatServer_ProtectMessage(intptr_t handle, intptr_t options, intptr_t outBuffer, uint32_t outBytesWritten)
{
	return _EOS_AntiCheatServer_ProtectMessage(handle, options, outBuffer, outBytesWritten);
}

DNNE_EXTERN_C DNNE_API int32_t DNNE_CALLTYPE_STDCALL EOS_AntiCheatServer_ReceiveMessageFromClient(intptr_t handle, intptr_t options)
{
	return _EOS_AntiCheatServer_ReceiveMessageFromClient(handle, options);
}

DNNE_EXTERN_C DNNE_API int32_t DNNE_CALLTYPE_STDCALL EOS_AntiCheatServer_RegisterClient(intptr_t handle, intptr_t options)
{
	return _EOS_AntiCheatServer_RegisterClient(handle, options);
}

DNNE_EXTERN_C DNNE_API int32_t DNNE_CALLTYPE_STDCALL EOS_AntiCheatServer_RegisterEvent(intptr_t handle, intptr_t options)
{
	return _EOS_AntiCheatServer_RegisterEvent(handle, options);
}

DNNE_EXTERN_C DNNE_API void DNNE_CALLTYPE_STDCALL EOS_AntiCheatServer_RemoveNotifyClientActionRequired(intptr_t handle, uint64_t notificationId)
{
	_EOS_AntiCheatServer_RemoveNotifyClientActionRequired(handle, notificationId);
}

DNNE_EXTERN_C DNNE_API void DNNE_CALLTYPE_STDCALL EOS_AntiCheatServer_RemoveNotifyClientAuthStatusChanged(intptr_t handle, uint64_t notificationId)
{
	_EOS_AntiCheatServer_RemoveNotifyClientAuthStatusChanged(handle, notificationId);
}

DNNE_EXTERN_C DNNE_API void DNNE_CALLTYPE_STDCALL EOS_AntiCheatServer_RemoveNotifyMessageToClient(intptr_t handle, uint64_t notificationId)
{
	_EOS_AntiCheatServer_RemoveNotifyMessageToClient(handle, notificationId);
}

DNNE_EXTERN_C DNNE_API int32_t DNNE_CALLTYPE_STDCALL EOS_AntiCheatServer_SetClientDetails(intptr_t handle, intptr_t options)
{
	return _EOS_AntiCheatServer_SetClientDetails(handle, options);
}

DNNE_EXTERN_C DNNE_API int32_t DNNE_CALLTYPE_STDCALL EOS_AntiCheatServer_SetClientNetworkState(intptr_t handle, intptr_t options)
{
	return _EOS_AntiCheatServer_SetClientNetworkState(handle, options);
}

DNNE_EXTERN_C DNNE_API int32_t DNNE_CALLTYPE_STDCALL EOS_AntiCheatServer_SetGameSessionId(intptr_t handle, intptr_t options)
{
	return _EOS_AntiCheatServer_SetGameSessionId(handle, options);
}

DNNE_EXTERN_C DNNE_API int32_t DNNE_CALLTYPE_STDCALL EOS_AntiCheatServer_UnprotectMessage(intptr_t handle, intptr_t options, intptr_t outBuffer, uint32_t outBytesWritten)
{
	return _EOS_AntiCheatServer_UnprotectMessage(handle, options, outBuffer, outBytesWritten);
}

DNNE_EXTERN_C DNNE_API int32_t DNNE_CALLTYPE_STDCALL EOS_AntiCheatServer_UnregisterClient(intptr_t handle, intptr_t options)
{
	return _EOS_AntiCheatServer_UnregisterClient(handle, options);
}

DNNE_EXTERN_C DNNE_API int32_t DNNE_CALLTYPE_STDCALL EOS_AntiCheatClient_AddExternalIntegrityCatalog(intptr_t handle, intptr_t options)
{
	return _EOS_AntiCheatClient_AddExternalIntegrityCatalog(handle, options);
}

DNNE_EXTERN_C DNNE_API uint64_t DNNE_CALLTYPE_STDCALL EOS_AntiCheatClient_AddNotifyClientIntegrityViolated(intptr_t handle, intptr_t options, intptr_t clientData, intptr_t notificationFn)
{
	return _EOS_AntiCheatClient_AddNotifyClientIntegrityViolated(handle, options, clientData, notificationFn);
}

DNNE_EXTERN_C DNNE_API uint64_t DNNE_CALLTYPE_STDCALL EOS_AntiCheatClient_AddNotifyMessageToPeer(intptr_t handle, intptr_t options, intptr_t clientData, intptr_t notificationFn)
{
	return _EOS_AntiCheatClient_AddNotifyMessageToPeer(handle, options, clientData, notificationFn);
}

DNNE_EXTERN_C DNNE_API uint64_t DNNE_CALLTYPE_STDCALL EOS_AntiCheatClient_AddNotifyMessageToServer(intptr_t handle, intptr_t options, intptr_t clientData, intptr_t notificationFn)
{
	return _EOS_AntiCheatClient_AddNotifyMessageToServer(handle, options, clientData, notificationFn);
}

DNNE_EXTERN_C DNNE_API uint64_t DNNE_CALLTYPE_STDCALL EOS_AntiCheatClient_AddNotifyPeerActionRequired(intptr_t handle, intptr_t options, intptr_t clientData, intptr_t notificationFn)
{
	return _EOS_AntiCheatClient_AddNotifyPeerActionRequired(handle, options, clientData, notificationFn);
}

DNNE_EXTERN_C DNNE_API uint64_t DNNE_CALLTYPE_STDCALL EOS_AntiCheatClient_AddNotifyPeerAuthStatusChanged(intptr_t handle, intptr_t options, intptr_t clientData, intptr_t notificationFn)
{
	return _EOS_AntiCheatClient_AddNotifyPeerAuthStatusChanged(handle, options, clientData, notificationFn);
}

DNNE_EXTERN_C DNNE_API int32_t DNNE_CALLTYPE_STDCALL EOS_AntiCheatClient_BeginSession(intptr_t handle, intptr_t options)
{
	return _EOS_AntiCheatClient_BeginSession(handle, options);
}

DNNE_EXTERN_C DNNE_API int32_t DNNE_CALLTYPE_STDCALL EOS_AntiCheatClient_EndSession(intptr_t handle, intptr_t options)
{
	return _EOS_AntiCheatClient_EndSession(handle, options);
}

DNNE_EXTERN_C DNNE_API int32_t DNNE_CALLTYPE_STDCALL EOS_AntiCheatClient_GetProtectMessageOutputLength(intptr_t handle, intptr_t options, uint32_t outBufferSizeBytes)
{
	return _EOS_AntiCheatClient_GetProtectMessageOutputLength(handle, options, outBufferSizeBytes);
}

DNNE_EXTERN_C DNNE_API int32_t DNNE_CALLTYPE_STDCALL EOS_AntiCheatClient_PollStatus(intptr_t handle, intptr_t options, int32_t outViolationType, intptr_t outMessage)
{
	return _EOS_AntiCheatClient_PollStatus(handle, options, outViolationType, outMessage);
}

DNNE_EXTERN_C DNNE_API int32_t DNNE_CALLTYPE_STDCALL EOS_AntiCheatClient_ProtectMessage(intptr_t handle, intptr_t options, intptr_t outBuffer, uint32_t outBytesWritten)
{
	return _EOS_AntiCheatClient_ProtectMessage(handle, options, outBuffer, outBytesWritten);
}

DNNE_EXTERN_C DNNE_API int32_t DNNE_CALLTYPE_STDCALL EOS_AntiCheatClient_ReceiveMessageFromPeer(intptr_t handle, intptr_t options)
{
	return _EOS_AntiCheatClient_ReceiveMessageFromPeer(handle, options);
}

DNNE_EXTERN_C DNNE_API int32_t DNNE_CALLTYPE_STDCALL EOS_AntiCheatClient_ReceiveMessageFromServer(intptr_t handle, intptr_t options)
{
	return _EOS_AntiCheatClient_ReceiveMessageFromServer(handle, options);
}

DNNE_EXTERN_C DNNE_API int32_t DNNE_CALLTYPE_STDCALL EOS_AntiCheatClient_RegisterPeer(intptr_t handle, intptr_t options)
{
	return _EOS_AntiCheatClient_RegisterPeer(handle, options);
}

DNNE_EXTERN_C DNNE_API void DNNE_CALLTYPE_STDCALL EOS_AntiCheatClient_RemoveNotifyClientIntegrityViolated(intptr_t handle, uint64_t notificationId)
{
	_EOS_AntiCheatClient_RemoveNotifyClientIntegrityViolated(handle, notificationId);
}

DNNE_EXTERN_C DNNE_API void DNNE_CALLTYPE_STDCALL EOS_AntiCheatClient_RemoveNotifyMessageToPeer(intptr_t handle, uint64_t notificationId)
{
	_EOS_AntiCheatClient_RemoveNotifyMessageToPeer(handle, notificationId);
}

DNNE_EXTERN_C DNNE_API void DNNE_CALLTYPE_STDCALL EOS_AntiCheatClient_RemoveNotifyMessageToServer(intptr_t handle, uint64_t notificationId)
{
	_EOS_AntiCheatClient_RemoveNotifyMessageToServer(handle, notificationId);
}

DNNE_EXTERN_C DNNE_API void DNNE_CALLTYPE_STDCALL EOS_AntiCheatClient_RemoveNotifyPeerActionRequired(intptr_t handle, uint64_t notificationId)
{
	_EOS_AntiCheatClient_RemoveNotifyPeerActionRequired(handle, notificationId);
}

DNNE_EXTERN_C DNNE_API void DNNE_CALLTYPE_STDCALL EOS_AntiCheatClient_RemoveNotifyPeerAuthStatusChanged(intptr_t handle, uint64_t notificationId)
{
	_EOS_AntiCheatClient_RemoveNotifyPeerAuthStatusChanged(handle, notificationId);
}

DNNE_EXTERN_C DNNE_API int32_t DNNE_CALLTYPE_STDCALL EOS_AntiCheatClient_UnprotectMessage(intptr_t handle, intptr_t options, intptr_t outBuffer, uint32_t outBytesWritten)
{
	return _EOS_AntiCheatClient_UnprotectMessage(handle, options, outBuffer, outBytesWritten);
}

DNNE_EXTERN_C DNNE_API int32_t DNNE_CALLTYPE_STDCALL EOS_AntiCheatClient_UnregisterPeer(intptr_t handle, intptr_t options)
{
	return _EOS_AntiCheatClient_UnregisterPeer(handle, options);
}

DNNE_EXTERN_C DNNE_API int32_t DNNE_CALLTYPE_STDCALL EOS_ActiveSession_CopyInfo(intptr_t handle, intptr_t options, intptr_t outActiveSessionInfo)
{
	return _EOS_ActiveSession_CopyInfo(handle, options, outActiveSessionInfo);
}

DNNE_EXTERN_C DNNE_API intptr_t DNNE_CALLTYPE_STDCALL EOS_ActiveSession_GetRegisteredPlayerByIndex(intptr_t handle, intptr_t options)
{
	return _EOS_ActiveSession_GetRegisteredPlayerByIndex(handle, options);
}

DNNE_EXTERN_C DNNE_API uint32_t DNNE_CALLTYPE_STDCALL EOS_ActiveSession_GetRegisteredPlayerCount(intptr_t handle, intptr_t options)
{
	return _EOS_ActiveSession_GetRegisteredPlayerCount(handle, options);
}

DNNE_EXTERN_C DNNE_API void DNNE_CALLTYPE_STDCALL EOS_ActiveSession_Info_Release(intptr_t activeSessionInfo)
{
	_EOS_ActiveSession_Info_Release(activeSessionInfo);
}

DNNE_EXTERN_C DNNE_API void DNNE_CALLTYPE_STDCALL EOS_ActiveSession_Release(intptr_t activeSessionHandle)
{
	_EOS_ActiveSession_Release(activeSessionHandle);
}

DNNE_EXTERN_C DNNE_API uint64_t DNNE_CALLTYPE_STDCALL EOS_Achievements_AddNotifyAchievementsUnlocked(intptr_t handle, intptr_t options, intptr_t clientData, intptr_t notificationFn)
{
	return _EOS_Achievements_AddNotifyAchievementsUnlocked(handle, options, clientData, notificationFn);
}

DNNE_EXTERN_C DNNE_API uint64_t DNNE_CALLTYPE_STDCALL EOS_Achievements_AddNotifyAchievementsUnlockedV2(intptr_t handle, intptr_t options, intptr_t clientData, intptr_t notificationFn)
{
	return _EOS_Achievements_AddNotifyAchievementsUnlockedV2(handle, options, clientData, notificationFn);
}

DNNE_EXTERN_C DNNE_API void DNNE_CALLTYPE_STDCALL EOS_Achievements_RemoveNotifyAchievementsUnlocked(intptr_t handle, uint64_t inId)
{
	_EOS_Achievements_RemoveNotifyAchievementsUnlocked(handle, inId);
}

DNNE_EXTERN_C DNNE_API int32_t DNNE_CALLTYPE_STDCALL EOS_Achievements_CopyAchievementDefinitionByAchievementId(intptr_t handle, intptr_t options, intptr_t outDefinition)
{
	return _EOS_Achievements_CopyAchievementDefinitionByAchievementId(handle, options, outDefinition);
}

DNNE_EXTERN_C DNNE_API int32_t DNNE_CALLTYPE_STDCALL EOS_Achievements_CopyAchievementDefinitionByIndex(intptr_t handle, intptr_t options, intptr_t outDefinition)
{
	return _EOS_Achievements_CopyAchievementDefinitionByIndex(handle, options, outDefinition);
}

DNNE_EXTERN_C DNNE_API void DNNE_CALLTYPE_STDCALL EOS_Achievements_Definition_Release(intptr_t achievementDefinition)
{
	_EOS_Achievements_Definition_Release(achievementDefinition);
}

DNNE_EXTERN_C DNNE_API int32_t DNNE_CALLTYPE_STDCALL EOS_Achievements_CopyAchievementDefinitionV2ByAchievementId(intptr_t handle, intptr_t options, intptr_t outDefinition)
{
	return _EOS_Achievements_CopyAchievementDefinitionV2ByAchievementId(handle, options, outDefinition);
}

DNNE_EXTERN_C DNNE_API int32_t DNNE_CALLTYPE_STDCALL EOS_Achievements_CopyAchievementDefinitionV2ByIndex(intptr_t handle, intptr_t options, intptr_t outDefinition)
{
	return _EOS_Achievements_CopyAchievementDefinitionV2ByIndex(handle, options, outDefinition);
}

DNNE_EXTERN_C DNNE_API void DNNE_CALLTYPE_STDCALL EOS_Achievements_DefinitionV2_Release(intptr_t achievementDefinition)
{
	_EOS_Achievements_DefinitionV2_Release(achievementDefinition);
}

DNNE_EXTERN_C DNNE_API int32_t DNNE_CALLTYPE_STDCALL EOS_Achievements_CopyPlayerAchievementByAchievementId(intptr_t handle, intptr_t options, intptr_t outAchievement)
{
	return _EOS_Achievements_CopyPlayerAchievementByAchievementId(handle, options, outAchievement);
}

DNNE_EXTERN_C DNNE_API int32_t DNNE_CALLTYPE_STDCALL EOS_Achievements_CopyPlayerAchievementByIndex(intptr_t handle, intptr_t options, intptr_t outAchievement)
{
	return _EOS_Achievements_CopyPlayerAchievementByIndex(handle, options, outAchievement);
}

DNNE_EXTERN_C DNNE_API void DNNE_CALLTYPE_STDCALL EOS_Achievements_PlayerAchievement_Release(intptr_t achievement)
{
	_EOS_Achievements_PlayerAchievement_Release(achievement);
}

DNNE_EXTERN_C DNNE_API uint32_t DNNE_CALLTYPE_STDCALL EOS_Achievements_GetAchievementDefinitionCount(intptr_t handle, intptr_t options)
{
	return _EOS_Achievements_GetAchievementDefinitionCount(handle, options);
}

DNNE_EXTERN_C DNNE_API uint32_t DNNE_CALLTYPE_STDCALL EOS_Achievements_GetPlayerAchievementCount(intptr_t handle, intptr_t options)
{
	return _EOS_Achievements_GetPlayerAchievementCount(handle, options);
}

DNNE_EXTERN_C DNNE_API uint32_t DNNE_CALLTYPE_STDCALL EOS_Achievements_GetUnlockedAchievementCount(intptr_t handle, intptr_t options)
{
	return _EOS_Achievements_GetUnlockedAchievementCount(handle, options);
}

DNNE_EXTERN_C DNNE_API void DNNE_CALLTYPE_STDCALL EOS_Achievements_QueryDefinitions(intptr_t handle, intptr_t options, intptr_t clientData, intptr_t completionDelegate)
{
	_EOS_Achievements_QueryDefinitions(handle, options, clientData, completionDelegate);
}

DNNE_EXTERN_C DNNE_API void DNNE_CALLTYPE_STDCALL EOS_Achievements_QueryPlayerAchievements(intptr_t handle, intptr_t options, intptr_t clientData, intptr_t completionDelegate)
{
	_EOS_Achievements_QueryPlayerAchievements(handle, options, clientData, completionDelegate);
}

DNNE_EXTERN_C DNNE_API void DNNE_CALLTYPE_STDCALL EOS_Achievements_UnlockAchievements(intptr_t handle, intptr_t options, intptr_t clientData, intptr_t completionDelegate)
{
	_EOS_Achievements_UnlockAchievements(handle, options, clientData, completionDelegate);
}

DNNE_EXTERN_C DNNE_API int32_t DNNE_CALLTYPE_STDCALL EOS_Achievements_CopyUnlockedAchievementByAchievementId(intptr_t handle, intptr_t options, intptr_t outAchievement)
{
	return _EOS_Achievements_CopyUnlockedAchievementByAchievementId(handle, options, outAchievement);
}

DNNE_EXTERN_C DNNE_API int32_t DNNE_CALLTYPE_STDCALL EOS_Achievements_CopyUnlockedAchievementByIndex(intptr_t handle, intptr_t options, intptr_t outAchievement)
{
	return _EOS_Achievements_CopyUnlockedAchievementByIndex(handle, options, outAchievement);
}

DNNE_EXTERN_C DNNE_API void DNNE_CALLTYPE_STDCALL EOS_Achievements_UnlockedAchievement_Release(intptr_t achievement)
{
	_EOS_Achievements_UnlockedAchievement_Release(achievement);
}

