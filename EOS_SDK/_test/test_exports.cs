using EOS_SDK._Data;
using EOS_SDK._log;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace EOS_SDK._test
{
    public unsafe class test_exports
    {
        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int TESTAddNotify(IntPtr completionDelegate)
        {
            AddNotifyResult notifyResult = new()
            { dasda = 23232 };
            return NotifyManager.AddNotify(nameof(TESTTriggerNotify), completionDelegate, notifyResult);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static void TESTRemoveNotify(int id)
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
            public int dasda;
            public int data;
            public int result;

            public override string ToString()
            {
                return $"dasda: {dasda} | data: {data} | result: {result}";
            }

            public static TriggerNotifyResult Set(AddNotifyResult notif)
            {
                return new()
                { 
                    data = notif.data,
                    Result = notif.result
                };
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

            public static AddNotifyResult Set(TriggerNotifyResult result)
            {
                return new()
                {
                    data = result.data,
                    result = result.Result
                };
            }
        }
    }
}
