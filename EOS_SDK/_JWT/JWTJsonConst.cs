using EOS_SDK._Data;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace EOS_SDK.JWT;

public static class JWTJsonConst
{

    public static JsonSerializerOptions JWT_JsonOptions = new(JsonSerializerDefaults.Web)
    {
        TypeInfoResolver = SourceGenerationContext.Default,
        WriteIndented = true,
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
        
    };

}
