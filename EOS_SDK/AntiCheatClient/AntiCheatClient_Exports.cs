using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace EOS_SDK.AntiCheatClient
{
    public unsafe class AntiCheatClient_Exports
    {
        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_AntiCheatClient_AddExternalIntegrityCatalog(IntPtr handle, IntPtr options)
        {
            var _AddExternalIntegrityCatalogOptionspublic = Marshal.PtrToStructure<AddExternalIntegrityCatalogOptionspublic>(options);
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_AntiCheatClient_AddNotifyClientIntegrityViolated(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationFn)
        {
            var _AddNotifyClientIntegrityViolatedOptionspublic = Marshal.PtrToStructure<AddNotifyClientIntegrityViolatedOptionspublic>(options);
            delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)notificationFn; //Delegate Class was: AntiCheatClient.OnClientIntegrityViolatedCallbackpublic
            return 0;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_AntiCheatClient_AddNotifyMessageToPeer(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationFn)
        {
            var _AddNotifyMessageToPeerOptionspublic = Marshal.PtrToStructure<AddNotifyMessageToPeerOptionspublic>(options);
            delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)notificationFn; //Delegate Class was: AntiCheatClient.OnMessageToPeerCallbackpublic
            return 0;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_AntiCheatClient_AddNotifyMessageToServer(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationFn)
        {
            var _AddNotifyMessageToServerOptionspublic = Marshal.PtrToStructure<AddNotifyMessageToServerOptionspublic>(options);
            delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)notificationFn; //Delegate Class was: AntiCheatClient.OnMessageToServerCallbackpublic
            return 0;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_AntiCheatClient_AddNotifyPeerActionRequired(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationFn)
        {
            var _AddNotifyPeerActionRequiredOptionspublic = Marshal.PtrToStructure<AddNotifyPeerActionRequiredOptionspublic>(options);
            delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)notificationFn; //Delegate Class was: AntiCheatClient.OnPeerActionRequiredCallbackpublic
            return 0;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_AntiCheatClient_AddNotifyPeerAuthStatusChanged(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationFn)
        {
            var _AddNotifyPeerAuthStatusChangedOptionspublic = Marshal.PtrToStructure<AddNotifyPeerAuthStatusChangedOptionspublic>(options);
            delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)notificationFn; //Delegate Class was: AntiCheatClient.OnPeerAuthStatusChangedCallbackpublic
            return 0;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_AntiCheatClient_BeginSession(IntPtr handle, IntPtr options)
        {
            var _BeginSessionOptionspublic = Marshal.PtrToStructure<BeginSessionOptionspublic>(options);
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_AntiCheatClient_EndSession(IntPtr handle, IntPtr options)
        {
            var _EndSessionOptionspublic = Marshal.PtrToStructure<EndSessionOptionspublic>(options);
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_AntiCheatClient_GetProtectMessageOutputLength(IntPtr handle, IntPtr options, [Out] uint outBufferSizeBytes)
        {
            var _GetProtectMessageOutputLengthOptionspublic = Marshal.PtrToStructure<GetProtectMessageOutputLengthOptionspublic>(options);
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_AntiCheatClient_PollStatus(IntPtr handle, IntPtr options, [Out] AntiCheatClientViolationType outViolationType, IntPtr outMessage)
        {
            var _PollStatusOptionspublic = Marshal.PtrToStructure<PollStatusOptionspublic>(options);
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_AntiCheatClient_ProtectMessage(IntPtr handle, IntPtr options, IntPtr outBuffer, [Out] uint outBytesWritten)
        {
            var _ProtectMessageOptionspublic = Marshal.PtrToStructure<ProtectMessageOptionspublic>(options);
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_AntiCheatClient_ReceiveMessageFromPeer(IntPtr handle, IntPtr options)
        {
            var _ReceiveMessageFromPeerOptionspublic = Marshal.PtrToStructure<ReceiveMessageFromPeerOptionspublic>(options);
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_AntiCheatClient_ReceiveMessageFromServer(IntPtr handle, IntPtr options)
        {
            var _ReceiveMessageFromServerOptionspublic = Marshal.PtrToStructure<ReceiveMessageFromServerOptionspublic>(options);
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_AntiCheatClient_RegisterPeer(IntPtr handle, IntPtr options)
        {
            var _RegisterPeerOptionspublic = Marshal.PtrToStructure<RegisterPeerOptionspublic>(options);
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
            var _UnprotectMessageOptionspublic = Marshal.PtrToStructure<UnprotectMessageOptionspublic>(options);
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_AntiCheatClient_UnregisterPeer(IntPtr handle, IntPtr options)
        {
            var _UnregisterPeerOptionspublic = Marshal.PtrToStructure<UnregisterPeerOptionspublic>(options);
            return (int)Result.Success;
        }
    }
}
