using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace EOS_SDK
{
    public class Main
    {
        public static object Locker = new object();
        public const CallingConvention LibraryCallingConvention =
#if WIN_X86
			CallingConvention.StdCall
#else
            CallingConvention.Cdecl
#endif
            ;

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int _()
        {
            lock (Locker)
            {
                return 0;
            }
        }
        //internal static extern void TEST(System.IntPtr handle, ref TESTInternalInput options, System.IntPtr clientData, OnTESTInternal completionDelegate);
        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static unsafe void TEST(IntPtr handle, IntPtr input, IntPtr clientData, IntPtr onTESTInternal)
        {
            Console.WriteLine("TEST");
            var _TESTInternalInput = Marshal.PtrToStructure<TESTInternalInput>(input);
            Console.WriteLine(_TESTInternalInput.Result);
            TESTInternal tESTInternal = new()
            { 
                Result = 222
            };
            delegate* unmanaged[Cdecl]<TESTInternal*, void> @delegate = (delegate* unmanaged[Cdecl] <TESTInternal*, void>)onTESTInternal;
            @delegate(&tESTInternal);
        }
        [StructLayout(LayoutKind.Sequential, Pack = 8)]
        public struct TESTInternal
        {
            public int Result;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 8)]
        public struct TESTInternalInput
        {
            public int Result;
        }
    }
}
