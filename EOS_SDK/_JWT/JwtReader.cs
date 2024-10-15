using EOS_SDK._Data;
using LitJWT;
using System.Text.Json;

namespace EOS_SDK.JWT;

public class JwtReader
{
    private readonly JwtAlgorithmResolver resolver;

    private readonly JsonSerializerOptions serializerOptions;

    public JwtReader(params IJwtAlgorithm[] algorithms)
        : this(new JwtAlgorithmResolver(algorithms))
    {
    }

    public JwtReader(IJwtAlgorithm[] algorithms, JsonSerializerOptions serializerOptions)
        : this(new JwtAlgorithmResolver(algorithms), serializerOptions)
    {
    }

    public JwtReader(JwtAlgorithmResolver resolver)
        : this(resolver, JWTJsonConst.JWT_JsonOptions)
    {
        
    }

    public JwtReader(JwtAlgorithmResolver resolver, JsonSerializerOptions serializerOptions)
    {
        this.resolver = resolver;
        this.serializerOptions = serializerOptions;
    }

    public bool Read<T>(string jwt, out JwtHeader jwtHeader, out T? value)
    {
        SplitSegments(jwt, out string header, out string payload, out string signature, out string headerPayload);
        jwtHeader = new();
        jwtHeader.Read(Convert.FromBase64String(header + "=="));
        value = (T?)JsonSerializer.Deserialize(Convert.FromBase64String(payload), typeof(T), SourceGenerationContext.Default);
        return true;
    }

    private void SplitSegments(string jwt, out string header, out string payload, out string signature, out string headerAndPayload)
    {
        header = string.Empty;
        payload = string.Empty;
        signature = string.Empty;
        headerAndPayload = string.Empty;
        var jwt_span = jwt.ToCharArray().AsSpan();
        bool flag = false;
        for (int i = 0; i < jwt.Length; i++)
        {
            if (jwt[i] == '.')
            {
                if (flag)
                {
                    int num = header.Length + 1;
                    payload = jwt_span.Slice(num, i - num).ToString();
                    headerAndPayload = jwt_span.Slice(0, num + i - num).ToString();
                    signature = jwt_span.Slice(i + 1, jwt.Length - (i + 1)).ToString();
                    break;
                }

                header = jwt_span.Slice(0, i).ToString();
                flag = true;
            }
        }
    }
}
