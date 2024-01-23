using System.Runtime.InteropServices;
using System.Text;

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
            Console.WriteLine(data.Str);
            string str;
            GetAllocation(data.Str2, out str);
            Console.WriteLine(str);
        }

        private static int GetAnsiStringLength(IntPtr address)
        {
            int length = 0;
            while (Marshal.ReadByte(address, length) != 0)
            {
                ++length;
            }

            return length;
        }

        private static void GetAllocation(IntPtr source, out string target)
        {
            target = null;

            if (source == IntPtr.Zero)
            {
                return;
            }

            // C style strlen
            int length = GetAnsiStringLength(source);

            // +1 byte for the null terminator.
            byte[] bytes = new byte[length + 1];
            Marshal.Copy(source, bytes, 0, length + 1);

            target = Encoding.UTF8.GetString(bytes);
        }
    }
}
