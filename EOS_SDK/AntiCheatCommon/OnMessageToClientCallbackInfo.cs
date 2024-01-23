using System.Runtime.InteropServices;

namespace EOS_SDK.AntiCheatCommon
{

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct OnMessageToClientCallbackInfopublic
    {
        public IntPtr m_ClientData;
        public IntPtr m_ClientHandle;
        public IntPtr m_MessageData;
        public uint m_MessageDataSizeBytes;
    }
}