using System.Text.Json.Serialization;
using MixSystems.Fiskaly.Management.ApiKeys.Enums;
using MixSystems.Fiskaly.SignDE.Common;

namespace MixSystems.Fiskaly.Management.ApiKeys.Requests;

public sealed class UpdateApiKeyRequest
{
    [JsonPropertyName("status")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public ApiKeyStatus? Status { get; init; }

    [JsonPropertyName("metadata")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public MetadataCollection? Metadata { get; init; }
}
