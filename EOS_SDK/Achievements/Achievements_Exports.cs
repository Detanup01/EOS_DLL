using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace EOS_SDK.Achievements
{
    public unsafe class Achievements_Exports
    {
        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_Achievements_AddNotifyAchievementsUnlocked(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationFn)
        {
            var _AddNotifyAchievementsUnlockedOptionspublic = Marshal.PtrToStructure<AddNotifyAchievementsUnlockedOptionspublic>(options);
            delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)notificationFn; //Delegate Class was: OnAchievementsUnlockedCallbackpublic
            return 0;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_Achievements_AddNotifyAchievementsUnlockedV2(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationFn)
        {
            var _AddNotifyAchievementsUnlockedV2Optionspublic = Marshal.PtrToStructure<AddNotifyAchievementsUnlockedV2Optionspublic>(options);
            delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)notificationFn; //Delegate Class was: OnAchievementsUnlockedCallbackV2public
            return 0;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_Achievements_CopyAchievementDefinitionByAchievementId(IntPtr handle, IntPtr options, IntPtr outDefinition)
        {
            var _CopyAchievementDefinitionByAchievementIdOptionspublic = Marshal.PtrToStructure<CopyAchievementDefinitionByAchievementIdOptionspublic>(options);
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_Achievements_CopyAchievementDefinitionByIndex(IntPtr handle, IntPtr options, IntPtr outDefinition)
        {
            var _CopyAchievementDefinitionByIndexOptionspublic = Marshal.PtrToStructure<CopyAchievementDefinitionByIndexOptionspublic>(options);
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_Achievements_CopyAchievementDefinitionV2ByAchievementId(IntPtr handle, IntPtr options, IntPtr outDefinition)
        {
            var _CopyAchievementDefinitionV2ByAchievementIdOptionspublic = Marshal.PtrToStructure<CopyAchievementDefinitionV2ByAchievementIdOptionspublic>(options);
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_Achievements_CopyAchievementDefinitionV2ByIndex(IntPtr handle, IntPtr options, IntPtr outDefinition)
        {
            var _CopyAchievementDefinitionV2ByIndexOptionspublic = Marshal.PtrToStructure<CopyAchievementDefinitionV2ByIndexOptionspublic>(options);
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_Achievements_CopyPlayerAchievementByAchievementId(IntPtr handle, IntPtr options, IntPtr outAchievement)
        {
            var _CopyPlayerAchievementByAchievementIdOptionspublic = Marshal.PtrToStructure<CopyPlayerAchievementByAchievementIdOptionspublic>(options);
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_Achievements_CopyPlayerAchievementByIndex(IntPtr handle, IntPtr options, IntPtr outAchievement)
        {
            var _CopyPlayerAchievementByIndexOptionspublic = Marshal.PtrToStructure<CopyPlayerAchievementByIndexOptionspublic>(options);
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_Achievements_CopyUnlockedAchievementByAchievementId(IntPtr handle, IntPtr options, IntPtr outAchievement)
        {
            var _CopyUnlockedAchievementByAchievementIdOptionspublic = Marshal.PtrToStructure<CopyUnlockedAchievementByAchievementIdOptionspublic>(options);
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_Achievements_CopyUnlockedAchievementByIndex(IntPtr handle, IntPtr options, IntPtr outAchievement)
        {
            var _CopyUnlockedAchievementByIndexOptionspublic = Marshal.PtrToStructure<CopyUnlockedAchievementByIndexOptionspublic>(options);
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
            var _GetAchievementDefinitionCountOptionspublic = Marshal.PtrToStructure<GetAchievementDefinitionCountOptionspublic>(options);
            return 0;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static uint EOS_Achievements_GetPlayerAchievementCount(IntPtr handle, IntPtr options)
        {
            var _GetPlayerAchievementCountOptionspublic = Marshal.PtrToStructure<GetPlayerAchievementCountOptionspublic>(options);
            return 0;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static uint EOS_Achievements_GetUnlockedAchievementCount(IntPtr handle, IntPtr options)
        {
            var _GetUnlockedAchievementCountOptionspublic = Marshal.PtrToStructure<GetUnlockedAchievementCountOptionspublic>(options);
            return 0;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Achievements_PlayerAchievement_Release(IntPtr achievement)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Achievements_QueryDefinitions(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
        {
            var _QueryDefinitionsOptionspublic = Marshal.PtrToStructure<QueryDefinitionsOptionspublic>(options);
            delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: OnQueryDefinitionsCompleteCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Achievements_QueryPlayerAchievements(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
        {
            var _QueryPlayerAchievementsOptionspublic = Marshal.PtrToStructure<QueryPlayerAchievementsOptionspublic>(options);
            delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: OnQueryPlayerAchievementsCompleteCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Achievements_RemoveNotifyAchievementsUnlocked(IntPtr handle, ulong inId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Achievements_UnlockAchievements(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
        {
            var _UnlockAchievementsOptionspublic = Marshal.PtrToStructure<UnlockAchievementsOptionspublic>(options);
            delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: OnUnlockAchievementsCompleteCallbackpublic
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Achievements_UnlockedAchievement_Release(IntPtr achievement)
        {
        }
    }
}
