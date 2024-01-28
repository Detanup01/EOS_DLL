using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOS_SDK.ProgressionSnapshot
{
    public unsafe class ProgressionSnapshot_Exports
    {
#if false

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_ProgressionSnapshot_AddProgression(IntPtr handle, IntPtr options)
		{
			var _AddProgressionOptions = Marshal.PtrToStructure<AddProgressionOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_ProgressionSnapshot_BeginSnapshot(IntPtr handle, IntPtr options, [Out] uint outSnapshotId)
		{
			var _BeginSnapshotOptions = Marshal.PtrToStructure<BeginSnapshotOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_ProgressionSnapshot_DeleteSnapshot(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _DeleteSnapshotOptions = Marshal.PtrToStructure<DeleteSnapshotOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: ProgressionSnapshot.OnDeleteSnapshotCallback
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static Result EOS_ProgressionSnapshot_EndSnapshot(IntPtr handle, IntPtr options)
		{
			var _EndSnapshotOptions = Marshal.PtrToStructure<EndSnapshotOptions>(options);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void EOS_ProgressionSnapshot_SubmitSnapshot(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
		{
			var _SubmitSnapshotOptions = Marshal.PtrToStructure<SubmitSnapshotOptions>(options);
			delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate; //Delegate Class was: ProgressionSnapshot.OnSubmitSnapshotCallback
        }
#endif
    }
}
