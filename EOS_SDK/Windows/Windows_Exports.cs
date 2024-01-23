using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace EOS_SDK.Windows
{
    public unsafe class Windows_Exports
    {
#if WIN_X64 || WIN_X86
        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_Platform_Create(IntPtr options)
        {
            var windowsOptions = Marshal.PtrToStructure<WindowsOptions>(options);
            return IntPtr.Zero;
        }
#endif
    }
}
