using System.Text.Json.Serialization;

namespace MixSystems.Fiskaly.Management.Common.Responses;

public sealed class StatusResponse
{
    [JsonPropertyName("_success")]
    public bool Success { get; init; }
}
