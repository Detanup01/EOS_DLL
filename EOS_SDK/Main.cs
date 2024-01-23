﻿using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

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

        public static IntPtr MakeString(string str)
        {
            var bytes = Encoding.UTF8.GetBytes(str);
            var result_bytes = bytes.Concat(new byte[] { 0x00 }).ToArray();
            var PTR = Marshal.AllocHGlobal(bytes.Length + 1);
            Marshal.Copy(result_bytes, 0, PTR, result_bytes.Length);
            return PTR;
        }

        //public static extern void TEST(IntPtr handle, ref TESTpublicInput options, IntPtr clientData, OnTESTpublic completionDelegate);
        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static unsafe void TEST(IntPtr handle, IntPtr input, IntPtr clientData, IntPtr onTESTpublic)
        {
            Console.WriteLine("TEST");
            var _TESTInput = Marshal.PtrToStructure<TESTInput>(input);
            Console.WriteLine(_TESTInput.Result);
            var str_ptr = MakeString("yeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeet");
            TEST_Struct tEST = new()
            {
                Result = 222,
                Str = "LOOOOOOOOOONG string",
                Str2 = str_ptr
            };

            delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)onTESTpublic;
            var ptr = Marshal.AllocHGlobal(Marshal.SizeOf<TEST_Struct>());
            Marshal.StructureToPtr<TEST_Struct>(tEST, ptr, false);
            @delegate(ptr);
        }
        [StructLayout(LayoutKind.Sequential, Pack = 8)]
        public struct TEST_Struct
        {
            public int Result;
            [MarshalAs(UnmanagedType.LPStr)]
            public string Str;
            public IntPtr Str2;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 8)]
        public struct TESTInput
        {
            public int Result;
        }
    }
}
