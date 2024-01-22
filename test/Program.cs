using System.Runtime.InteropServices;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            TESTInternalInput tESTInternal = new()
            {
                Result = 112
            };
            Console.WriteLine("before test!");
            TEST(IntPtr.Zero, ref tESTInternal, IntPtr.Zero, OnLoginCallbackInternalImplementation);
            Console.WriteLine("after test!");
        }

        [DllImport("EOSSDK-Win64-Shipping")]
        internal static extern void TEST(System.IntPtr handle, ref TESTInternalInput options, System.IntPtr clientData, OnTESTInternal completionDelegate);

        [System.Runtime.InteropServices.UnmanagedFunctionPointer( System.Runtime.InteropServices.CallingConvention.Cdecl)]
        internal delegate void OnTESTInternal(ref TESTInternal data);

        [MonoPInvokeCallback(typeof(OnTESTInternal))]
        internal static void OnLoginCallbackInternalImplementation(ref TESTInternal data)
        {
            Console.WriteLine("OnLoginCallbackInternalImplementation!");
            Console.WriteLine(data.Result);
        }
    }
}
