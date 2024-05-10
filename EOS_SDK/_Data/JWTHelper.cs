using EOS_SDK.Others;
using System.Security.Cryptography;
using System.Text;

namespace EOS_SDK._Data
{
    public static class JWTHelper
    {
        public static void RSA_Config()
        {
            if (!string.IsNullOrWhiteSpace(EOS_Main.GetConfig().RSA_Private) && !string.IsNullOrWhiteSpace(EOS_Main.GetConfig().RSA_Public))
                return;
            RSA PrivateRSA = RSA.Create();
            if (!string.IsNullOrWhiteSpace(EOS_Main.GetConfig().RSA_Private))
            {
                PrivateRSA.FromXmlString(EOS_Main.GetConfig().RSA_Private);
            }
            RSA PublicRSA = RSA.Create();
            if (!string.IsNullOrWhiteSpace(EOS_Main.GetConfig().RSA_Public))
            {
                PublicRSA.FromXmlString(EOS_Main.GetConfig().RSA_Public);
            }
            else
            {
                PublicRSA.FromXmlString(PrivateRSA.ToXmlString(false));
            }
            EOS_Main.GetConfig().RSA_Public = PrivateRSA.ToXmlString(false);
            EOS_Main.GetConfig().RSA_Private = PrivateRSA.ToXmlString(true);
            _log.Logger.WriteInfo("RSA: Private XML (base64): " + Convert.ToBase64String(Encoding.UTF8.GetBytes(PrivateRSA.ToXmlString(true))) + " | Public XML (base64): " + Convert.ToBase64String(Encoding.UTF8.GetBytes(PublicRSA.ToXmlString(false))));

        }

        public static (RSA PublicRSA, RSA PrivateRSA) GetRSAPair()
        {
            RSA PrivateRSA = RSA.Create();
            RSA PublicRSA = RSA.Create();
            PrivateRSA.FromXmlString(EOS_Main.GetConfig().RSA_Private);
            PublicRSA.FromXmlString(EOS_Main.GetConfig().RSA_Public);
            return (PublicRSA, PrivateRSA);
        }

        public static (string Auth, string Refresh, DateTime now) CreateAuthRefresh()
        {
            var now = DateTime.UtcNow;
            var pair = GetRSAPair();
            JWT.Algorithms.RS256Algorithm rS256Algorithm = new(pair.PublicRSA, pair.PrivateRSA);

            var auth_Token = JWT.Builder.JwtBuilder.Create()
                .AddHeader(JWT.Builder.HeaderName.Algorithm, "RS256")
                .AddHeader(JWT.Builder.HeaderName.KeyId, "WMS7EnkIGpcH9DGZsv2WcY9xsuFnZCtxZjj4Ahb-_8E")
                .AddHeader("t", "epic_id")
                .AddClaim("sub", EOS_Main.GetConfig().AccountId)
                .AddClaim("pfsid", EOS_Main.GetPlatform().SandboxId)
                .AddClaim("iss", "https://api.epicgames.dev/epic/oauth/v1")
                .AddClaim("dn", EOS_Main.GetConfig().UserName)
                .AddClaim("nonce", Convert.ToBase64String(RandomNumberGenerator.GetBytes(32)))
                .AddClaim("pfpid", EOS_Main.GetPlatform().ProductId)
                .AddClaim("sec", 1)
                .AddClaim("aud", Helpers.ToString(EOS_Main.GetPlatform().ClientCredentials.ClientId))
                .AddClaim("pfdid", EOS_Main.GetPlatform().DeploymentId)
                .AddClaim("t", "epic_id")
                .AddClaim("scope", "basic_profile friends_list openid presence")
                .AddClaim("appid", EOS_Main.GetConfig().AppId)
                .AddClaim("exp", TimeHelper.GetEpochTime(now.AddSeconds(7200)))
                .AddClaim("iat", TimeHelper.GetEpochTime(now))
                .AddClaim("jti", EpicAccountId.Generate())
                .WithAlgorithm(rS256Algorithm)
                .Encode();

            var refresh_Token = JWT.Builder.JwtBuilder.Create()
                .AddHeader(JWT.Builder.HeaderName.Algorithm, "RS256")
                .AddHeader(JWT.Builder.HeaderName.KeyId, "WMS7EnkIGpcH9DGZsv2WcY9xsuFnZCtxZjj4Ahb-_8E")
                .AddHeader("t", "epic_id")
                .AddClaim("sub", EOS_Main.GetConfig().AccountId)
                .AddClaim("pfsid", EOS_Main.GetPlatform().SandboxId)
                .AddClaim("iss", "https://api.epicgames.dev/epic/oauth/v1")
                .AddClaim("dn", EOS_Main.GetConfig().UserName)
                .AddClaim("pfpid", EOS_Main.GetPlatform().ProductId)
                .AddClaim("aud", Helpers.ToString(EOS_Main.GetPlatform().ClientCredentials.ClientId))
                .AddClaim("pfdid", EOS_Main.GetPlatform().DeploymentId)
                .AddClaim("t", "epic_id")
                .AddClaim("appid", EOS_Main.GetConfig().AppId)
                .AddClaim("scope", "basic_profile friends_list openid presence")
                .AddClaim("exp", TimeHelper.GetEpochTime(now.AddSeconds(28800)))
                .AddClaim("iat", TimeHelper.GetEpochTime(now))
                .AddClaim("jti", EpicAccountId.Generate())
                .WithAlgorithm(rS256Algorithm)
                .Encode();

            return (auth_Token, refresh_Token, now);
        }

        public static string CreateToken(bool GenerateNonce = false)
        {
            var now = DateTime.UtcNow;
            var pair = GetRSAPair();
            JWT.Algorithms.RS256Algorithm rS256Algorithm = new(pair.PublicRSA, pair.PrivateRSA);

            var creater = JWT.Builder.JwtBuilder.Create()
                .AddHeader(JWT.Builder.HeaderName.Algorithm, "RS256")
                .AddHeader(JWT.Builder.HeaderName.KeyId, "WMS7EnkIGpcH9DGZsv2WcY9xsuFnZCtxZjj4Ahb-_8E")
                .AddHeader("t", "epic_id")
                .AddClaim("sub", EOS_Main.GetConfig().AccountId)
                .AddClaim("pfsid", EOS_Main.GetPlatform().SandboxId)
                .AddClaim("iss", "https://api.epicgames.dev/epic/oauth/v1")
                .AddClaim("dn", EOS_Main.GetConfig().UserName)
                .AddClaim("pfpid", EOS_Main.GetPlatform().ProductId)
                .AddClaim("aud", Helpers.ToString(EOS_Main.GetPlatform().ClientCredentials.ClientId))
                .AddClaim("pfdid", EOS_Main.GetPlatform().DeploymentId)
                .AddClaim("t", "epic_id")
                .AddClaim("appid", EOS_Main.GetConfig().AppId)
                .AddClaim("exp", TimeHelper.GetEpochTime(now.AddSeconds(7200)))
                .AddClaim("iat", TimeHelper.GetEpochTime(now))
                .AddClaim("jti", EpicAccountId.Generate());

            if (GenerateNonce)
                creater.AddClaim("nonce", Convert.ToBase64String(RandomNumberGenerator.GetBytes(32)));

            return creater.WithAlgorithm(rS256Algorithm)
                .Encode();
        }

        public static JWTToken GetToken(string jwt)
        {
            return JWT.Builder.JwtBuilder.Create().Decode<JWTToken>(jwt);
        }

        public struct JWTToken
        {
            public string sub;  //AccountId
            public string pfsid; //sandboxId
            public string iss; //ISS
            public string dn; //UserName/DisplayName
            public string nonce; //nonce
            public string pfpid; //productId
            public string aud; //clientId
            public string pfdid; //deplaymentid
            public string t; //type of login, epic_id always
            public string appid; //appid
            public string exp; //exp
            public string iat; //iat
            public string jti; //jti random id
        }
    }
}
