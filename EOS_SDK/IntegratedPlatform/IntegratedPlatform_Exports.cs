using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOS_SDK.IntegratedPlatform
{
    public unsafe class IntegratedPlatform_Exports
    {
#if false

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static Result EOS_IntegratedPlatformOptionsContainer_Add(IntPtr handle, IntPtr inOptions)
		{
			var _IntegratedPlatformOptionsContainerAddOptions = Marshal.PtrToStructure<IntegratedPlatformOptionsContainerAddOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static void EOS_IntegratedPlatformOptionsContainer_Release(IntPtr integratedPlatformOptionsContainerHandle)
        {
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static ulong EOS_IntegratedPlatform_AddNotifyUserLoginStatusChanged(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr callbackFunction)
		{
			var _AddNotifyUserLoginStatusChangedOptions = Marshal.PtrToStructure<AddNotifyUserLoginStatusChangedOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)callbackFunction; //Delegate Class was: IntegratedPlatform.OnUserLoginStatusChangedCallback
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static void EOS_IntegratedPlatform_ClearUserPreLogoutCallback(IntPtr handle, IntPtr options)
		{
			var _ClearUserPreLogoutCallbackOptions = Marshal.PtrToStructure<ClearUserPreLogoutCallbackOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static Result EOS_IntegratedPlatform_CreateIntegratedPlatformOptionsContainer(IntPtr options, IntPtr outIntegratedPlatformOptionsContainerHandle)
        {
			var _CreateIntegratedPlatformOptionsContainerOptions = Marshal.PtrToStructure<CreateIntegratedPlatformOptionsContainerOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static Result EOS_IntegratedPlatform_FinalizeDeferredUserLogout(IntPtr handle, IntPtr options)
		{
			var _FinalizeDeferredUserLogoutOptions = Marshal.PtrToStructure<FinalizeDeferredUserLogoutOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static void EOS_IntegratedPlatform_RemoveNotifyUserLoginStatusChanged(IntPtr handle, ulong notificationId)
        {
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static Result EOS_IntegratedPlatform_SetUserLoginStatus(IntPtr handle, IntPtr options)
		{
			var _SetUserLoginStatusOptions = Marshal.PtrToStructure<SetUserLoginStatusOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl), typeof(CallConvStdcall)])]
        public static Result EOS_IntegratedPlatform_SetUserPreLogoutCallback(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr callbackFunction)
		{
			var _SetUserPreLogoutCallbackOptions = Marshal.PtrToStructure<SetUserPreLogoutCallbackOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)callbackFunction; //Delegate Class was: IntegratedPlatform.OnUserPreLogoutCallback
        }
#endif
    }
}
