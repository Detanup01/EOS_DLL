using EOS_SDK._Data;
using EOS_SDK._log;
using EOS_SDK.Platform;
using EOS_SDK.Version;
using System.Runtime.InteropServices;

namespace EOS_SDK.Others
{
    public unsafe class Common
    {
        [UnmanagedCallersOnly(EntryPoint = "EOS_ByteArray_ToString")]
        public static int EOS_ByteArray_ToString(IntPtr byteArray, uint length, IntPtr outBuffer, uint inOutBufferLength)
        {
            List<byte> bytes = new List<byte>();
            try
            {
                for (int i = 0; i <= length; i++)
                {
                    byte readed = Marshal.ReadByte(byteArray, i);
                    bytes.Add(readed);
                }
            }
            catch 
            {
                _log.Logger.WriteWarn("EOS_ByteArray_ToString Error, cannot read more bytes.");
            }

            var str = Convert.ToHexString(bytes.ToArray());
            if (str.Length > inOutBufferLength)
                return (int)Result.InvalidParameters;
            var ptr = Helpers.FromString(str);
            Marshal.WriteIntPtr(outBuffer, ptr);
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(EntryPoint = "EOS_ContinuanceToken_ToString")]
        public static int EOS_ContinuanceToken_ToString(IntPtr continuanceToken, IntPtr outBuffer, int inOutBufferLength)
        {
            return (int)Result.InvalidUser;
        }

        [UnmanagedCallersOnly(EntryPoint = "EOS_EApplicationStatus_ToString")]
        public static IntPtr EOS_EApplicationStatus_ToString(int applicationStatus)
        {
            var status = (ApplicationStatus)applicationStatus;
            var str = $"EOS_AS_{status.ToString()}";
            return Helpers.FromString(str);
        }

        [UnmanagedCallersOnly(EntryPoint = "EOS_ENetworkStatus_ToString")]
        public static IntPtr EOS_ENetworkStatus_ToString(int networkStatus)
        {
            var status = (NetworkStatus)networkStatus;
            var str = $"EOS_NS_{status.ToString()}";
            return Helpers.FromString(str);
        }

        [UnmanagedCallersOnly(EntryPoint = "EOS_EResult_IsOperationComplete")]
        public static int EOS_EResult_IsOperationComplete(int result)
        {
            return 1;
        }

        [UnmanagedCallersOnly(EntryPoint = "EOS_EResult_ToString")]
        public static IntPtr EOS_EResult_ToString(int result)
        {
            var eresult = (Result)result;
            var str = $"EOS_{eresult.ToString()}";
            return Helpers.FromString(str);
        }

        [UnmanagedCallersOnly(EntryPoint = "EOS_Initialize")]
        public static int EOS_Initialize(IntPtr options)
        {
            if (EOS_Main.IsInited())
                return (int)Result.AlreadyConfigured;
            if (options == nint.Zero)
                return (int)Result.InvalidParameters; 

            var ver = Helpers.GetVersionFromStructPTR(options);
            if (ver > Versions.InitializeApiLatest)
                Logger.WriteError("EOS_Initialize trying to Initialize version " + ver);
            // always fallback to 0
            var _InitializeOptions = Marshal.PtrToStructure<InitializeOptionsV1>(options);
            EOS_Main.Create(_InitializeOptions);
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(EntryPoint = "EOS_Shutdown")]
        public static int EOS_Shutdown()
        {
            EOS_Main.Shutdown();
            return (int)Result.Success;
        }
    }
}
