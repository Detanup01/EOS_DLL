using EOS_SDK._Data.Models;
using EOS_SDK.JWT;
using System.Text.Json.Serialization;

namespace EOS_SDK._Data;

[JsonSourceGenerationOptions(WriteIndented = true, DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
[JsonSerializable(typeof(Config))]
[JsonSerializable(typeof(Achievement_Model))]
[JsonSerializable(typeof(List<Achievement_Model>))]
[JsonSerializable(typeof(Dictionary<string, List<Achievement_Model>>))]
[JsonSerializable(typeof(JWTToken))]
internal partial class SourceGenerationContext : JsonSerializerContext
{
}