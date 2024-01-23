using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOS_SDK.Presence
{
    public unsafe class Presence_Exports
    {
#if false

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_PresenceModification_DeleteData(IntPtr handle, IntPtr options)
		{
			var _PresenceModificationDeleteDataOptions = Marshal.PtrToStructure<PresenceModificationDeleteDataOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_PresenceModification_Release(IntPtr presenceModificationHandle)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_PresenceModification_SetData(IntPtr handle, IntPtr options)
		{
			var _PresenceModificationSetDataOptions = Marshal.PtrToStructure<PresenceModificationSetDataOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_PresenceModification_SetJoinInfo(IntPtr handle, IntPtr options)
		{
			var _PresenceModificationSetJoinInfoOptions = Marshal.PtrToStructure<PresenceModificationSetJoinInfoOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_PresenceModification_SetRawRichText(IntPtr handle, IntPtr options)
		{
			var _PresenceModificationSetRawRichTextOptions = Marshal.PtrToStructure<PresenceModificationSetRawRichTextOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_PresenceModification_SetStatus(IntPtr handle, IntPtr options)
		{
			var _PresenceModificationSetStatusOptions = Marshal.PtrToStructure<PresenceModificationSetStatusOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_Presence_AddNotifyJoinGameAccepted(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationFn)
		{
			var _AddNotifyJoinGameAcceptedOptions = Marshal.PtrToStructure<AddNotifyJoinGameAcceptedOptions>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)notificationFn; //Delegate Class was: Presence.OnJoinGameAcceptedCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_Presence_AddNotifyOnPresenceChanged(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationHandler)
		{
			var _AddNotifyOnPresenceChangedOptions = Marshal.PtrToStructure<AddNotifyOnPresenceChangedOptions>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)notificationHandler; //Delegate Class was: Presence.OnPresenceChangedCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Presence_CopyPresence(IntPtr handle, IntPtr options, IntPtr outPresence)
		{
			var _CopyPresenceOptions = Marshal.PtrToStructure<CopyPresenceOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Presence_CreatePresenceModification(IntPtr handle, IntPtr options, IntPtr outPresenceModificationHandle)
		{
			var _CreatePresenceModificationOptions = Marshal.PtrToStructure<CreatePresenceModificationOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Presence_GetJoinInfo(IntPtr handle, IntPtr options, IntPtr outBuffer, [Out] int inOutBufferLength)
		{
			var _GetJoinInfoOptions = Marshal.PtrToStructure<GetJoinInfoOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_Presence_HasPresence(IntPtr handle, IntPtr options)
		{
			var _HasPresenceOptions = Marshal.PtrToStructure<HasPresenceOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Presence_Info_Release(IntPtr presenceInfo)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Presence_QueryPresence(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _QueryPresenceOptions = Marshal.PtrToStructure<QueryPresenceOptions>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: Presence.OnQueryPresenceCompleteCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Presence_RemoveNotifyJoinGameAccepted(IntPtr handle, ulong inId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Presence_RemoveNotifyOnPresenceChanged(IntPtr handle, ulong notificationId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Presence_SetPresence(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _SetPresenceOptions = Marshal.PtrToStructure<SetPresenceOptions>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: Presence.SetPresenceCompleteCallback
        }
#endif
    }
}
