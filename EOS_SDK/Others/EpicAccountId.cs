using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace EOS_SDK.Others
{
    public unsafe class EpicAccountId
    {
        public const int EpicaccountidMaxLength = 32;
        public static string Static_EpicAccountId = "ffaabbccddeeff0123456789deadc0de";   //Init just for test stuff
        public const string Invalid_EpicAccountId = "ffffffffffffffffffffffffffffffff";

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_EpicAccountId_FromString(IntPtr accountIdString)
        {
            string UserID = Functions.ToString(accountIdString);
            if (UserID.Length == EpicaccountidMaxLength && Regex.Match(UserID, "[a-fA-F0-9]{32}").Success)
                Static_EpicAccountId = UserID;
            return Functions.FromString(Static_EpicAccountId);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_EpicAccountId_IsValid(IntPtr accountId)
        {
            var UserId = Functions.ToString(accountId);
            if (UserId == Static_EpicAccountId)
                return 1;
            if (UserId.Length == EpicaccountidMaxLength)
                return 1;
            if (Regex.Match(UserId, "[a-fA-F0-9]{32}").Success)
                return 1;
            return 0;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_EpicAccountId_ToString(IntPtr accountId, IntPtr outBuffer, [Out] int inOutBufferLength)
        {
            string UserID = Functions.ToString(accountId);
            if (UserID.Length == EpicaccountidMaxLength && Regex.Match(UserID, "[a-fA-F0-9]{32}").Success)
                Static_EpicAccountId = UserID;
            else
                return (int)Result.InvalidUser;
            if (inOutBufferLength != EpicaccountidMaxLength + 1)
                return (int)Result.InvalidParameters;
            var ptr = Functions.FromString(Static_EpicAccountId);
            Marshal.WriteIntPtr(outBuffer, 0, ptr);
            return (int)Result.Success;
        }
    }
}
