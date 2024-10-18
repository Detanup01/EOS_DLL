using EOS_SDK._Data;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace EOS_SDK.Achievements
{
    public unsafe class Achievements_Exports
    {
        #region Notify
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static ulong EOS_Achievements_AddNotifyAchievementsUnlocked(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationFn)
        {
            _log.Logger.WriteDebug($"{nameof(EOS_Achievements_AddNotifyAchievementsUnlocked)} Called", Logging.LogCategory.Achievements);
            if (!EOS_Main.GetPlatform().CheckArgs(handle, notificationFn))
                return 0;
            var _AddNotifyAchievementsUnlockedOptions = Marshal.PtrToStructure<AddNotifyAchievementsUnlockedOptions>(options);
            if (notificationFn == IntPtr.Zero)
                return 0;
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
            if (!EOS_Main.GetPlatform().CheckArgs(handle, notificationFn))
                return 0;
            var _AddNotifyAchievementsUnlockedV2Options = Marshal.PtrToStructure<AddNotifyAchievementsUnlockedV2Options>(options);
            if (notificationFn == IntPtr.Zero)
                return 0;
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
                return (int)Result.InvalidParameters;
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
                return (int)Result.InvalidParameters;
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
            var version = Helpers.GetVersionFromStructPTR(options);
            //var _CopyPlayerAchievementByAchievementIdOptions = Marshal.PtrToStructure<CopyPlayerAchievementByAchievementIdOptions>(options);
            return (int)Result.Success;
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
            //var _CopyPlayerAchievementByIndexOptions = Marshal.PtrToStructure<CopyPlayerAchievementByIndexOptions>(options);
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static void EOS_Achievements_PlayerAchievement_Release(IntPtr achievement)
        {
            _log.Logger.WriteDebug($"{nameof(EOS_Achievements_PlayerAchievement_Release)} Called", Logging.LogCategory.Achievements);

        }
        #endregion
        #region Count Getter
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static uint EOS_Achievements_GetAchievementDefinitionCount(IntPtr handle, IntPtr options)
        {
            _log.Logger.WriteDebug($"{nameof(EOS_Achievements_GetAchievementDefinitionCount)} Called", Logging.LogCategory.Achievements);
            var phandler = EOS_Main.GetPlatform().GetHandler<Achievements_Handler>(handle);
            if (phandler == null)
                return (int)Result.InvalidParameters;
            var _GetAchievementDefinitionCountOptions = Marshal.PtrToStructure<GetAchievementDefinitionCountOptions>(options);
            return (uint)phandler.Achievements.Count;
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static uint EOS_Achievements_GetPlayerAchievementCount(IntPtr handle, IntPtr options)
        {
            _log.Logger.WriteDebug($"{nameof(EOS_Achievements_GetPlayerAchievementCount)} Called", Logging.LogCategory.Achievements);
            var phandler = EOS_Main.GetPlatform().GetHandler<Achievements_Handler>(handle);
            if (phandler == null)
                return (int)Result.InvalidParameters;
            var _GetPlayerAchievementCountOptions = Marshal.PtrToStructure<GetPlayerAchievementCountOptions>(options);
            return 0;
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static uint EOS_Achievements_GetUnlockedAchievementCount(IntPtr handle, IntPtr options)
        {
            _log.Logger.WriteDebug($"{nameof(EOS_Achievements_GetUnlockedAchievementCount)} Called", Logging.LogCategory.Achievements);
            var phandler = EOS_Main.GetPlatform().GetHandler<Achievements_Handler>(handle);
            if (phandler == null)
                return (int)Result.InvalidParameters;
            var _GetUnlockedAchievementCountOptions = Marshal.PtrToStructure<GetUnlockedAchievementCountOptions>(options);
            return 0;
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
            OnQueryDefinitionsCompleteCallbackInfo info = new OnQueryDefinitionsCompleteCallbackInfo()
            {
                ClientData = clientData,
                ResultCode = Result.Success
            };
            CallbackManager.AddCallback(completionDelegate, info, nameof(EOS_Achievements_QueryDefinitions));
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

            var _QueryPlayerAchievementsOptions = Marshal.PtrToStructure<QueryPlayerAchievementsOptionsV1>(options);
            phandler.AddUserToAchRequest(Helpers.ToString(_QueryPlayerAchievementsOptions.TargetUserId));

            OnQueryPlayerAchievementsCompleteCallbackInfo onQueryPlayerAchievementsCompleteCallbackInfo = new()
            { 
                ClientData = clientData,
                ResultCode = Result.Success,
                UserId = _QueryPlayerAchievementsOptions.TargetUserId
            };

            CallbackManager.AddCallback(completionDelegate, onQueryPlayerAchievementsCompleteCallbackInfo, nameof(EOS_Achievements_QueryPlayerAchievements));
            CallbackManager.WaitDelegateForCompletion(completionDelegate, () => { return phandler.IsAccountStillWaiting(Helpers.ToString(_QueryPlayerAchievementsOptions.TargetUserId)); });
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
            var ret = phandler.GetUnlockedAchievement(Helpers.ToString(_CopyUnlockedAchievementByAchievementIdOptions.UserId), _CopyUnlockedAchievementByAchievementIdOptions.AchievementId);
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
            var ret = phandler.GetUnlockedAchievementIndex(Helpers.ToString(_CopyUnlockedAchievementByIndexOptions.TargetUserId), _CopyUnlockedAchievementByIndexOptions.AchievementIndex);
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
}
