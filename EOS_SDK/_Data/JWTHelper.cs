using System.Security.Cryptography;
using EOS_SDK.JWT;
using EOS_SDK.Others;
using LitJWT.Algorithms;

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
        RS256Algorithm rs256Algorithm = new( ()=>pair.PublicRSA, () => pair.PrivateRSA);
        JwtHeader jwtHeader = new JwtHeader("RS256");
        jwtHeader.OtherHeaders.Add("kid", "WMS7EnkIGpcH9DGZsv2WcY9xsuFnZCtxZjj4Ahb-_8E");
        jwtHeader.OtherHeaders.Add("t", "epic_id");
        var writer = new JwtWriter(rs256Algorithm);
        var jwt_token = new JWT.JWTToken()
        {
            t = "epic_id",
            sub = EOS_Main.GetConfig().AccountId,
            pfsid = EOS_Main.GetPlatform().SandboxId,
            iss = "https://api.epicgames.dev/epic/oauth/v1",
            dn = EOS_Main.GetConfig().UserName,
            nonce = Convert.ToBase64String(RandomNumberGenerator.GetBytes(32)),
            pfpid = EOS_Main.GetPlatform().ProductId,
            appid = EOS_Main.GetConfig().AppId,
            aud = Helpers.ToString(EOS_Main.GetPlatform().ClientCredentials.ClientId),
            pfdid = EOS_Main.GetPlatform().DeploymentId,
            exp = TimeHelper.GetEpochTime(now.AddSeconds(7200)).ToString(),
            iat = TimeHelper.GetEpochTime(now).ToString(),
            jti = EpicAccountId.Generate(),
            scope = "basic_profile friends_list openid presence",
            sec = 1,

        };
        var auth_Token = writer.WriteWithHeader(jwt_token, jwtHeader);
        jwt_token.nonce = null;
        jwt_token.exp = TimeHelper.GetEpochTime(now.AddSeconds(7200)).ToString();
        jwt_token.iat = TimeHelper.GetEpochTime(now).ToString();
        var refresh_Token = writer.WriteWithHeader(jwt_token, jwtHeader);

        return (auth_Token, refresh_Token, now);
    }

    public static string CreateToken(bool GenerateNonce = false)
    {
        var now = DateTime.UtcNow;
        var pair = GetRSAPair();
        RS256Algorithm rs256Algorithm = new(() => pair.PublicRSA, () => pair.PrivateRSA);
        JwtHeader jwtHeader = new JwtHeader("RS256");
        jwtHeader.OtherHeaders.Add("kid", "WMS7EnkIGpcH9DGZsv2WcY9xsuFnZCtxZjj4Ahb-_8E");
        jwtHeader.OtherHeaders.Add("t", "epic_id");
        var writer = new JwtWriter(rs256Algorithm);
        var jwt_token = new JWT.JWTToken()
        {
            t = "epic_id",
            sub = EOS_Main.GetConfig().AccountId,
            pfsid = EOS_Main.GetPlatform().SandboxId,
            iss = "https://api.epicgames.dev/epic/oauth/v1",
            dn = EOS_Main.GetConfig().UserName,
            pfpid = EOS_Main.GetPlatform().ProductId,
            appid = EOS_Main.GetConfig().AppId,
            aud = Helpers.ToString(EOS_Main.GetPlatform().ClientCredentials.ClientId),
            pfdid = EOS_Main.GetPlatform().DeploymentId,
            exp = TimeHelper.GetEpochTime(now.AddSeconds(7200)).ToString(),
            iat = TimeHelper.GetEpochTime(now).ToString(),
            jti = EpicAccountId.Generate(),
        };
        if (GenerateNonce)
            jwt_token.nonce = Convert.ToBase64String(RandomNumberGenerator.GetBytes(32));
        return writer.WriteWithHeader(jwt_token, jwtHeader);
    }

    public static JWTToken GetToken(string jwt)
    {
        var pair = GetRSAPair();
        RS256Algorithm rs256Algorithm = new(() => pair.PublicRSA, () => pair.PrivateRSA);
        JwtReader reader = new JwtReader(rs256Algorithm);
        if (!reader.Read(jwt, out _, out JWTToken token))
            return new();
        return token;
    }
}
