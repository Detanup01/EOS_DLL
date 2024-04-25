using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using test.HandlerTest;

namespace test
{
    internal class Program
    {
        public static string ToString(IntPtr source)
        {
            if (source == IntPtr.Zero)
            {
                return string.Empty;
            }

            // C style strlen
            int length = GetAnsiStringLength(source);

            // +1 byte for the null terminator.
            byte[] bytes = new byte[length + 1];
            Marshal.Copy(source, bytes, 0, length + 1);
            return Encoding.UTF8.GetString(bytes);
        }
        public static int GetAnsiStringLength(IntPtr address)
        {
            int length = 0;
            while (Marshal.ReadByte(address, length) != 0)
            {
                ++length;
            }

            return length;
        }
        public static IntPtr FromString(string str)
        {
            var bytes = Encoding.UTF8.GetBytes(str);
            var result_bytes = bytes.Concat(new byte[] { 0x00 }).ToArray();
            var PTR = Marshal.AllocHGlobal(bytes.Length + 1);
            Marshal.Copy(result_bytes, 0, PTR, result_bytes.Length);
            return PTR;
        }
        public static IntPtr StructToPtr<T>(T _struct)
        {
            var itemSize = Marshal.SizeOf(typeof(T));
            IntPtr address = Marshal.AllocHGlobal(itemSize);
            Marshal.StructureToPtr(_struct, address, false);
            return address;
        }

        static string productid = "d0864e41284a4c30926a6953b8e77422";
        static void Main(string[] args)
        {
            /*
            MainHandler mainHandler = new();
            var myPointer = mainHandler.Create();
            var ptr = mainHandler.CreateHandler(0x2);

            var sub = mainHandler.GetHandler<SubHandler>(ptr);
            sub.Print();

            ptr = mainHandler.CreateHandler(0x3);
            Console.WriteLine(ptr + " sshould be 0");

            sub = mainHandler.GetHandler<SubHandler>(ptr);
            Console.WriteLine((sub == null) + " sshould be true");

            mainHandler.Interfaces.sub.Print();
            Console.WriteLine(" Interfaces.sub");*/
            /*
            var ptr = IntPtr.CreateChecked(0xABFD3700);
            Console.WriteLine(ptr);
            Console.WriteLine(productid);
            var ret = Generator(productid, "yeet");
            Console.WriteLine(ret);
            Console.WriteLine(Generator(productid, ret));

            ret = Generator2(productid, "yeet");
            Console.WriteLine(ret);
            Console.WriteLine(Generator2(productid, ret));
            ptr = IntPtr.CreateChecked(22);
            Console.WriteLine(ptr);*/
            
            Console.WriteLine("Hello, World!");
            var id = _TESTAddNotify(666,OnOnAddNotifyResultImplementation);
            Console.WriteLine("TESTAddNotifyID:  " + id);
            _TESTTriggerNotify(OnTriggerNotifyResultImplementation);
            Console.WriteLine("TESTTriggerNotify triggered!");
            _TESTRemoveNotify(id);
            Console.WriteLine("TESTRemoveNotify removed: " + id);

        }


        public static string Generator(string appid, string username)
        {

            // Do not append string in the loop; use StringBuilder for this
            byte[] bytes = new byte[32/2];

            // You have no need in SubString and other stuff: just char xor char
            // i % pad.Length - if pad is shorter than plaintext
            for (int i = 0; i < 32/2; ++i)
                bytes[i] = (byte)(appid[i] ^ username[i % username.Length]);

            return Convert.ToHexString(bytes).ToLower();
        }

        public static string Generator2(string appid, string username)
        {

            // Do not append string in the loop; use StringBuilder for this
            byte[] bytes = new byte[32 / 2];

            // You have no need in SubString and other stuff: just char xor char
            // i % pad.Length - if pad is shorter than plaintext
            for (int i = 0; i < 32 / 2; ++i)
                bytes[i] = (byte)(appid[i] ^ username[i % username.Length] ^ 0x666);

            return Convert.ToHexString(bytes).ToLower();
        }

        [DllImport("EOSSDK-Win64-Shipping")]
        public static extern int _TESTAddNotify(int dataToPass ,OnAddNotifyResult completionDelegate);

        [DllImport("EOSSDK-Win64-Shipping")]
        public static extern void _TESTRemoveNotify(int id);

        [DllImport("EOSSDK-Win64-Shipping")]
        public static extern void _TESTTriggerNotify(OnTriggerNotifyResult completionDelegate);

        [StructLayout(LayoutKind.Sequential, Pack = 8)]
        internal struct AddNotifyResult
        {
            public int dataPassed;
            public int data;
            public int result;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 8)]
        internal struct TriggerNotifyResult
        {
            public int Result;
            public int data;
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate void OnAddNotifyResult(ref AddNotifyResult data);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate void OnTriggerNotifyResult(ref TriggerNotifyResult data);

        [MonoPInvokeCallback(typeof(OnAddNotifyResult))]
        internal static void OnOnAddNotifyResultImplementation(ref AddNotifyResult data)
        {
            Console.WriteLine("OnOnAddNotifyResultImplementation!");
            Console.WriteLine(data.dataPassed);
            Console.WriteLine(data.data);
            Console.WriteLine(data.result);
        }

        [MonoPInvokeCallback(typeof(OnAddNotifyResult))]
        internal static void OnTriggerNotifyResultImplementation(ref TriggerNotifyResult data)
        {
            Console.WriteLine("OnTriggerNotifyResultImplementation!");
            Console.WriteLine(data.data);
            Console.WriteLine(data.Result);
        }

    }
}
