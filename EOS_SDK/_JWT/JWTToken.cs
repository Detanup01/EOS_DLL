namespace EOS_SDK.JWT;

public struct JWTToken
{
    public string sub { get; set; }  //Product User ID of the authenticated user.
    public string pfsid { get; set; } //EOS Sandbox ID.
    public string iss { get; set; } //Token issuer. Always starts with https://api.epicgames.dev.
    public string dn { get; set; } //UserName/DisplayName
    public string? nonce { get; set; } //nonce
    public string pfpid { get; set; } //EOS Product ID.
    public string aud { get; set; } //Client ID used to authenticate the user with EOS Connect.
    public string pfdid { get; set; } //EOS Deployment ID.
    public string t { get; set; } //type of login, epic_id always
    public string appid { get; set; } //appid
    public string exp { get; set; } //Expiration time of the token, seconds since the epoch.
    public string iat { get; set; } //Issue time of the token, seconds since the epoc.
    public string jti { get; set; } //jti random id

    public int? sec { get; set; } //sec
    public string? scope { get; set; } //scope

    public override string ToString()
    {
        return $"sub: {sub}\npfsid: {pfsid}\niss: {iss}\ndn: {dn}\nnonce: {nonce}\npfpid: {pfpid}\naud: {aud}\npfdid: {pfdid}\nt: {t}\nappid: {appid}\nexp: {exp}\niat: {iat}\njti {jti}";
    }
}
