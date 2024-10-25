using EOS_SDK._Data;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace EOS_SDK.Achievements;

public unsafe class Achievements_Exports
{
    #region Notify
    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
    public static ulong EOS_Achievements_AddNotifyAchievementsUnlocked(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationFn)
    {
        _log.Logger.WriteDebug($"{nameof(EOS_Achievements_AddNotifyAchievementsUnlocked)} Called", Logging.LogCategory.Achievements);
        if (!EOS_Main.GetPlatform().CheckArgs(handle, options, notificationFn))
            return 0;
        var _AddNotifyAchievementsUnlockedOptions = Marshal.PtrToStructure<AddNotifyAchievementsUnlockedOptions>(options);
        OnAchievementsUnlockedCallbackInfo callbackInfo = new()
        { 
            ClientData = clientData
        };
        var id = NotifyManager.AddNotify("Ach_Unlocked", notificationFn, callbackInfo);
        return id;
    }

    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
    public static ulong EOS_Achievements_AddNotifyAchievementsUnlockedV2(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationFn)
    {
        _log.Logger.WriteDebug($"{nameof(EOS_Achievements_AddNotifyAchievementsUnlockedV2)} Called", Logging.LogCategory.Achievements);
        if (!EOS_Main.GetPlatform().CheckArgs(handle, options, notificationFn))
            return 0;
        var _AddNotifyAchievementsUnlockedV2Options = Marshal.PtrToStructure<AddNotifyAchievementsUnlockedV2Options>(options);
        OnAchievementsUnlockedCallbackV2Info callbackInfo = new()
        {
            ClientData = clientData
        };
        var id = NotifyManager.AddNotify("Ach_UnlockedV2", notificationFn, callbackInfo);
        return id;
    }

    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
    public static void EOS_Achievements_RemoveNotifyAchievementsUnlocked(IntPtr handle, ulong inId)
    {
        _log.Logger.WriteDebug($"{nameof(EOS_Achievements_RemoveNotifyAchievementsUnlocked)} Called", Logging.LogCategory.Achievements);
        var phandler = EOS_Main.GetPlatform().GetHandler<Achievements_Handler>(handle);
        if (phandler == null)
            return;
        NotifyManager.RemoveNotify(inId);
    }
    #endregion
    #region AchievementDefinition
    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
    public static int EOS_Achievements_CopyAchievementDefinitionByAchievementId(IntPtr handle, IntPtr options, IntPtr outDefinition)
    {
        _log.Logger.WriteDebug($"{nameof(EOS_Achievements_CopyAchievementDefinitionByAchievementId)} Called", Logging.LogCategory.Achievements);
        if (!EOS_Main.GetPlatform().CheckArgs(handle, options, outDefinition))
            return (int)Result.InvalidParameters;
        var phandler = EOS_Main.GetPlatform().GetHandler<Achievements_Handler>(handle);
        if (phandler == null)
            return (int)Result.InvalidParameters;
        var _CopyAchievementDefinitionByAchievementIdOptions = Marshal.PtrToStructure<CopyAchievementDefinitionByAchievementIdOptions>(options);
        if (!phandler.IsAchiExist(_CopyAchievementDefinitionByAchievementIdOptions.AchievementId))
            return (int)Result.NotFound;
        Definition definition = phandler.GetDefinition(_CopyAchievementDefinitionByAchievementIdOptions.AchievementId);
        Helpers.StructWriteOut(definition, outDefinition);
        return (int)Result.Success;
    }

    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
    public static int EOS_Achievements_CopyAchievementDefinitionByIndex(IntPtr handle, IntPtr options, IntPtr outDefinition)
    {
        _log.Logger.WriteDebug($"{nameof(EOS_Achievements_CopyAchievementDefinitionByIndex)} Called", Logging.LogCategory.Achievements);
        if (!EOS_Main.GetPlatform().CheckArgs(handle, options, outDefinition))
            return (int)Result.InvalidParameters;
        var phandler = EOS_Main.GetPlatform().GetHandler<Achievements_Handler>(handle);
        if (phandler == null)
            return (int)Result.InvalidParameters;
        var _CopyAchievementDefinitionByIndexOptions = Marshal.PtrToStructure<CopyAchievementDefinitionByIndexOptions>(options);
        if (!phandler.IsAchiExistIndex(_CopyAchievementDefinitionByIndexOptions.AchievementIndex))
            return (int)Result.NotFound;
        Definition definition = phandler.GetDefinitionIndex(_CopyAchievementDefinitionByIndexOptions.AchievementIndex);
        Helpers.StructWriteOut(definition, outDefinition);
        return (int)Result.Success;
    }

    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
    public static void EOS_Achievements_Definition_Release(IntPtr achievementDefinition)
    {
        _log.Logger.WriteDebug($"{nameof(EOS_Achievements_Definition_Release)} Called", Logging.LogCategory.Achievements);
        if (achievementDefinition == IntPtr.Zero)
            return;
        Definition def = Marshal.PtrToStructure<Definition>(achievementDefinition);
        Helpers.DestroyStructArray<StatThresholds>(def.StatThresholds, def.StatThresholdsCount);
        Helpers.Destroy<Definition>(achievementDefinition);
    }
    #endregion
    #region AchievementDefinitionV2
    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
    public static int EOS_Achievements_CopyAchievementDefinitionV2ByAchievementId(IntPtr handle, IntPtr options, IntPtr outDefinition)
    {
        _log.Logger.WriteDebug($"{nameof(EOS_Achievements_CopyAchievementDefinitionV2ByAchievementId)} Called", Logging.LogCategory.Achievements);
        if (!EOS_Main.GetPlatform().CheckArgs(handle, options, outDefinition))
            return (int)Result.InvalidParameters;
        var phandler = EOS_Main.GetPlatform().GetHandler<Achievements_Handler>(handle);
        if (phandler == null)
            return (int)Result.InvalidParameters;
        var _CopyAchievementDefinitionV2ByAchievementIdOptions = Marshal.PtrToStructure<CopyAchievementDefinitionV2ByAchievementIdOptions>(options);
        if (!phandler.IsAchiExist(_CopyAchievementDefinitionV2ByAchievementIdOptions.AchievementId))
            return (int)Result.NotFound;
        DefinitionV2 definition = phandler.GetDefinitionV2(_CopyAchievementDefinitionV2ByAchievementIdOptions.AchievementId);
        Helpers.StructWriteOut(definition, outDefinition);
        return (int)Result.Success;
    }

    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
    public static int EOS_Achievements_CopyAchievementDefinitionV2ByIndex(IntPtr handle, IntPtr options, IntPtr outDefinition)
    {
        _log.Logger.WriteDebug($"{nameof(EOS_Achievements_CopyAchievementDefinitionV2ByIndex)} Called", Logging.LogCategory.Achievements);
        if (!EOS_Main.GetPlatform().CheckArgs(handle, options, outDefinition))
            return (int)Result.InvalidParameters;
        var phandler = EOS_Main.GetPlatform().GetHandler<Achievements_Handler>(handle);
        if (phandler == null)
            return (int)Result.InvalidParameters;
        var _CopyAchievementDefinitionV2ByIndexOptions = Marshal.PtrToStructure<CopyAchievementDefinitionV2ByIndexOptions>(options);
        if (!phandler.IsAchiExistIndex(_CopyAchievementDefinitionV2ByIndexOptions.AchievementIndex))
            return (int)Result.NotFound;
        DefinitionV2 definition = phandler.GetDefinitionV2Index(_CopyAchievementDefinitionV2ByIndexOptions.AchievementIndex);
        Helpers.StructWriteOut(definition, outDefinition);
        return (int)Result.Success;
    }


    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
    public static void EOS_Achievements_DefinitionV2_Release(IntPtr achievementDefinition)
    {
        _log.Logger.WriteDebug($"{nameof(EOS_Achievements_DefinitionV2_Release)} Called", Logging.LogCategory.Achievements);
        if (achievementDefinition == IntPtr.Zero)
            return;
        DefinitionV2 def = Marshal.PtrToStructure<DefinitionV2>(achievementDefinition);
        Helpers.DestroyStructArray<StatThresholds>(def.StatThresholds, (int)def.StatThresholdsCount);
        Helpers.Destroy<DefinitionV2>(achievementDefinition);
    }
    #endregion
    #region PlayerAchievement
    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
    public static int EOS_Achievements_CopyPlayerAchievementByAchievementId(IntPtr handle, IntPtr options, IntPtr outAchievement)
    {
        _log.Logger.WriteDebug($"{nameof(EOS_Achievements_CopyPlayerAchievementByAchievementId)} Called", Logging.LogCategory.Achievements);
        if (!EOS_Main.GetPlatform().CheckArgs(handle, outAchievement))
            return (int)Result.InvalidParameters;
        var phandler = EOS_Main.GetPlatform().GetHandler<Achievements_Handler>(handle);
        if (phandler == null)
            return (int)Result.InvalidParameters;
        int version = Helpers.GetVersionFromStructPTR(options);
        switch (version)
        {
            case 1:
                {
                    
                    var playerAchievementByAchievementIdOptionsV1 = Marshal.PtrToStructure<CopyPlayerAchievementByAchievementIdOptionsV1>(options);
                    var userID = Helpers.ToUTF8String(playerAchievementByAchievementIdOptionsV1.TargetUserId);
                    if (!EOS_Main.GetPlatform().Network.IsUserExists(userID))
                        return (int)Result.InvalidProductUserID;
                    if (!phandler.IsAchiExist(playerAchievementByAchievementIdOptionsV1.AchievementId))
                        return (int)Result.NotFound;
                    var pachi = phandler.GetPlayerAchievementV1(userID, playerAchievementByAchievementIdOptionsV1.AchievementId);
                    Helpers.StructWriteOut(pachi, outAchievement);
                    return (int)Result.Success;
                }
            case 2:
                {

                    var playerAchievementByAchievementIdOptionsV1 = Marshal.PtrToStructure<CopyPlayerAchievementByAchievementIdOptionsV2>(options);
                    var userID = Helpers.ToUTF8String(playerAchievementByAchievementIdOptionsV1.TargetUserId);
                    if (!EOS_Main.GetPlatform().Network.IsUserExists(userID))
                        return (int)Result.InvalidProductUserID;
                    if (!phandler.IsAchiExist(playerAchievementByAchievementIdOptionsV1.AchievementId))
                        return (int)Result.NotFound;
                    var pachi = phandler.GetPlayerAchievementV2(userID, playerAchievementByAchievementIdOptionsV1.AchievementId);
                    Helpers.StructWriteOut(pachi, outAchievement);
                    return (int)Result.Success;
                }
            default:
                return (int)Result.NotFound;
        }
    }

    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
    public static int EOS_Achievements_CopyPlayerAchievementByIndex(IntPtr handle, IntPtr options, IntPtr outAchievement)
    {
        _log.Logger.WriteDebug($"{nameof(EOS_Achievements_CopyPlayerAchievementByIndex)} Called", Logging.LogCategory.Achievements);
        if (!EOS_Main.GetPlatform().CheckArgs(handle, outAchievement))
            return (int)Result.InvalidParameters;
        var phandler = EOS_Main.GetPlatform().GetHandler<Achievements_Handler>(handle);
        if (phandler == null)
            return (int)Result.InvalidParameters;
        int version = Helpers.GetVersionFromStructPTR(options);
        switch (version)
        {
            case 1:
                {

                    var optionsV1 = Marshal.PtrToStructure<CopyPlayerAchievementByIndexOptionsV1>(options);
                    var userID = Helpers.ToUTF8String(optionsV1.TargetUserId);
                    if (!EOS_Main.GetPlatform().Network.IsUserExists(userID))
                        return (int)Result.InvalidProductUserID;
                    if (!phandler.IsAchiExistIndex(optionsV1.AchievementIndex))
                        return (int)Result.NotFound;
                    var pachi = phandler.GetPlayerAchievementV1Index(userID, optionsV1.AchievementIndex);
                    Helpers.StructWriteOut(pachi, outAchievement);
                    return (int)Result.Success;
                }
            case 2:
                {

                    var optionsV2 = Marshal.PtrToStructure<CopyPlayerAchievementByIndexOptionsV2>(options);
                    var userID = Helpers.ToUTF8String(optionsV2.TargetUserId);
                    if (!EOS_Main.GetPlatform().Network.IsUserExists(userID))
                        return (int)Result.InvalidProductUserID;
                    if (!phandler.IsAchiExistIndex(optionsV2.AchievementIndex))
                        return (int)Result.NotFound;
                    var pachi = phandler.GetPlayerAchievementV2Index(userID, optionsV2.AchievementIndex);
                    Helpers.StructWriteOut(pachi, outAchievement);
                    return (int)Result.Success;
                }
            default:
                return (int)Result.NotFound;
        }
    }

    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
    public static void EOS_Achievements_PlayerAchievement_Release(IntPtr achievement)
    {
        _log.Logger.WriteDebug($"{nameof(EOS_Achievements_PlayerAchievement_Release)} Called", Logging.LogCategory.Achievements);
        if (achievement == IntPtr.Zero)
            return;
        int version = Helpers.GetVersionFromStructPTR(achievement);
        switch (version)
        {
            case 1:
                {
                    var v1 = Marshal.PtrToStructure<PlayerAchievementV1>(achievement);
                    Helpers.DestroyStructArray<StatThresholds>(v1.StatInfo, v1.StatInfoCount);
                    Helpers.Destroy<PlayerAchievementV1>(achievement);
                }
                break;
            case 2:
                {
                    var v2 = Marshal.PtrToStructure<PlayerAchievementV2>(achievement);
                    Helpers.DestroyStructArray<StatThresholds>(v2.StatInfo, v2.StatInfoCount);
                    Helpers.Destroy<PlayerAchievementV2>(achievement);
                }
                break;
            default:
                break;
        }
    }
    #endregion
    #region Count Getter
    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
    public static uint EOS_Achievements_GetAchievementDefinitionCount(IntPtr handle, IntPtr options)
    {
        _log.Logger.WriteDebug($"{nameof(EOS_Achievements_GetAchievementDefinitionCount)} Called", Logging.LogCategory.Achievements);
        var phandler = EOS_Main.GetPlatform().GetHandler<Achievements_Handler>(handle);
        if (phandler == null)
            return 0;
        var _GetAchievementDefinitionCountOptions = Marshal.PtrToStructure<GetAchievementDefinitionCountOptions>(options);
        return (uint)phandler.Achievements.Count;
    }

    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
    public static uint EOS_Achievements_GetPlayerAchievementCount(IntPtr handle, IntPtr options)
    {
        _log.Logger.WriteDebug($"{nameof(EOS_Achievements_GetPlayerAchievementCount)} Called", Logging.LogCategory.Achievements);
        var phandler = EOS_Main.GetPlatform().GetHandler<Achievements_Handler>(handle);
        if (phandler == null)
            return 0;
        var _GetPlayerAchievementCountOptions = Marshal.PtrToStructure<GetPlayerAchievementCountOptions>(options);
        return (uint)phandler.GetAchievement_FromAccount(Helpers.ToUTF8String(_GetPlayerAchievementCountOptions.UserId)).Count;
    }

    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
    public static uint EOS_Achievements_GetUnlockedAchievementCount(IntPtr handle, IntPtr options)
    {
        _log.Logger.WriteDebug($"{nameof(EOS_Achievements_GetUnlockedAchievementCount)} Called", Logging.LogCategory.Achievements);
        var phandler = EOS_Main.GetPlatform().GetHandler<Achievements_Handler>(handle);
        if (phandler == null)
            return 0;
        var _GetUnlockedAchievementCountOptions = Marshal.PtrToStructure<GetUnlockedAchievementCountOptions>(options);
        var _GetPlayerAchievementCountOptions = Marshal.PtrToStructure<GetPlayerAchievementCountOptions>(options);
        return (uint)phandler.GetAchievement_FromAccount(Helpers.ToUTF8String(_GetPlayerAchievementCountOptions.UserId)).Where(x=>x.UnlockedTime != -1).Count();
    }
    #endregion
    #region Query
    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
    public static void EOS_Achievements_QueryDefinitions(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
    {
        _log.Logger.WriteDebug($"{nameof(EOS_Achievements_QueryDefinitions)} Called", Logging.LogCategory.Achievements);
        if (!EOS_Main.GetPlatform().CheckArgs(handle, completionDelegate))
            return;
        var phandler = EOS_Main.GetPlatform().GetHandler<Achievements_Handler>(handle);
        if (phandler == null)
            return;
        var _QueryDefinitionsOptions = Marshal.PtrToStructure<QueryDefinitionsOptions>(options);
        OnQueryDefinitionsCompleteCallbackInfo info = new()
        {
            ClientData = clientData,
            ResultCode = Result.Success
        };
        CallbackManager.WaitDelegateForCompletionOrTimeOut(completionDelegate, info, nameof(EOS_Achievements_QueryDefinitions),
        () => { return phandler.IsAccountStillWaiting(Helpers.ToUTF8String(_QueryDefinitionsOptions.LocalUserId)); });
    }

    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
    public static void EOS_Achievements_QueryPlayerAchievements(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
    {
        _log.Logger.WriteDebug($"{nameof(EOS_Achievements_QueryPlayerAchievements)} Called", Logging.LogCategory.Achievements);
        if (!EOS_Main.GetPlatform().CheckArgs(handle, completionDelegate))
            return;
        var phandler = EOS_Main.GetPlatform().GetHandler<Achievements_Handler>(handle);
        if (phandler == null)
            return;
        // Currently we dont care about V1 and V2 here.
        var _QueryPlayerAchievementsOptions = Marshal.PtrToStructure<QueryPlayerAchievementsOptionsV1>(options);
        phandler.AddUserToAchRequest(Helpers.ToUTF8String(_QueryPlayerAchievementsOptions.TargetUserId));

        OnQueryPlayerAchievementsCompleteCallbackInfo onQueryPlayerAchievementsCompleteCallbackInfo = new()
        { 
            ClientData = clientData,
            ResultCode = Result.Success,
            UserId = _QueryPlayerAchievementsOptions.TargetUserId
        };

        CallbackManager.WaitDelegateForCompletionOrTimeOut(completionDelegate, onQueryPlayerAchievementsCompleteCallbackInfo, nameof(EOS_Achievements_QueryPlayerAchievements),
            () => { return phandler.IsAccountStillWaiting(Helpers.ToUTF8String(_QueryPlayerAchievementsOptions.TargetUserId)); });
    }
    #endregion
    #region UnlockAchivement
    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
    public static void EOS_Achievements_UnlockAchievements(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
    {
        _log.Logger.WriteDebug($"{nameof(EOS_Achievements_UnlockAchievements)} Called", Logging.LogCategory.Achievements);
        if (!EOS_Main.GetPlatform().CheckArgs(handle, completionDelegate))
            return;
        var phandler = EOS_Main.GetPlatform().GetHandler<Achievements_Handler>(handle);
        if (phandler == null)
            return;

        var _UnlockAchievementsOptions = Marshal.PtrToStructure<UnlockAchievementsOptions>(options);
        _UnlockAchievementsOptions = phandler.UnlockAchievements(_UnlockAchievementsOptions);

        NotifyManager.TriggerNotify("Ach_Unlocked", _UnlockAchievementsOptions);

        OnUnlockAchievementsCompleteCallbackInfo onUnlockAchievementsCompleteCallbackInfo = new()
        {
            ClientData = clientData,
            ResultCode = Result.Success,
            AchievementsCount = _UnlockAchievementsOptions.AchievementsCount,
            UserId = _UnlockAchievementsOptions.UserId
        };
        CallbackManager.AddCallback(completionDelegate, onUnlockAchievementsCompleteCallbackInfo, nameof(EOS_Achievements_QueryDefinitions));
    }
    #endregion
    #region UnlockedAchievement
    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
    public static int EOS_Achievements_CopyUnlockedAchievementByAchievementId(IntPtr handle, IntPtr options, IntPtr outAchievement)
    {
        _log.Logger.WriteDebug($"{nameof(EOS_Achievements_CopyUnlockedAchievementByAchievementId)} Called", Logging.LogCategory.Achievements);
        if (!EOS_Main.GetPlatform().CheckArgs(handle, outAchievement))
            return (int)Result.InvalidParameters;
        var phandler = EOS_Main.GetPlatform().GetHandler<Achievements_Handler>(handle);
        if (phandler == null)
            return (int)Result.InvalidParameters;
        var _CopyUnlockedAchievementByAchievementIdOptions = Marshal.PtrToStructure<CopyUnlockedAchievementByAchievementIdOptions>(options);
        if (!EOS_Main.GetPlatform().Network.IsUserExists(Helpers.ToUTF8String(_CopyUnlockedAchievementByAchievementIdOptions.UserId)))
            return (int)Result.InvalidProductUserID;
        if (!phandler.IsAchiExist(_CopyUnlockedAchievementByAchievementIdOptions.AchievementId))
            return (int)Result.NotFound;
        var ret = phandler.GetUnlockedAchievement(Helpers.ToUTF8String(_CopyUnlockedAchievementByAchievementIdOptions.UserId), _CopyUnlockedAchievementByAchievementIdOptions.AchievementId);
        Helpers.StructWriteOut(ret, outAchievement);
        return (int)Result.Success;
    }

    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
    public static int EOS_Achievements_CopyUnlockedAchievementByIndex(IntPtr handle, IntPtr options, IntPtr outAchievement)
    {
        _log.Logger.WriteDebug($"{nameof(EOS_Achievements_CopyUnlockedAchievementByIndex)} Called", Logging.LogCategory.Achievements);
        if (!EOS_Main.GetPlatform().CheckArgs(handle, outAchievement))
            return (int)Result.InvalidParameters;
        var phandler = EOS_Main.GetPlatform().GetHandler<Achievements_Handler>(handle);
        if (phandler == null)
            return (int)Result.InvalidParameters;
        var _CopyUnlockedAchievementByIndexOptions = Marshal.PtrToStructure<CopyUnlockedAchievementByIndexOptions>(options);
        if (!EOS_Main.GetPlatform().Network.IsUserExists(Helpers.ToUTF8String(_CopyUnlockedAchievementByIndexOptions.TargetUserId)))
            return (int)Result.InvalidProductUserID;
        if (!phandler.IsAchiExistIndex(_CopyUnlockedAchievementByIndexOptions.AchievementIndex))
            return (int)Result.NotFound;
        var ret = phandler.GetUnlockedAchievementIndex(Helpers.ToUTF8String(_CopyUnlockedAchievementByIndexOptions.TargetUserId), _CopyUnlockedAchievementByIndexOptions.AchievementIndex);
        Helpers.StructWriteOut(ret, outAchievement);
        return (int)Result.Success;
    }

    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
    public static void EOS_Achievements_UnlockedAchievement_Release(IntPtr achievement)
    {
        _log.Logger.WriteDebug($"{nameof(EOS_Achievements_UnlockedAchievement_Release)} Called", Logging.LogCategory.Achievements);
        if (achievement == IntPtr.Zero)
            return;
        Helpers.Destroy<UnlockedAchievement>(achievement);
    }
    #endregion
}
