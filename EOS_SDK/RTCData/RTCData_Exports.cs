using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace EOS_SDK.RTCData;

public unsafe class RTCData_Exports
{
#if false
	[UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
    public static ulong EOS_RTCData_AddNotifyDataReceived(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
	{
		return 0;
	}

    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
    public static ulong EOS_RTCData_AddNotifyParticipantUpdated(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
    {
        return 0;
    }

    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
    public static void EOS_RTCData_RemoveNotifyDataReceived(IntPtr handle, ulong notificationId)
    {

    }

    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
    public static void EOS_RTCData_RemoveNotifyParticipantUpdated(IntPtr handle, ulong notificationId)
    {

    }

    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
    public static int EOS_RTCData_SendData(IntPtr handle, IntPtr options)
    {
        return (int)Result.Success;
    }

    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
    public static void EOS_RTCData_UpdateReceiving(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
    {

    }

    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
    public static void EOS_RTCData_UpdateSending(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
    {

    }
#endif
}
