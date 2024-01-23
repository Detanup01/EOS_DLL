using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace EOS_SDK.Others
{
    public unsafe class Common
    {
        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_ByteArray_ToString(IntPtr byteArray, uint length, IntPtr outBuffer, uint inOutBufferLength)
        {
            List<byte> bytes = new List<byte>();
            for (int i = 0; i <= length; i++ )
            {
                byte readed = Marshal.ReadByte(byteArray, i);
                bytes.Add(readed);
            }
            var str = Convert.ToHexString(bytes.ToArray());
            if (str.Length > inOutBufferLength)
                return (int)Result.InvalidParameters;
            var ptr = Functions.FromString(str);
            Marshal.WriteIntPtr(outBuffer, ptr);
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_ContinuanceToken_ToString(IntPtr continuanceToken, IntPtr outBuffer, int inOutBufferLength)
        {
            return (int)Result.InvalidUser;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_EApplicationStatus_ToString(Platform.ApplicationStatus applicationStatus)
        {
            var str = $"EOS_AS_{applicationStatus.ToString()}";
            return Functions.FromString(str);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_ENetworkStatus_ToString(Platform.NetworkStatus networkStatus)
        {
            var str = $"EOS_NS_{networkStatus.ToString()}";
            return Functions.FromString(str);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_EResult_IsOperationComplete(Result result)
        {
            return 1;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_EResult_ToString(Result result)
        {
            var str = $"EOS_{result.ToString()}";
            return Functions.FromString(str);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_Initialize(IntPtr options)
        {
			var _InitializeOptions = Marshal.PtrToStructure<Platform.InitializeOptions>(options);
            return (int)Result.Success;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_Shutdown()
        {
            return (int)Result.Success;
        }
    }
}
