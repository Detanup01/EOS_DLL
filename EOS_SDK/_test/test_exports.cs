using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace EOS_SDK._test
{
    public unsafe class test_exports
    {
        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void TEST(IntPtr handle, IntPtr options, IntPtr clientData, IntPtr completionDelegate)
        {
            var version = Helpers.GetVersionFromStructPTR(options);
            if (version == 1)
            {
                var input_v1 = Marshal.PtrToStructure<TESTInternalInput>(options);
                Console.WriteLine("Version 1");
                Console.WriteLine(input_v1.Result);
                Console.WriteLine(input_v1.data);
            }
            else if (version == 2)
            {
                var input_v2 = Marshal.PtrToStructure<TESTInternalInputv2>(options);
                Console.WriteLine("Version 2");
                Console.WriteLine(input_v2.Result);
                Console.WriteLine(input_v2.data);
                Console.WriteLine(input_v2.value);
            }
            else
            {
                Console.WriteLine("Unrecognised version : " + version);
            }

            TESTInternal tESTInternal = new()
            { 
                Result = 2342432,
                Str = "yeet",
                Str2 = Helpers.FromString("yeeet")
            };
            delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate;
            var ptr = Helpers.StructToPtr(tESTInternal);
            @delegate(ptr);
        }

        [StructLayout(LayoutKind.Sequential, Pack = 8)]
        internal struct TESTInternalInput
        {
            public int Result;
            public int data;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 8)]
        internal struct TESTInternalInputv2
        {
            public int Result;
            public int data;
            public int value;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 8)]
        internal struct TESTInternal
        {
            public int Result;
            [MarshalAs(UnmanagedType.LPStr)]
            public string Str;
            public IntPtr Str2;
        }
    }
}
