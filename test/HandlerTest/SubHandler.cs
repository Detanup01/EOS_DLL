using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.HandlerTest
{
    public class SubHandler : IMyHandler
    {
        public IntPtr MyDummyPtr;
        public nint Create()
        {
            DummyStruct dummyStruct = new();
            var retptr = Program.StructToPtr(dummyStruct);
            Console.WriteLine(Program.ToString(dummyStruct.DummyName));
            Console.WriteLine("SubHandler.Create Pointer: " + retptr);
            MyDummyPtr = retptr;
            return retptr;
        }

        public void Print()
        {
            Console.WriteLine("SubHandler.Print");
        }
    }
}
