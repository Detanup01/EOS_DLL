using System.Diagnostics;
using System.Runtime.InteropServices;

namespace EOS_SDK._Data
{
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct DummyStruct
    {
        public IntPtr DummyName;

        public DummyStruct()
        {
            StackTrace stackTrace = new StackTrace(1, false);
            var frame = stackTrace.GetFrame(0);
            if (frame == null)
            {
                DummyName = 0;
                return;
            }
            var method = frame.GetMethod();
            if (method == null)
            {
                DummyName = 0;
                return;
            }
            var dec = method.DeclaringType;
            if (dec == null)
            {
                DummyName = 0;
                return;
            }
            var name = dec.FullName;
            if (name == null)
            {
                DummyName = 0;
                return;
            }
            DummyName = Helpers.FromString(name);
        }
    }
}
