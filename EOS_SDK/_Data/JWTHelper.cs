using EOS_SDK.Others;
using System.Security.Cryptography;

namespace EOS_SDK._Data;

public static class JWTHelper
{
    public static void RSA_Config()
    {
        if (!string.IsNullOrWhiteSpace(EOS_Main.GetConfig().RSA_Private) && !string.IsNullOrWhiteSpace(EOS_Main.GetConfig().RSA_Public))
            return;
        RSA PrivateRSA = RSA.Create();
        if (!string.IsNullOrWhiteSpace(EOS_Main.GetConfig().RSA_Private))
        {
            PrivateRSA.ImportRSAPrivateKey(Convert.FromHexString(EOS_Main.GetConfig().RSA_Private), out _);
        }
        RSA PublicRSA = RSA.Create();
        if (!string.IsNullOrWhiteSpace(EOS_Main.GetConfig().RSA_Public))
        {
            PublicRSA.ImportRSAPublicKey(Convert.FromHexString(EOS_Main.GetConfig().RSA_Public), out _);
        }
        else
        {
            PublicRSA.ImportRSAPublicKey(PrivateRSA.ExportRSAPublicKey(), out _);
        }
        EOS_Main.GetConfig().RSA_Public = Convert.ToHexString(PrivateRSA.ExportRSAPublicKey());
        EOS_Main.GetConfig().RSA_Private = Convert.ToHexString(PrivateRSA.ExportRSAPrivateKey());
        _log.Logger.WriteInfo("RSA: Private RSA (HEX): " + EOS_Main.GetConfig().RSA_Private + " | Public RSA (HEX): " + EOS_Main.GetConfig().RSA_Public);

    }

    public static (RSA PublicRSA, RSA PrivateRSA) GetRSAPair()
    {
        RSA PrivateRSA = RSA.Create();
        RSA PublicRSA = RSA.Create();
        PrivateRSA.ImportRSAPrivateKey(Convert.FromHexString(EOS_Main.GetConfig().RSA_Private), out _);
        PublicRSA.ImportRSAPublicKey(Convert.FromHexString(EOS_Main.GetConfig().RSA_Public), out _);
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
        public string sub;  //Product User ID of the authenticated user.
        public string pfsid; //EOS Sandbox ID.
        public string iss; //Token issuer. Always starts with https://api.epicgames.dev.
        public string dn; //UserName/DisplayName
        public string nonce; //nonce
        public string pfpid; //EOS Product ID.
        public string aud; //Client ID used to authenticate the user with EOS Connect.
        public string pfdid; //EOS Deployment ID.
        public string t; //type of login, epic_id always
        public string appid; //appid
        public string exp; //Expiration time of the token, seconds since the epoch.
        public string iat; //Issue time of the token, seconds since the epoc.
        public string jti; //jti random id
    }
}
