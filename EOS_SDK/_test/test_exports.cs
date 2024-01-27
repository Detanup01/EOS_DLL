using EOS_SDK._Data;
using EOS_SDK._log;
using EOS_SDK.Others;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using static EOS_SDK._test.test_exports;

namespace EOS_SDK._test
{
    public unsafe class test_exports
    {
        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static ulong TESTAddNotify(int number, IntPtr completionDelegate)
        {
            Console.WriteLine(EpicAccountId.Generate());
            AddNotifyResult notifyResult = new()
            { dataPassed = number };
            Console.WriteLine("DLL_TESTAddNotify");
            Console.WriteLine(notifyResult.ToString());
            return NotifyManager.AddNotify(nameof(TESTTriggerNotify), completionDelegate, notifyResult);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void TESTRemoveNotify(ulong id)
        {
            NotifyManager.RemoveNotify(id);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void TESTTriggerNotify(IntPtr completionDelegate)
        {
            TriggerNotifyResult triggerNotifyResult = new()
            { 
                data = 342342,
                Result = 555
            };
            NotifyManager.TriggerNotify(nameof(TESTTriggerNotify), triggerNotifyResult);
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
