﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOS_SDK.KWS
{
    public unsafe class KWS_Exports
    {
#if false

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong EOS_KWS_AddNotifyPermissionsUpdateReceived(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr notificationFn)
		{
			var _AddNotifyPermissionsUpdateReceivedOptions = Marshal.PtrToStructure<AddNotifyPermissionsUpdateReceivedOptions>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)notificationFn; //Delegate Class was: KWS.OnPermissionsUpdateReceivedCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_KWS_CopyPermissionByIndex(IntPtr handle, IntPtr options, IntPtr outPermission)
		{
			var _CopyPermissionByIndexOptions = Marshal.PtrToStructure<CopyPermissionByIndexOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_KWS_CreateUser(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _CreateUserOptions = Marshal.PtrToStructure<CreateUserOptions>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: KWS.OnCreateUserCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_KWS_GetPermissionByKey(IntPtr handle, IntPtr options, IntPtr outPermission)
		{
			var _GetPermissionByKeyOptions = Marshal.PtrToStructure<GetPermissionByKeyOptions>(options);
            //outPermission  = KWSPermissionStatus ref
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_KWS_GetPermissionsCount(IntPtr handle, IntPtr options)
		{
			var _GetPermissionsCountOptions = Marshal.PtrToStructure<GetPermissionsCountOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_KWS_PermissionStatus_Release(IntPtr permissionStatus)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_KWS_QueryAgeGate(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _QueryAgeGateOptions = Marshal.PtrToStructure<QueryAgeGateOptions>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: KWS.OnQueryAgeGateCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_KWS_QueryPermissions(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _QueryPermissionsOptions = Marshal.PtrToStructure<QueryPermissionsOptions>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: KWS.OnQueryPermissionsCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_KWS_RemoveNotifyPermissionsUpdateReceived(IntPtr handle, ulong inId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_KWS_RequestPermissions(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _RequestPermissionsOptions = Marshal.PtrToStructure<RequestPermissionsOptions>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: KWS.OnRequestPermissionsCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_KWS_UpdateParentEmail(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _UpdateParentEmailOptions = Marshal.PtrToStructure<UpdateParentEmailOptions>(options);
			delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)completionDelegate; //Delegate Class was: KWS.OnUpdateParentEmailCallback
        }
#endif
    }
}
