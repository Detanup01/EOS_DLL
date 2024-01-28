using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOS_SDK.P2P
{
    public unsafe class P2P_Exports
    {
#if false

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_P2P_AcceptConnection(IntPtr handle, IntPtr options)
		{
			var _AcceptConnectionOptions = Marshal.PtrToStructure<AcceptConnectionOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_P2P_AddNotifyIncomingPacketQueueFull(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr incomingPacketQueueFullHandler)
		{
			var _AddNotifyIncomingPacketQueueFullOptions = Marshal.PtrToStructure<AddNotifyIncomingPacketQueueFullOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)incomingPacketQueueFullHandler; //Delegate Class was: P2P.OnIncomingPacketQueueFullCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_P2P_AddNotifyPeerConnectionClosed(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr connectionClosedHandler)
		{
			var _AddNotifyPeerConnectionClosedOptions = Marshal.PtrToStructure<AddNotifyPeerConnectionClosedOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)connectionClosedHandler; //Delegate Class was: P2P.OnRemoteConnectionClosedCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_P2P_AddNotifyPeerConnectionEstablished(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr connectionEstablishedHandler)
		{
			var _AddNotifyPeerConnectionEstablishedOptions = Marshal.PtrToStructure<AddNotifyPeerConnectionEstablishedOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)connectionEstablishedHandler; //Delegate Class was: P2P.OnPeerConnectionEstablishedCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_P2P_AddNotifyPeerConnectionInterrupted(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr connectionInterruptedHandler)
		{
			var _AddNotifyPeerConnectionInterruptedOptions = Marshal.PtrToStructure<AddNotifyPeerConnectionInterruptedOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)connectionInterruptedHandler; //Delegate Class was: P2P.OnPeerConnectionInterruptedCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_P2P_AddNotifyPeerConnectionRequest(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr connectionRequestHandler)
		{
			var _AddNotifyPeerConnectionRequestOptions = Marshal.PtrToStructure<AddNotifyPeerConnectionRequestOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)connectionRequestHandler; //Delegate Class was: P2P.OnIncomingConnectionRequestCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_P2P_ClearPacketQueue(IntPtr handle, IntPtr options)
		{
			var _ClearPacketQueueOptions = Marshal.PtrToStructure<ClearPacketQueueOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_P2P_CloseConnection(IntPtr handle, IntPtr options)
		{
			var _CloseConnectionOptions = Marshal.PtrToStructure<CloseConnectionOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_P2P_CloseConnections(IntPtr handle, IntPtr options)
		{
			var _CloseConnectionsOptions = Marshal.PtrToStructure<CloseConnectionsOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_P2P_GetNATType(IntPtr handle, IntPtr options, [Out] P2P.NATType outNATType)
		{
			var _GetNATTypeOptions = Marshal.PtrToStructure<GetNATTypeOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_P2P_GetNextReceivedPacketSize(IntPtr handle, IntPtr options, [Out] uint outPacketSizeBytes)
		{
			var _GetNextReceivedPacketSizeOptions = Marshal.PtrToStructure<GetNextReceivedPacketSizeOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_P2P_GetPacketQueueInfo(IntPtr handle, IntPtr options, IntPtr P2P.PacketQueueInfo outPacketQueueInfo)
		{
			var _GetPacketQueueInfoOptions = Marshal.PtrToStructure<GetPacketQueueInfoOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)P2P.PacketQueueInfo; //Delegate Class was: [Out]
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_P2P_GetPortRange(IntPtr handle, IntPtr options, [Out] ushort outPort, [Out] ushort outNumAdditionalPortsToTry)
		{
			var _GetPortRangeOptions = Marshal.PtrToStructure<GetPortRangeOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_P2P_GetRelayControl(IntPtr handle, IntPtr options, [Out] P2P.RelayControl outRelayControl)
		{
			var _GetRelayControlOptions = Marshal.PtrToStructure<GetRelayControlOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_P2P_QueryNATType(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _QueryNATTypeOptions = Marshal.PtrToStructure<QueryNATTypeOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: P2P.OnQueryNATTypeCompleteCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_P2P_ReceivePacket(IntPtr handle, IntPtr options, IntPtr outPeerId, IntPtr P2P.SocketIdpublic outSocketId, IntPtr byte outChannel, IntPtr outData, IntPtr uint outBytesWritten)
		{
			var _ReceivePacketOptions = Marshal.PtrToStructure<ReceivePacketOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)P2P.SocketIdpublic; //Delegate Class was: [Out]
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_P2P_RemoveNotifyIncomingPacketQueueFull(IntPtr handle, ulong notificationId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_P2P_RemoveNotifyPeerConnectionClosed(IntPtr handle, ulong notificationId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_P2P_RemoveNotifyPeerConnectionEstablished(IntPtr handle, ulong notificationId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_P2P_RemoveNotifyPeerConnectionInterrupted(IntPtr handle, ulong notificationId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_P2P_RemoveNotifyPeerConnectionRequest(IntPtr handle, ulong notificationId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_P2P_SendPacket(IntPtr handle, IntPtr options)
		{
			var _SendPacketOptions = Marshal.PtrToStructure<SendPacketOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_P2P_SetPacketQueueSize(IntPtr handle, IntPtr options)
		{
			var _SetPacketQueueSizeOptions = Marshal.PtrToStructure<SetPacketQueueSizeOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_P2P_SetPortRange(IntPtr handle, IntPtr options)
		{
			var _SetPortRangeOptions = Marshal.PtrToStructure<SetPortRangeOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_P2P_SetRelayControl(IntPtr handle, IntPtr options)
		{
			var _SetRelayControlOptions = Marshal.PtrToStructure<SetRelayControlOptions>(options);
        }

#endif
    }
}
