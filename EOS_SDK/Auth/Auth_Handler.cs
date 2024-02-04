using EOS_SDK._Data;
using EOS_SDK.Others;
using EOS_SDK.Platform;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

namespace EOS_SDK.Auth
{
    public class Auth_Handler
    {
        struct AuthStruct
        {
            public bool IsLoggedIn;
            public RSA PublicRSA;
            public RSA PrivateRSA;
        }

        static AuthStruct Auth_Struct;

        public static IntPtr Create()
        {
            Auth_Struct = new AuthStruct();
            RSA_Config();
            return IntPtr.CreateChecked(SDK.AuthPTR);
        }

        public static string GetAccountId()
        {
            return Config.GetConfig().AccountId;
        }

        public static void TriggerStateChange(bool IsLoggedIn, IntPtr localuserid)
        {
            Auth_Struct.IsLoggedIn = IsLoggedIn;
            LoginStatusChangedCallbackInfo info = new()
            {
                CurrentStatus = GetLoginStatus(),
                LocalUserId = localuserid
            };
            NotifyManager.TriggerNotify("AuthNotifyLoginStatus", info);
        }

        public static LoginStatus GetLoginStatus()
        {
            if (Auth_Struct.IsLoggedIn)
                return LoginStatus.LoggedIn;
            return LoginStatus.NotLoggedIn;
        }

        static void RSA_Config()
        {
            Auth_Struct.PrivateRSA = RSA.Create();
            if (!string.IsNullOrWhiteSpace(Config.GetConfig().RSA_Private))
            {
                Auth_Struct.PrivateRSA.FromXmlString(Config.GetConfig().RSA_Private);
            }
            Auth_Struct.PublicRSA = RSA.Create();
            if (!string.IsNullOrWhiteSpace(Config.GetConfig().RSA_Public))
            {
                Auth_Struct.PublicRSA.FromXmlString(Config.GetConfig().RSA_Public);
            }
            else
            {
                Auth_Struct.PublicRSA.FromXmlString(Auth_Struct.PrivateRSA.ToXmlString(false));
            }
            _log.Logger.WriteInfo("RSA: Private XML (base64): " + Convert.ToBase64String(Encoding.UTF8.GetBytes(Auth_Struct.PrivateRSA.ToXmlString(true))) + " | Public XML (base64): " + Convert.ToBase64String(Encoding.UTF8.GetBytes(Auth_Struct.PublicRSA.ToXmlString(false))));

        }

        public static (string Auth, string Refresh, DateTime now) CreateAuthRefresh()
        {
            var now = DateTime.UtcNow;
            JWT.Algorithms.RS256Algorithm rS256Algorithm = new(Auth_Struct.PublicRSA, Auth_Struct.PrivateRSA);

            var auth_Token = JWT.Builder.JwtBuilder.Create()
                .AddHeader(JWT.Builder.HeaderName.Algorithm, "RS256")
                .AddHeader(JWT.Builder.HeaderName.KeyId, "WMS7EnkIGpcH9DGZsv2WcY9xsuFnZCtxZjj4Ahb-_8E")
                .AddHeader("t", "epic_id")
                .AddClaim("sub", Config.GetConfig().AccountId)
                .AddClaim("pfsid", Platform_Handler.PlatformHandler.SandboxId)
                .AddClaim("iss", "https://api.epicgames.dev/epic/oauth/v1")
                .AddClaim("dn", Config.GetConfig().UserName)
                .AddClaim("nonce", Convert.ToBase64String(RandomNumberGenerator.GetBytes(32)))
                .AddClaim("pfpid", Platform_Handler.PlatformHandler.ProductId)
                .AddClaim("sec", 1)
                .AddClaim("aud", Helpers.ToString(Platform_Handler.PlatformHandler.ClientCredentials.ClientId))
                .AddClaim("pfdid", Platform_Handler.PlatformHandler.DeploymentId)
                .AddClaim("t", "epic_id")
                .AddClaim("scope", "basic_profile friends_list openid presence")
                .AddClaim("appid", Config.GetConfig().AppId)
                .AddClaim("exp", TimeHelper.GetEpochTime(now.AddSeconds(7200)))
                .AddClaim("iat", TimeHelper.GetEpochTime(now))
                .AddClaim("jti", EpicAccountId.Generate())
                .WithAlgorithm(rS256Algorithm)
                .Encode();

            var refresh_Token = JWT.Builder.JwtBuilder.Create()
                .AddHeader(JWT.Builder.HeaderName.Algorithm, "RS256")
                .AddHeader(JWT.Builder.HeaderName.KeyId, "WMS7EnkIGpcH9DGZsv2WcY9xsuFnZCtxZjj4Ahb-_8E")
                .AddHeader("t", "epic_id")
                .AddClaim("sub", Config.GetConfig().AccountId)
                .AddClaim("pfsid", Platform_Handler.PlatformHandler.SandboxId)
                .AddClaim("iss", "https://api.epicgames.dev/epic/oauth/v1")
                .AddClaim("dn", Config.GetConfig().UserName)
                .AddClaim("pfpid", Platform_Handler.PlatformHandler.ProductId)
                .AddClaim("aud", Helpers.ToString(Platform_Handler.PlatformHandler.ClientCredentials.ClientId))
                .AddClaim("pfdid", Platform_Handler.PlatformHandler.DeploymentId)
                .AddClaim("t", "epic_id")
                .AddClaim("appid", Config.GetConfig().AppId)
                .AddClaim("scope", "basic_profile friends_list openid presence")
                .AddClaim("exp", TimeHelper.GetEpochTime(now.AddSeconds(28800)))
                .AddClaim("iat", TimeHelper.GetEpochTime(now))
                .AddClaim("jti", EpicAccountId.Generate())
                .WithAlgorithm(rS256Algorithm)
                .Encode();

            return (auth_Token, refresh_Token, now);
        }

        public static string CreateToken()
        {
            var now = DateTime.UtcNow;
            JWT.Algorithms.RS256Algorithm rS256Algorithm = new(Auth_Struct.PublicRSA, Auth_Struct.PrivateRSA);

            return JWT.Builder.JwtBuilder.Create()
                .AddHeader(JWT.Builder.HeaderName.Algorithm, "RS256")
                .AddHeader(JWT.Builder.HeaderName.KeyId, "WMS7EnkIGpcH9DGZsv2WcY9xsuFnZCtxZjj4Ahb-_8E")
                .AddHeader("t", "epic_id")
                .AddClaim("sub", Config.GetConfig().AccountId)
                .AddClaim("pfsid", Platform_Handler.PlatformHandler.SandboxId)
                .AddClaim("iss", "https://api.epicgames.dev/epic/oauth/v1")
                .AddClaim("dn", Config.GetConfig().UserName)
                .AddClaim("nonce", Convert.ToBase64String(RandomNumberGenerator.GetBytes(32)))
                .AddClaim("pfpid", Platform_Handler.PlatformHandler.ProductId)
                .AddClaim("aud", Helpers.ToString(Platform_Handler.PlatformHandler.ClientCredentials.ClientId))
                .AddClaim("pfdid", Platform_Handler.PlatformHandler.DeploymentId)
                .AddClaim("t", "epic_id")
                .AddClaim("appid", Config.GetConfig().AppId)
                .AddClaim("exp", TimeHelper.GetEpochTime(now.AddSeconds(7200)))
                .AddClaim("iat", TimeHelper.GetEpochTime(now))
                .AddClaim("jti", EpicAccountId.Generate())
                .WithAlgorithm(rS256Algorithm)
                .Encode();
        }


    }
}
