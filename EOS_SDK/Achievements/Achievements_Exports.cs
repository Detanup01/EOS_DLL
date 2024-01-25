using EOS_SDK._Data;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace EOS_SDK.Achievements
{
    public unsafe class Achievements_Exports
    {
        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_Achievements_AddNotifyAchievementsUnlocked(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationFn)
        {
            var _AddNotifyAchievementsUnlockedOptions = Marshal.PtrToStructure<AddNotifyAchievementsUnlockedOptions>(options);
            delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)notificationFn; //Delegate Class was: OnAchievementsUnlockedCallback
            return 0;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_Achievements_AddNotifyAchievementsUnlockedV2(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationFn)
        {
            var _AddNotifyAchievementsUnlockedV2Options = Marshal.PtrToStructure<AddNotifyAchievementsUnlockedV2Options>(options);
            delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)notificationFn; //Delegate Class was: OnAchievementsUnlockedCallbackV2
            return 0;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_Achievements_CopyAchievementDefinitionByAchievementId(IntPtr handle, IntPtr options, IntPtr outDefinition)
        {
            var _CopyAchievementDefinitionByAchievementIdOptions = Marshal.PtrToStructure<CopyAchievementDefinitionByAchievementIdOptions>(options);
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_Achievements_CopyAchievementDefinitionByIndex(IntPtr handle, IntPtr options, IntPtr outDefinition)
        {
            var _CopyAchievementDefinitionByIndexOptions = Marshal.PtrToStructure<CopyAchievementDefinitionByIndexOptions>(options);
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_Achievements_CopyAchievementDefinitionV2ByAchievementId(IntPtr handle, IntPtr options, IntPtr outDefinition)
        {
            var _CopyAchievementDefinitionV2ByAchievementIdOptions = Marshal.PtrToStructure<CopyAchievementDefinitionV2ByAchievementIdOptions>(options);
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_Achievements_CopyAchievementDefinitionV2ByIndex(IntPtr handle, IntPtr options, IntPtr outDefinition)
        {
            var _CopyAchievementDefinitionV2ByIndexOptions = Marshal.PtrToStructure<CopyAchievementDefinitionV2ByIndexOptions>(options);
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_Achievements_CopyPlayerAchievementByAchievementId(IntPtr handle, IntPtr options, IntPtr outAchievement)
        {
            var _CopyPlayerAchievementByAchievementIdOptions = Marshal.PtrToStructure<CopyPlayerAchievementByAchievementIdOptions>(options);
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_Achievements_CopyPlayerAchievementByIndex(IntPtr handle, IntPtr options, IntPtr outAchievement)
        {
            var _CopyPlayerAchievementByIndexOptions = Marshal.PtrToStructure<CopyPlayerAchievementByIndexOptions>(options);
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_Achievements_CopyUnlockedAchievementByAchievementId(IntPtr handle, IntPtr options, IntPtr outAchievement)
        {
            var _CopyUnlockedAchievementByAchievementIdOptions = Marshal.PtrToStructure<CopyUnlockedAchievementByAchievementIdOptions>(options);
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_Achievements_CopyUnlockedAchievementByIndex(IntPtr handle, IntPtr options, IntPtr outAchievement)
        {
            var _CopyUnlockedAchievementByIndexOptions = Marshal.PtrToStructure<CopyUnlockedAchievementByIndexOptions>(options);
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Achievements_DefinitionV2_Release(IntPtr achievementDefinition)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Achievements_Definition_Release(IntPtr achievementDefinition)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static uint EOS_Achievements_GetAchievementDefinitionCount(IntPtr handle, IntPtr options)
        {
            var _GetAchievementDefinitionCountOptions = Marshal.PtrToStructure<GetAchievementDefinitionCountOptions>(options);
            return 0;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static uint EOS_Achievements_GetPlayerAchievementCount(IntPtr handle, IntPtr options)
        {
            var _GetPlayerAchievementCountOptions = Marshal.PtrToStructure<GetPlayerAchievementCountOptions>(options);
            return 0;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static uint EOS_Achievements_GetUnlockedAchievementCount(IntPtr handle, IntPtr options)
        {
            var _GetUnlockedAchievementCountOptions = Marshal.PtrToStructure<GetUnlockedAchievementCountOptions>(options);
            return 0;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Achievements_PlayerAchievement_Release(IntPtr achievement)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Achievements_QueryDefinitions(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
        {
            var _QueryDefinitionsOptions = Marshal.PtrToStructure<QueryDefinitionsOptions>(options);

            if (completionDelegate != IntPtr.Zero)
            {
                OnQueryDefinitionsCompleteCallbackInfo info = new OnQueryDefinitionsCompleteCallbackInfo()
                {
                    ClientData = clientData,
                    ResultCode = Result.Success
                };
                CallbackManager.AddCallback(completionDelegate, info, nameof(EOS_Achievements_QueryDefinitions));
            }
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Achievements_QueryPlayerAchievements(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
        {
            var _QueryPlayerAchievementsOptions = Marshal.PtrToStructure<QueryPlayerAchievementsOptions>(options);
            delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: OnQueryPlayerAchievementsCompleteCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Achievements_RemoveNotifyAchievementsUnlocked(IntPtr handle, ulong inId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Achievements_UnlockAchievements(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
        {
            var _UnlockAchievementsOptions = Marshal.PtrToStructure<UnlockAchievementsOptions>(options);
            delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: OnUnlockAchievementsCompleteCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Achievements_UnlockedAchievement_Release(IntPtr achievement)
        {
        }
    }
}
