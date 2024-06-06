namespace EOS_SDK._Data;

public interface IHandler
{
    public IntPtr Create();
    public void Tick();
    public void Close();
}
