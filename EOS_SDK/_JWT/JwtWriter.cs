using EOS_SDK._Data;
using LitJWT;
using System.Buffers;
using System.Text;
using System.Text.Json;

namespace EOS_SDK.JWT;

public class JwtWriter
{
    private JwtHeader header;

    private readonly IJwtAlgorithm signAlgorithm;
    public IJwtAlgorithm SignAlgorithm => signAlgorithm;
    private readonly JsonSerializerOptions serializerOptions;

    public JwtWriter(IJwtAlgorithm signAlgorithm)
    {
        this.signAlgorithm = signAlgorithm;
        serializerOptions = JWTJsonConst.JWT_JsonOptions;
        header = new(signAlgorithm.AlgName);
    }

    public JwtWriter(IJwtAlgorithm signAlgorithm, JsonSerializerOptions serializerOptions)
    {
        this.signAlgorithm = signAlgorithm;
        this.serializerOptions = serializerOptions;
        header = new(signAlgorithm.AlgName);
    }

    public string Write<T>(T value)
    {
        MemoryStream ms = new();
        ms.Write(header.Write());
        ms.Write(Encoding.UTF8.GetBytes("." + LitJWT.Base64.EncodeToBase64UrlString(JsonSerializer.SerializeToUtf8Bytes(value, typeof(T), SourceGenerationContext.Default))));
        var signatureArray = ArrayPool<byte>.Shared.Rent(signAlgorithm.HashSize);
        signAlgorithm.Sign(ms.GetBuffer()[..(int)(ms.Length-1)], signatureArray);
        var Verify = signAlgorithm.Verify(ms.GetBuffer()[..(int)(ms.Length - 1)], signatureArray);
        if (!Verify)
            return string.Empty;
        ms.Write(Encoding.UTF8.GetBytes("." + LitJWT.Base64.EncodeToBase64UrlString(signatureArray)));
        return Encoding.UTF8.GetString(ms.ToArray());
    }


    public string WriteWithHeader<T>(T value, JwtHeader jwtHeader)
    {
        header = jwtHeader;
        return Write(value);
    }
}
