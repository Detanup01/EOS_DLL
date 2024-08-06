using System.Text.Json.Serialization;

namespace EOS_SDK._Data;

[JsonSourceGenerationOptions(WriteIndented = true)]
[JsonSerializable(typeof(Config))]
[JsonSerializable(typeof(Models.Achievement_Model))]
internal partial class SourceGenerationContext : JsonSerializerContext
{
}