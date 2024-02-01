using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace EOS_SDK.Others
{
    public class ProductUserId
    {
        public const int ProductuseridMaxLength = 32;
        public static string Static_ProductUserId = "deadc0deffaabbccddeeff0123456789";   //Init just for test stuff
        public const string Invalid_ProductUserId = "ffffffffffffffffffffffffffffffff";

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_ProductUserId_FromString(IntPtr productUserIdString)
        {
            string UserID = Helpers.ToString(productUserIdString);
            if (UserID.Length == ProductuseridMaxLength && Regex.Match(UserID, "[a-fA-F0-9]{32}").Success)
                Static_ProductUserId = UserID;
            return Helpers.FromString(Static_ProductUserId);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_ProductUserId_IsValid(IntPtr accountId)
        {
            var UserId = Helpers.ToString(accountId);
            if (UserId.Length == ProductuseridMaxLength)
                return 1;
            if (Regex.Match(UserId, "[a-fA-F0-9]{32}").Success)
                return 1;
            return 0;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_ProductUserId_ToString(IntPtr accountId, IntPtr outBuffer, int inOutBufferLength)
        {
            string UserID = Helpers.ToString(accountId);
            if (UserID.Length == ProductuseridMaxLength && Regex.Match(UserID, "[a-fA-F0-9]{32}").Success)
                Static_ProductUserId = UserID;
            else
                return (int)Result.InvalidUser;
            if (inOutBufferLength != ProductuseridMaxLength + 1)
                return (int)Result.InvalidParameters;
            var ptr = Helpers.FromString(Static_ProductUserId);
            Marshal.WriteIntPtr(outBuffer, 0, ptr);
            return (int)Result.Success;
        }
        public static string Generate()
        {
            var byets = RandomNumberGenerator.GetBytes(ProductuseridMaxLength / 2);
            return Convert.ToHexString(byets).ToLower();
        }

        public static string Generator(string productId, string username)
        {
            byte[] bytes = new byte[ProductuseridMaxLength / 2];

            for (int i = 0; i < ProductuseridMaxLength / 2; ++i)
                bytes[i] = (byte)(productId[i] ^ username[i % username.Length] ^ 0x666); // for productUser

            return Convert.ToHexString(bytes).ToLower();
        }
    }
}
