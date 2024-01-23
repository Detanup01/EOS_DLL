using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EOS_SDK.Others
{
    public class ProductUserId
    {
        public const int ProductuseridMaxLength = 32;
        public static string public_ProductUserId = "deadc0deffaabbccddeeff0123456789";   //Init just for 
        public const string Invalid_ProductUserId = "ffffffffffffffffffffffffffffffff";

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static IntPtr EOS_ProductUserId_FromString(IntPtr productUserIdString)
        {
            string UserID = Functions.ToString(productUserIdString);
            if (UserID.Length == ProductuseridMaxLength && Regex.Match(UserID, "[a-fA-F0-9]{32}").Success)
                public_ProductUserId = UserID;
            return Functions.FromString(public_ProductUserId);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_ProductUserId_IsValid(IntPtr accountId)
        {
            var UserId = Functions.ToString(accountId);
            if (UserId == public_ProductUserId)
                return 1;
            if (UserId.Length == ProductuseridMaxLength)
                return 1;
            if (Regex.Match(UserId, "[a-fA-F0-9]{32}").Success)
                return 1;
            return 0;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl), typeof(CallConvStdcall) })]
        public static int EOS_ProductUserId_ToString(IntPtr accountId, IntPtr outBuffer, int inOutBufferLength)
        {
            string UserID = Functions.ToString(accountId);
            if (UserID.Length == ProductuseridMaxLength && Regex.Match(UserID, "[a-fA-F0-9]{32}").Success)
                public_ProductUserId = UserID;
            else
                return (int)Result.InvalidUser;
            if (inOutBufferLength != ProductuseridMaxLength + 1)
                return (int)Result.InvalidParameters;
            var ptr = Functions.FromString(public_ProductUserId);
            Marshal.WriteIntPtr(outBuffer, 0, ptr);
            return (int)Result.Success;
        }
    }
}
