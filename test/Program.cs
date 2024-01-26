using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var id = TESTAddNotify(666,OnOnAddNotifyResultImplementation);
            Console.WriteLine("TESTAddNotifyID:  " + id);
            TESTTriggerNotify(OnTriggerNotifyResultImplementation);
            Console.WriteLine("TESTTriggerNotify triggered!");
            TESTRemoveNotify(id);
            Console.WriteLine("TESTRemoveNotify removed: " + id);
        }


        [DllImport("EOSSDK-Win64-Shipping")]
        public static extern int TESTAddNotify(int dataToPass ,OnAddNotifyResult completionDelegate);

        [DllImport("EOSSDK-Win64-Shipping")]
        public static extern void TESTRemoveNotify(int id);

        [DllImport("EOSSDK-Win64-Shipping")]
        public static extern void TESTTriggerNotify(OnTriggerNotifyResult completionDelegate);

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
