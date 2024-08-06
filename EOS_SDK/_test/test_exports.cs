using EOS_SDK._Data;
using System.Runtime.InteropServices;

namespace EOS_SDK._test
{
    public unsafe class test_exports
    {
        [UnmanagedCallersOnly(EntryPoint = "_TESTAddNotify")]
        public static ulong _TESTAddNotify(int number, IntPtr notifyDelegate)
        {
            AddNotifyResult notifyResult = new() { dataPassed = number };
            Console.WriteLine("DLL_TESTAddNotify");
            Console.WriteLine(notifyResult.ToString());
            return NotifyManager.AddNotify(nameof(_TESTTriggerNotify), notifyDelegate, notifyResult);
        }

        [UnmanagedCallersOnly(EntryPoint = "_TESTRemoveNotify")]
        public static void _TESTRemoveNotify(ulong id)
        {
            NotifyManager.RemoveNotify(id);
        }

        [UnmanagedCallersOnly(EntryPoint = "_TESTTriggerNotify")]
        public static void _TESTTriggerNotify(IntPtr completionDelegate)
        {
            TriggerNotifyResult triggerNotifyResult = new()
            { 
                data = 342342,
                Result = 555
            };
            NotifyManager.TriggerNotify(nameof(_TESTTriggerNotify), triggerNotifyResult);
            delegate* unmanaged<IntPtr, void> @delegate = (delegate* unmanaged<IntPtr, void>)completionDelegate;
            var ptr = Helpers.StructToPtr(triggerNotifyResult);
            @delegate(ptr);
        }

        [StructLayout(LayoutKind.Sequential, Pack = 8)]
        internal struct AddNotifyResult
        {
            public int dataPassed;
            public int data;
            public int result;

            public override string ToString()
            {
                return $"dataPassed: {dataPassed} | data: {data} | result: {result}";
            }

            public static AddNotifyResult Set(AddNotifyResult main, TriggerNotifyResult trigger)
            {
                var ret = new AddNotifyResult();
                ret = main;
                ret.data = trigger.data;
                ret.result = trigger.Result;
                return ret;
            }
        }

        [StructLayout(LayoutKind.Sequential, Pack = 8)]
        internal struct TriggerNotifyResult
        {
            public int Result;
            public int data;

            public override string ToString()
            {
                return $"Result: {Result} | data: {data}";
            }
            public static TriggerNotifyResult Set(TriggerNotifyResult main, AddNotifyResult addNotifyResult)
            {
                var ret = new TriggerNotifyResult();
                ret = main;
                ret.data = addNotifyResult.data;
                ret.Result = addNotifyResult.result;
                return ret;
            }
        }
    }
}
