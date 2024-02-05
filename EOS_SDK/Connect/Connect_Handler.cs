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
            _log.Logger.WriteDebug("", Logging.LogCategory.Connect);
            return IntPtr.CreateChecked(SDK.ConnectPTR);
        }
    }
}
