using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace EOS_SDK.AntiCheatClient
{
    public unsafe class AntiCheatClient_Exports
    {
        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_AntiCheatClient_AddExternalIntegrityCatalog(IntPtr handle, IntPtr options)
        {
            var _AddExternalIntegrityCatalogOptions = Marshal.PtrToStructure<AddExternalIntegrityCatalogOptions>(options);
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_AntiCheatClient_AddNotifyClientIntegrityViolated(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationFn)
        {
            var _AddNotifyClientIntegrityViolatedOptions = Marshal.PtrToStructure<AddNotifyClientIntegrityViolatedOptions>(options);
            delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)notificationFn; //Delegate Class was: AntiCheatClient.OnClientIntegrityViolatedCallback
            return 0;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_AntiCheatClient_AddNotifyMessageToPeer(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationFn)
        {
            var _AddNotifyMessageToPeerOptions = Marshal.PtrToStructure<AddNotifyMessageToPeerOptions>(options);
            delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)notificationFn; //Delegate Class was: AntiCheatClient.OnMessageToPeerCallback
            return 0;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_AntiCheatClient_AddNotifyMessageToServer(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationFn)
        {
            var _AddNotifyMessageToServerOptions = Marshal.PtrToStructure<AddNotifyMessageToServerOptions>(options);
            delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)notificationFn; //Delegate Class was: AntiCheatClient.OnMessageToServerCallback
            return 0;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_AntiCheatClient_AddNotifyPeerActionRequired(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationFn)
        {
            var _AddNotifyPeerActionRequiredOptions = Marshal.PtrToStructure<AddNotifyPeerActionRequiredOptions>(options);
            delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)notificationFn; //Delegate Class was: AntiCheatClient.OnPeerActionRequiredCallback
            return 0;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_AntiCheatClient_AddNotifyPeerAuthStatusChanged(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationFn)
        {
            var _AddNotifyPeerAuthStatusChangedOptions = Marshal.PtrToStructure<AddNotifyPeerAuthStatusChangedOptions>(options);
            delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)notificationFn; //Delegate Class was: AntiCheatClient.OnPeerAuthStatusChangedCallback
            return 0;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_AntiCheatClient_BeginSession(IntPtr handle, IntPtr options)
        {
            var _BeginSessionOptions = Marshal.PtrToStructure<BeginSessionOptions>(options);
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_AntiCheatClient_EndSession(IntPtr handle, IntPtr options)
        {
            var _EndSessionOptions = Marshal.PtrToStructure<EndSessionOptions>(options);
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_AntiCheatClient_GetProtectMessageOutputLength(IntPtr handle, IntPtr options, [Out] uint outBufferSizeBytes)
        {
            var _GetProtectMessageOutputLengthOptions = Marshal.PtrToStructure<GetProtectMessageOutputLengthOptions>(options);
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_AntiCheatClient_PollStatus(IntPtr handle, IntPtr options, int outViolationType, IntPtr outMessage)
        {
            var _PollStatusOptions = Marshal.PtrToStructure<PollStatusOptions>(options);
            outViolationType = (int)AntiCheatClientViolationType.Invalid;
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_AntiCheatClient_ProtectMessage(IntPtr handle, IntPtr options, IntPtr outBuffer, [Out] uint outBytesWritten)
        {
            var _ProtectMessageOptions = Marshal.PtrToStructure<ProtectMessageOptions>(options);
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_AntiCheatClient_ReceiveMessageFromPeer(IntPtr handle, IntPtr options)
        {
            var _ReceiveMessageFromPeerOptions = Marshal.PtrToStructure<ReceiveMessageFromPeerOptions>(options);
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_AntiCheatClient_ReceiveMessageFromServer(IntPtr handle, IntPtr options)
        {
            var _ReceiveMessageFromServerOptions = Marshal.PtrToStructure<ReceiveMessageFromServerOptions>(options);
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_AntiCheatClient_RegisterPeer(IntPtr handle, IntPtr options)
        {
            var _RegisterPeerOptions = Marshal.PtrToStructure<RegisterPeerOptions>(options);
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_AntiCheatClient_RemoveNotifyClientIntegrityViolated(IntPtr handle, ulong notificationId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_AntiCheatClient_RemoveNotifyMessageToPeer(IntPtr handle, ulong notificationId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_AntiCheatClient_RemoveNotifyMessageToServer(IntPtr handle, ulong notificationId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_AntiCheatClient_RemoveNotifyPeerActionRequired(IntPtr handle, ulong notificationId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_AntiCheatClient_RemoveNotifyPeerAuthStatusChanged(IntPtr handle, ulong notificationId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_AntiCheatClient_UnprotectMessage(IntPtr handle, IntPtr options, IntPtr outBuffer, [Out] uint outBytesWritten)
        {
            var _UnprotectMessageOptions = Marshal.PtrToStructure<UnprotectMessageOptions>(options);
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_AntiCheatClient_UnregisterPeer(IntPtr handle, IntPtr options)
        {
            var _UnregisterPeerOptions = Marshal.PtrToStructure<UnregisterPeerOptions>(options);
            return (int)Result.Success;
        }
    }
}
