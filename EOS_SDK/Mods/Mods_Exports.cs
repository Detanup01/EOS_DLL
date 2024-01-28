using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOS_SDK.Mods
{
    public unsafe class Mods_Exports
    {
#if false
        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_Mods_CopyModInfo(IntPtr handle, IntPtr options, IntPtr outEnumeratedMods)
		{
			var _CopyModInfoOptions = Marshal.PtrToStructure<CopyModInfoOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Mods_EnumerateMods(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _EnumerateModsOptions = Marshal.PtrToStructure<EnumerateModsOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: Mods.OnEnumerateModsCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Mods_InstallMod(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _InstallModOptions = Marshal.PtrToStructure<InstallModOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: Mods.OnInstallModCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Mods_ModInfo_Release(IntPtr modInfo)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Mods_UninstallMod(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _UninstallModOptions = Marshal.PtrToStructure<UninstallModOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: Mods.OnUninstallModCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_Mods_UpdateMod(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _UpdateModOptions = Marshal.PtrToStructure<UpdateModOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: Mods.OnUpdateModCallback
        }
#endif
    }
}
