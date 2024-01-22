using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace EOS_SDK
{
    public class Class1
    {
        public static object Locker = new object();
        [UnmanagedCallersOnly(EntryPoint = "_", CallConvs = new[] { typeof(CallConvCdecl) })]
        public static int _()
        {
            lock (Locker)
            {
                return 0;
            }
        }

    }
}
