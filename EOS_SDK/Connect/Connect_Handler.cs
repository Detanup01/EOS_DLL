using EOS_SDK._Data;

namespace EOS_SDK.Connect
{
    internal class Connect_Handler
    {
        public struct Handler
        {
        }

        static Handler Instance;

        public static IntPtr Create()
        {
            Instance = new()
            {

            };
            _log.Logger.WriteDebug("Connect Created", Logging.LogCategory.Connect);
            return IntPtr.CreateChecked(SDK.ConnectPTR);
        }
    }
}
