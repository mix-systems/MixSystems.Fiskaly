using System.Text.Json.Serialization;

namespace MixSystems.Fiskaly.Common.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum DataEncoding
{
    [JsonStringEnumMemberName("UTF-8")]
    Utf8
}
