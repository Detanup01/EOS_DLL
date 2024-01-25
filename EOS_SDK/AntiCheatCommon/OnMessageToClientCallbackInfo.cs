using System.Runtime.InteropServices;

namespace EOS_SDK.AntiCheatCommon
{

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct OnMessageToClientCallbackInfo
    {
        public IntPtr ClientData;
        public IntPtr ClientHandle;
        public IntPtr MessageData;
        public uint MessageDataSizeBytes;
    }
}