using EOS_SDK._Data;
using EOS_SDK.Windows;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace EOS_SDK.Platform
{
    public unsafe class Platform_Exports
    {

        [UnmanagedCallersOnly(EntryPoint = "EOS_Platform_CheckForLauncherAndRestart")]
        public static int EOS_Platform_CheckForLauncherAndRestart(IntPtr handle)
        {
            return (int)Result.NoChange;
        }

        [UnmanagedCallersOnly(EntryPoint = "EOS_Platform_Create")]
        public static IntPtr EOS_Platform_Create(IntPtr options)
        {
            IntPtr pointer = 0;
#if WIN_X64 || WIN_X86
            var _Options = Marshal.PtrToStructure<WindowsOptions>(options);
            pointer = EOS_Main.GetPlatform().Create(_Options);
#else
            var _Options = Marshal.PtrToStructure<Options>(options);
            pointer = EOS_Main.GetPlatform().Create(_Options);
#endif
            return pointer;
        }

        [UnmanagedCallersOnly(EntryPoint = "EOS_Platform_GetAchievementsInterface")]
        public static IntPtr EOS_Platform_GetAchievementsInterface(IntPtr handle)
        {
            if (EOS_Main.GetPlatform().CheckIfPointerValid(handle))
                return EOS_Main.GetPlatform().CreateHandler(SDK.AchievementPTR);
            return IntPtr.Zero;
        }

        [UnmanagedCallersOnly(EntryPoint = "EOS_Platform_GetActiveCountryCode")]
        public static int EOS_Platform_GetActiveCountryCode(IntPtr handle, IntPtr localUserId, IntPtr outBuffer, [Out] int inOutBufferLength)
        {
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(EntryPoint = "EOS_Platform_GetActiveLocaleCode")]
        public static int EOS_Platform_GetActiveLocaleCode(IntPtr handle, IntPtr localUserId, IntPtr outBuffer, [Out] int inOutBufferLength)
        {
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(EntryPoint = "EOS_Platform_GetAntiCheatClientInterface")]
        public static IntPtr EOS_Platform_GetAntiCheatClientInterface(IntPtr handle)
        {
            return 0;
        }

        [UnmanagedCallersOnly(EntryPoint = "EOS_Platform_GetAntiCheatServerInterface")]
        public static IntPtr EOS_Platform_GetAntiCheatServerInterface(IntPtr handle)
        {
            return 0;
        }

        [UnmanagedCallersOnly(EntryPoint = "EOS_Platform_GetApplicationStatus")]
        public static int EOS_Platform_GetApplicationStatus(IntPtr handle)
        {
            if (EOS_Main.GetPlatform().CheckIfPointerValid(handle))
                return (int)EOS_Main.GetPlatform().ApplicationStatus;
            return (int)ApplicationStatus.Foreground;
        }

        [UnmanagedCallersOnly(EntryPoint = "EOS_Platform_GetAuthInterface")]
        public static IntPtr EOS_Platform_GetAuthInterface(IntPtr handle)
        {
            if (EOS_Main.GetPlatform().CheckIfPointerValid(handle))
                return EOS_Main.GetPlatform().CreateHandler(SDK.AuthPTR);
            return IntPtr.Zero;
        }

        [UnmanagedCallersOnly(EntryPoint = "EOS_Platform_GetConnectInterface")]
        public static IntPtr EOS_Platform_GetConnectInterface(IntPtr handle)
        {
            if (EOS_Main.GetPlatform().CheckIfPointerValid(handle))
                return EOS_Main.GetPlatform().CreateHandler(SDK.ConnectPTR);
            return IntPtr.Zero;
        }

        [UnmanagedCallersOnly(EntryPoint = "EOS_Platform_GetCustomInvitesInterface")]
        public static IntPtr EOS_Platform_GetCustomInvitesInterface(IntPtr handle)
        {
            return 0;
        }

        [UnmanagedCallersOnly(EntryPoint = "EOS_Platform_GetDesktopCrossplayStatus")]
        public static int EOS_Platform_GetDesktopCrossplayStatus(IntPtr handle, IntPtr options, IntPtr outDesktopCrossplayStatusInfo)
		{
#if WIN_X64 || WIN_X86
            DesktopCrossplayStatusInfo statusInfo = new()
            { 
                Status = DesktopCrossplayStatus.Ok,
                ServiceInitResult = 0
            };
            Helpers.StructWriteOut(statusInfo, outDesktopCrossplayStatusInfo);
            return (int)Result.Success;
#else
            DesktopCrossplayStatusInfo statusInfo = new()
            { 
                Status = DesktopCrossplayStatus.ServiceStartFailed,
                ServiceInitResult = 2
            };
            Helpers.StructWriteOut(statusInfo, outDesktopCrossplayStatusInfo);
            return (int)Result.NotImplemented;
#endif
        }

        [UnmanagedCallersOnly(EntryPoint = "EOS_Platform_GetEcomInterface")]
        public static IntPtr EOS_Platform_GetEcomInterface(IntPtr handle)
        {
            return 0;
        }

        [UnmanagedCallersOnly(EntryPoint = "EOS_Platform_GetFriendsInterface")]
        public static IntPtr EOS_Platform_GetFriendsInterface(IntPtr handle)
        {
            return 0;
        }

        [UnmanagedCallersOnly(EntryPoint = "EOS_Platform_GetIntegratedPlatformInterface")]
        public static IntPtr EOS_Platform_GetIntegratedPlatformInterface(IntPtr handle)
        {
            return 0;
        }

        [UnmanagedCallersOnly(EntryPoint = "EOS_Platform_GetKWSInterface")]
        public static IntPtr EOS_Platform_GetKWSInterface(IntPtr handle)
        {
            return 0;
        }

        [UnmanagedCallersOnly(EntryPoint = "EOS_Platform_GetLeaderboardsInterface")]
        public static IntPtr EOS_Platform_GetLeaderboardsInterface(IntPtr handle)
        {
            return 0;
        }

        [UnmanagedCallersOnly(EntryPoint = "EOS_Platform_GetLobbyInterface")]
        public static IntPtr EOS_Platform_GetLobbyInterface(IntPtr handle)
        {
            return 0;
        }

        [UnmanagedCallersOnly(EntryPoint = "EOS_Platform_GetMetricsInterface")]
        public static IntPtr EOS_Platform_GetMetricsInterface(IntPtr handle)
        {
            return 0;
        }

        [UnmanagedCallersOnly(EntryPoint = "EOS_Platform_GetModsInterface")]
        public static IntPtr EOS_Platform_GetModsInterface(IntPtr handle)
        {
            return 0;
        }

        [UnmanagedCallersOnly(EntryPoint = "EOS_Platform_GetNetworkStatus")]
        public static int EOS_Platform_GetNetworkStatus(IntPtr handle)
        {
            if (EOS_Main.GetPlatform().CheckIfPointerValid(handle))
                return (int)EOS_Main.GetPlatform().NetworkStatus;

            return (int)NetworkStatus.Disabled;
        }

        [UnmanagedCallersOnly(EntryPoint = "EOS_Platform_GetOverrideCountryCode")]
        public static int EOS_Platform_GetOverrideCountryCode(IntPtr handle, IntPtr outBuffer, int inOutBufferLength)
        {
            if (EOS_Main.GetPlatform().CheckIfPointerValid(handle))
            {
                var ptr = EOS_Main.GetPlatform().OverrideCountryCode;
                if (outBuffer == IntPtr.Zero)
                    return (int)Result.InvalidParameters;
                if (inOutBufferLength != 5)
                    return (int)Result.InvalidParameters;
                Helpers.StringWriteOut(ptr, outBuffer);
                return (int)Result.Success;
            }
                
            return (int)Result.UnexpectedError;
        }

        [UnmanagedCallersOnly(EntryPoint = "EOS_Platform_GetOverrideLocaleCode")]
        public static int EOS_Platform_GetOverrideLocaleCode(IntPtr handle, IntPtr outBuffer, int inOutBufferLength)
        {
            if (EOS_Main.GetPlatform().CheckIfPointerValid(handle))
            {
                var ptr = EOS_Main.GetPlatform().OverrideLocaleCode;
                if (outBuffer == IntPtr.Zero)
                    return (int)Result.InvalidParameters;
                if (inOutBufferLength != 10)
                    return (int)Result.InvalidParameters;
                Helpers.StringWriteOut(ptr, outBuffer);
                return (int)Result.Success;
            }
            return (int)Result.UnexpectedError;
           
        }

        [UnmanagedCallersOnly(EntryPoint = "EOS_Platform_GetP2PInterface")]
        public static IntPtr EOS_Platform_GetP2PInterface(IntPtr handle)
        {
            return 0;
        }

        [UnmanagedCallersOnly(EntryPoint = "EOS_Platform_GetPlayerDataStorageInterface")]
        public static IntPtr EOS_Platform_GetPlayerDataStorageInterface(IntPtr handle)
        {
            return 0;
        }

        [UnmanagedCallersOnly(EntryPoint = "EOS_Platform_GetPresenceInterface")]
        public static IntPtr EOS_Platform_GetPresenceInterface(IntPtr handle)
        {
            return 0;
        }

        [UnmanagedCallersOnly(EntryPoint = "EOS_Platform_GetProgressionSnapshotInterface")]
        public static IntPtr EOS_Platform_GetProgressionSnapshotInterface(IntPtr handle)
        {
            return 0;
        }

        [UnmanagedCallersOnly(EntryPoint = "EOS_Platform_GetRTCAdminInterface")]
        public static IntPtr EOS_Platform_GetRTCAdminInterface(IntPtr handle)
        {
            return 0;
        }

        [UnmanagedCallersOnly(EntryPoint = "EOS_Platform_GetRTCInterface")]
        public static IntPtr EOS_Platform_GetRTCInterface(IntPtr handle)
        {
            return 0;
        }

        [UnmanagedCallersOnly(EntryPoint = "EOS_Platform_GetReportsInterface")]
        public static IntPtr EOS_Platform_GetReportsInterface(IntPtr handle)
        {
            return 0;
        }

        [UnmanagedCallersOnly(EntryPoint = "EOS_Platform_GetSanctionsInterface")]
        public static IntPtr EOS_Platform_GetSanctionsInterface(IntPtr handle)
        {
            return 0;
        }

        [UnmanagedCallersOnly(EntryPoint = "EOS_Platform_GetSessionsInterface")]
        public static IntPtr EOS_Platform_GetSessionsInterface(IntPtr handle)
        {
            return 0;
        }

        [UnmanagedCallersOnly(EntryPoint = "EOS_Platform_GetStatsInterface")]
        public static IntPtr EOS_Platform_GetStatsInterface(IntPtr handle)
        {
            return 0;
        }

        [UnmanagedCallersOnly(EntryPoint = "EOS_Platform_GetTitleStorageInterface")]
        public static IntPtr EOS_Platform_GetTitleStorageInterface(IntPtr handle)
        {
            return 0;
        }

        [UnmanagedCallersOnly(EntryPoint = "EOS_Platform_GetUIInterface")]
        public static IntPtr EOS_Platform_GetUIInterface(IntPtr handle)
        {
            return 0;
        }

        [UnmanagedCallersOnly(EntryPoint = "EOS_Platform_GetUserInfoInterface")]
        public static IntPtr EOS_Platform_GetUserInfoInterface(IntPtr handle)
        {
            return 0;
        }

        [UnmanagedCallersOnly(EntryPoint = "EOS_Platform_Release")]
        public static void EOS_Platform_Release(IntPtr handle)
        {
            EOS_Main.GetPlatform().Free(handle);
        }

        [UnmanagedCallersOnly(EntryPoint = "EOS_Platform_SetApplicationStatus")]
        public static int EOS_Platform_SetApplicationStatus(IntPtr handle, int newStatus)
        {
            if (EOS_Main.GetPlatform().CheckIfPointerValid(handle))
            {
                EOS_Main.GetPlatform().ApplicationStatus = (ApplicationStatus)newStatus;
                return (int)Result.Success;
            }
            return (int)Result.UnexpectedError;

        }

        [UnmanagedCallersOnly(EntryPoint = "EOS_Platform_SetNetworkStatus")]
        public static int EOS_Platform_SetNetworkStatus(IntPtr handle, int newStatus)
        {
            if (EOS_Main.GetPlatform().CheckIfPointerValid(handle))
            {
                EOS_Main.GetPlatform().NetworkStatus = (NetworkStatus)newStatus;
                return (int)Result.Success;
            }
            return (int)Result.UnexpectedError;
        }

        [UnmanagedCallersOnly(EntryPoint = "EOS_Platform_SetOverrideCountryCode")]
        public static int EOS_Platform_SetOverrideCountryCode(IntPtr handle, IntPtr newCountryCode)
        {
            if (EOS_Main.GetPlatform().CheckIfPointerValid(handle))
            {
                EOS_Main.GetPlatform().OverrideCountryCode = Helpers.ToUTF8String(newCountryCode);
                return (int)Result.Success;
            }
            return (int)Result.UnexpectedError;
        }

        [UnmanagedCallersOnly(EntryPoint = "EOS_Platform_SetOverrideLocaleCode")]
        public static int EOS_Platform_SetOverrideLocaleCode(IntPtr handle, IntPtr newLocaleCode)
        {
            if (EOS_Main.GetPlatform().CheckIfPointerValid(handle))
            {
                EOS_Main.GetPlatform().OverrideLocaleCode = Helpers.ToUTF8String(newLocaleCode);
                return (int)Result.Success;
            }
            return (int)Result.UnexpectedError;
        }

        [UnmanagedCallersOnly(EntryPoint = "EOS_Platform_Tick")]
        public static void EOS_Platform_Tick(IntPtr handle)
        {
            if (EOS_Main.GetPlatform().CheckIfPointerValid(handle))
                EOS_Main.GetPlatform().Update();
        }
    }
}
