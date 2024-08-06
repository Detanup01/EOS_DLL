using System.Runtime.InteropServices;

namespace EOS_SDK._Data;

[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 256)]
public struct DummyStruct
{
    public IntPtr DummyName;

    public DummyStruct()
    {
        DummyName = IntPtr.Zero;
    }

    public DummyStruct(string dummyName)
    {
        DummyName = Helpers.FromString(dummyName);
    }
}
