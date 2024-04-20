using EOS_SDK.AntiCheatCommon;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace EOS_SDK.AntiCheatServer
{
    public unsafe class AntiCheatServer_Exports
    {
        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong _EOS_AntiCheatServer_AddNotifyClientActionRequired(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationFn)
        {
            var _AddNotifyClientActionRequiredOptions = Marshal.PtrToStructure<AddNotifyClientActionRequiredOptions>(options);
            delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)notificationFn; //Delegate Class was: AntiCheatServer.OnClientActionRequiredCallback
            return 0;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong _EOS_AntiCheatServer_AddNotifyClientAuthStatusChanged(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationFn)
        {
            var _AddNotifyClientAuthStatusChangedOptions = Marshal.PtrToStructure<AddNotifyClientAuthStatusChangedOptions>(options);
            delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)notificationFn; //Delegate Class was: AntiCheatServer.OnClientAuthStatusChangedCallback
            return 0;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong _EOS_AntiCheatServer_AddNotifyMessageToClient(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationFn)
        {
            var _AddNotifyMessageToClientOptions = Marshal.PtrToStructure<AddNotifyMessageToClientOptions>(options);
            delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)notificationFn; //Delegate Class was: AntiCheatServer.OnMessageToClientCallback
            return 0;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int _EOS_AntiCheatServer_BeginSession(IntPtr handle, IntPtr options)
        {
            var _BeginSessionOptions = Marshal.PtrToStructure<BeginSessionOptions>(options);
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int _EOS_AntiCheatServer_EndSession(IntPtr handle, IntPtr options)
        {
            var _EndSessionOptions = Marshal.PtrToStructure<EndSessionOptions>(options);
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int _EOS_AntiCheatServer_GetProtectMessageOutputLength(IntPtr handle, IntPtr options, [Out] uint outBufferSizeBytes)
        {
            var _GetProtectMessageOutputLengthOptions = Marshal.PtrToStructure<GetProtectMessageOutputLengthOptions>(options);
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int _EOS_AntiCheatServer_LogEvent(IntPtr handle, IntPtr options)
        {
            var _LogEventOptions = Marshal.PtrToStructure<LogEventOptions>(options);
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int _EOS_AntiCheatServer_LogGameRoundEnd(IntPtr handle, IntPtr options)
        {
            var _LogGameRoundEndOptions = Marshal.PtrToStructure<LogGameRoundEndOptions>(options);
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int _EOS_AntiCheatServer_LogGameRoundStart(IntPtr handle, IntPtr options)
        {
            var _LogGameRoundStartOptions = Marshal.PtrToStructure<LogGameRoundStartOptions>(options);
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int _EOS_AntiCheatServer_LogPlayerDespawn(IntPtr handle, IntPtr options)
        {
            var _LogPlayerDespawnOptions = Marshal.PtrToStructure<LogPlayerDespawnOptions>(options);
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int _EOS_AntiCheatServer_LogPlayerRevive(IntPtr handle, IntPtr options)
        {
            var _LogPlayerReviveOptions = Marshal.PtrToStructure<LogPlayerReviveOptions>(options);
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int _EOS_AntiCheatServer_LogPlayerSpawn(IntPtr handle, IntPtr options)
        {
            var _LogPlayerSpawnOptions = Marshal.PtrToStructure<LogPlayerSpawnOptions>(options);
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int _EOS_AntiCheatServer_LogPlayerTakeDamage(IntPtr handle, IntPtr options)
        {
            var _LogPlayerTakeDamageOptions = Marshal.PtrToStructure<LogPlayerTakeDamageOptions>(options);
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int _EOS_AntiCheatServer_LogPlayerTick(IntPtr handle, IntPtr options)
        {
            var _LogPlayerTickOptions = Marshal.PtrToStructure<LogPlayerTickOptions>(options);
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int _EOS_AntiCheatServer_LogPlayerUseAbility(IntPtr handle, IntPtr options)
        {
            var _LogPlayerUseAbilityOptions = Marshal.PtrToStructure<LogPlayerUseAbilityOptions>(options);
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int _EOS_AntiCheatServer_LogPlayerUseWeapon(IntPtr handle, IntPtr options)
        {
            var _LogPlayerUseWeaponOptions = Marshal.PtrToStructure<LogPlayerUseWeaponOptions>(options);
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int _EOS_AntiCheatServer_ProtectMessage(IntPtr handle, IntPtr options, IntPtr outBuffer, [Out] uint outBytesWritten)
        {
            var _ProtectMessageOptions = Marshal.PtrToStructure<ProtectMessageOptions>(options);
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int _EOS_AntiCheatServer_ReceiveMessageFromClient(IntPtr handle, IntPtr options)
        {
            var _ReceiveMessageFromClientOptions = Marshal.PtrToStructure<ReceiveMessageFromClientOptions>(options);
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int _EOS_AntiCheatServer_RegisterClient(IntPtr handle, IntPtr options)
        {
            var _RegisterClientOptions = Marshal.PtrToStructure<RegisterClientOptionsV2>(options);
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int _EOS_AntiCheatServer_RegisterEvent(IntPtr handle, IntPtr options)
        {
            var _RegisterEventOptions = Marshal.PtrToStructure<RegisterEventOptions>(options);
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void _EOS_AntiCheatServer_RemoveNotifyClientActionRequired(IntPtr handle, ulong notificationId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void _EOS_AntiCheatServer_RemoveNotifyClientAuthStatusChanged(IntPtr handle, ulong notificationId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void _EOS_AntiCheatServer_RemoveNotifyMessageToClient(IntPtr handle, ulong notificationId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int _EOS_AntiCheatServer_SetClientDetails(IntPtr handle, IntPtr options)
        {
            var _SetClientDetailsOptions = Marshal.PtrToStructure<SetClientDetailsOptions>(options);
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int _EOS_AntiCheatServer_SetClientNetworkState(IntPtr handle, IntPtr options)
        {
            var _SetClientNetworkStateOptions = Marshal.PtrToStructure<SetClientNetworkStateOptions>(options);
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int _EOS_AntiCheatServer_SetGameSessionId(IntPtr handle, IntPtr options)
        {
            var _SetGameSessionIdOptions = Marshal.PtrToStructure<SetGameSessionIdOptions>(options);
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int _EOS_AntiCheatServer_UnprotectMessage(IntPtr handle, IntPtr options, IntPtr outBuffer, [Out] uint outBytesWritten)
        {
            var _UnprotectMessageOptions = Marshal.PtrToStructure<UnprotectMessageOptions>(options);
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int _EOS_AntiCheatServer_UnregisterClient(IntPtr handle, IntPtr options)
        {
            var _UnregisterClientOptions = Marshal.PtrToStructure<UnregisterClientOptions>(options);
            return (int)Result.Success;
        }
    }
}
