using EOS_SDK._Data;
using EOS_SDK.Achievements;
using EOS_SDK.Auth;
using EOS_SDK.Windows;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace EOS_SDK.Platform
{
    public unsafe class Platform_Exports
    {

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_Platform_CheckForLauncherAndRestart(IntPtr handle)
        {
            return (int)Result.NoChange;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_Platform_Create(IntPtr options)
        {
            IntPtr pointer = 0;
#if WIN_X64 || WIN_X86
            var _Options = Marshal.PtrToStructure<WindowsOptions>(options);
            pointer = Platform_Handler.Create(_Options);
#else
            var _Options = Marshal.PtrToStructure<Options>(options);
            pointer = Platform_Hander.Create(_Options);
#endif
            return pointer;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_Platform_GetAchievementsInterface(IntPtr handle)
        {
            return Achievement_Handler.Create();
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_Platform_GetActiveCountryCode(IntPtr handle, IntPtr localUserId, IntPtr outBuffer, [Out] int inOutBufferLength)
        {
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_Platform_GetActiveLocaleCode(IntPtr handle, IntPtr localUserId, IntPtr outBuffer, [Out] int inOutBufferLength)
        {
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_Platform_GetAntiCheatClientInterface(IntPtr handle)
        {
            return 0;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_Platform_GetAntiCheatServerInterface(IntPtr handle)
        {
            return 0;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_Platform_GetApplicationStatus(IntPtr handle)
        {
            if (Platform_Handler.CheckIfPointerValid(handle))
                return (int)Platform_Handler.PlatformHandler.ApplicationStatus;
            return (int)ApplicationStatus.Foreground;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_Platform_GetAuthInterface(IntPtr handle)
        {
            return Auth_Handler.Create();
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_Platform_GetConnectInterface(IntPtr handle)
        {
            return 0;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_Platform_GetCustomInvitesInterface(IntPtr handle)
        {
            return 0;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_Platform_GetDesktopCrossplayStatus(IntPtr handle, IntPtr options, IntPtr outDesktopCrossplayStatusInfo)
		{
			var _GetDesktopCrossplayStatusOptions = Marshal.PtrToStructure<GetDesktopCrossplayStatusOptions>(options);
            DesktopCrossplayStatusInfo statusInfo = new()
            { 
                Status = DesktopCrossplayStatus.Ok,
                ServiceInitResult = 0
            };
            Helpers.StructWriteOut(statusInfo, outDesktopCrossplayStatusInfo);
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_Platform_GetEcomInterface(IntPtr handle)
        {
            return 0;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_Platform_GetFriendsInterface(IntPtr handle)
        {
            return 0;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_Platform_GetIntegratedPlatformInterface(IntPtr handle)
        {
            return 0;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_Platform_GetKWSInterface(IntPtr handle)
        {
            return 0;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_Platform_GetLeaderboardsInterface(IntPtr handle)
        {
            return 0;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_Platform_GetLobbyInterface(IntPtr handle)
        {
            return 0;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_Platform_GetMetricsInterface(IntPtr handle)
        {
            return 0;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_Platform_GetModsInterface(IntPtr handle)
        {
            return 0;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_Platform_GetNetworkStatus(IntPtr handle)
        {
            if (Platform_Handler.CheckIfPointerValid(handle))
                return (int)Platform_Handler.PlatformHandler.NetworkStatus;

            return (int)NetworkStatus.Disabled;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_Platform_GetOverrideCountryCode(IntPtr handle, IntPtr outBuffer, int inOutBufferLength)
        {
            if (Platform_Handler.CheckIfPointerValid(handle))
            {
                var ptr = Platform_Handler.PlatformHandler.OverrideCountryCode;
                if (outBuffer == IntPtr.Zero)
                    return (int)Result.InvalidParameters;
                if (inOutBufferLength != 5)
                    return (int)Result.InvalidParameters;
                Helpers.StringWriteOut(ptr, outBuffer);
            }
                
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_Platform_GetOverrideLocaleCode(IntPtr handle, IntPtr outBuffer, int inOutBufferLength)
        {
            if (Platform_Handler.CheckIfPointerValid(handle))
            {
                var ptr = Platform_Handler.PlatformHandler.OverrideLocaleCode;
                if (outBuffer == IntPtr.Zero)
                    return (int)Result.InvalidParameters;
                if (inOutBufferLength != 10)
                    return (int)Result.InvalidParameters;
                Helpers.StringWriteOut(ptr, outBuffer);
            }

            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_Platform_GetP2PInterface(IntPtr handle)
        {
            return 0;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_Platform_GetPlayerDataStorageInterface(IntPtr handle)
        {
            return 0;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_Platform_GetPresenceInterface(IntPtr handle)
        {
            return 0;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_Platform_GetProgressionSnapshotInterface(IntPtr handle)
        {
            return 0;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_Platform_GetRTCAdminInterface(IntPtr handle)
        {
            return 0;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_Platform_GetRTCInterface(IntPtr handle)
        {
            return 0;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_Platform_GetReportsInterface(IntPtr handle)
        {
            return 0;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_Platform_GetSanctionsInterface(IntPtr handle)
        {
            return 0;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_Platform_GetSessionsInterface(IntPtr handle)
        {
            return 0;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_Platform_GetStatsInterface(IntPtr handle)
        {
            return 0;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_Platform_GetTitleStorageInterface(IntPtr handle)
        {
            return 0;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_Platform_GetUIInterface(IntPtr handle)
        {
            return 0;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_Platform_GetUserInfoInterface(IntPtr handle)
        {
            return 0;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Platform_Release(IntPtr handle)
        {
            Platform_Handler.Free(handle);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_Platform_SetApplicationStatus(IntPtr handle, int newStatus)
        {
            if (Platform_Handler.CheckIfPointerValid(handle))
                Platform_Handler.PlatformHandler.ApplicationStatus = (ApplicationStatus)newStatus;
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_Platform_SetNetworkStatus(IntPtr handle, int newStatus)
        {
            if (Platform_Handler.CheckIfPointerValid(handle))
                Platform_Handler.PlatformHandler.NetworkStatus = (NetworkStatus)newStatus;
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_Platform_SetOverrideCountryCode(IntPtr handle, IntPtr newCountryCode)
        {
            if (Platform_Handler.CheckIfPointerValid(handle))
                Platform_Handler.PlatformHandler.OverrideCountryCode = Helpers.ToString(newCountryCode);
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_Platform_SetOverrideLocaleCode(IntPtr handle, IntPtr newLocaleCode)
        {
            if (Platform_Handler.CheckIfPointerValid(handle))
                Platform_Handler.PlatformHandler.OverrideLocaleCode = Helpers.ToString(newLocaleCode);
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Platform_Tick(IntPtr handle)
        {
            CallbackManager.Update();
        }
    }
}
