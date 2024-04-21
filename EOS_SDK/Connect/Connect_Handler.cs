using EOS_SDK._Data;

namespace EOS_SDK.Connect
{
    public class Connect_Handler
    {
        public struct Handler
        {
            public Dictionary<string /* LocalUserId */, IdToken> UserIds;
        }

        static Handler Instance;

        public static IntPtr Create()
        {
            Instance = new()
            {
                UserIds = new()
            };
            _log.Logger.WriteDebug("Connect Created", Logging.LogCategory.Connect);
            return IntPtr.CreateChecked(SDK.ConnectPTR);
        }

        public static void Tick()
        {

        }
    }
}
