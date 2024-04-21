using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace test.HandlerTest
{
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct DummyStruct
    {
        public IntPtr DummyName;

        public DummyStruct()
        {
            StackTrace stackTrace = new StackTrace(1, false);
            var frame = stackTrace.GetFrame(0);
            var name = frame.GetMethod().DeclaringType.FullName;
            DummyName = Program.FromString(name);
        }
    }
    public class MainHandler : IMyHandler
    {
        public Dictionary<uint, IMyHandler> Handlers;
        public IntPtr MyDummyPtr;
        public Dictionary<IntPtr, uint> DummyPtrToHandler;


        //  Only use if you know what you doing, its gonna get rewamped for years until finalized :(
        public Interfaces_Struct Interfaces;

        public struct Interfaces_Struct
        {
            public SubHandler sub;
        }
        public IntPtr Create()
        {
            Handlers = new();
            DummyPtrToHandler = new();
            DummyStruct dummyStruct = new();
            var retptr = Program.StructToPtr(dummyStruct);
            Console.WriteLine(Program.ToString(dummyStruct.DummyName));
            Console.WriteLine("MainHandler.Create Pointer: " + retptr);
            MyDummyPtr = retptr;
            Handlers.Add(0x1, this);
            DummyPtrToHandler.Add(retptr, 0x1);
            return retptr;
        }

        public IntPtr CreateHandler(uint handlerCRC)
        {
            IMyHandler? handler = null;
            switch (handlerCRC)
            {
                case 0x2:
                    handler = new SubHandler();
                    Interfaces.sub = (SubHandler)handler;
                    break;
                default:
                    break;
            }
            var ptr = IntPtr.Zero;
            if (handler != null)
            {
                ptr = handler.Create();
                Handlers.Add(handlerCRC, handler);
                DummyPtrToHandler.Add(ptr, handlerCRC);
            }
            return ptr;
        }

        public T? GetHandler<T>(IntPtr ptr_handle) where T : class
        {
            if (!DummyPtrToHandler.TryGetValue(ptr_handle, out uint hex))
            {
                return default;
            }
            if (!Handlers.TryGetValue(hex, out IMyHandler? handler))
            {
                return default;
            }
            if (handler == null)
                return default;
            return (T)handler;
        }
    }
}
