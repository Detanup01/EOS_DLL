namespace EOS_SDK._Data;

/// <summary>
/// An Interface to easier to call function on ot.
/// </summary>
public interface IHandler : IDisposable
{
    /// <summary>
    /// Creating a Pointer to this Handle
    /// </summary>
    /// <returns>Allocated Memory</returns>
    public IntPtr Create();

    /// <summary>
    /// A Tick or Update
    /// </summary>
    public void Tick();
}
