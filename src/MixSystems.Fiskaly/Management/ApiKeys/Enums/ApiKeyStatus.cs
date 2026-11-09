using System.Text.Json.Serialization;

namespace MixSystems.Fiskaly.Management.ApiKeys.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum ApiKeyStatus
{
    [JsonStringEnumMemberName("enabled")]
    Enabled,
    [JsonStringEnumMemberName("disabled")]
    Disabled
}
