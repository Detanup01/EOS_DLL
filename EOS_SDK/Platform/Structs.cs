using System.Runtime.InteropServices;

namespace EOS_SDK.Platform
{
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct ClientCredentials
    {
        public IntPtr m_ClientId;
        public IntPtr m_ClientSecret;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct InitializeOptions
    {
        public int m_ApiVersion;
        public IntPtr m_AllocateMemoryFunction;
        public IntPtr m_ReallocateMemoryFunction;
        public IntPtr m_ReleaseMemoryFunction;
        public IntPtr m_ProductName;
        public IntPtr m_ProductVersion;
        public IntPtr m_Reserved;
        public IntPtr m_SystemInitializeOptions;
        public IntPtr m_OverrideThreadAffinity;
    }

}
