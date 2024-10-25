using EOS_SDK._Data;

namespace EOS_SDK.Connect;

public class Connect_Handler : IHandler
{
    public struct Handler
    {
        public Dictionary<string /* LocalUserId */, IdToken> UserIds;
    }

    Handler Instance;

    public nint Create()
    {
        Instance = new()
        {
            UserIds = new()
        };
        _log.Logger.WriteDebug("Connect Created", Logging.LogCategory.Connect);
        return Helpers.StructToPtr(new DummyStruct(nameof(Connect_Handler)));
    }

    public void Tick()
    {
        
    }

    public void Dispose()
    {
        GC.SuppressFinalize(this);
    }
}
