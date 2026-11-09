using System.Text.Json.Serialization;
using MixSystems.Fiskaly.Common.Enums;

namespace MixSystems.Fiskaly.Management.Organizations.Requests;

public sealed class EnableOrganizationEnvironmentRequest
{
    [JsonPropertyName("env")]
    public required Env Env { get; init; }
}
