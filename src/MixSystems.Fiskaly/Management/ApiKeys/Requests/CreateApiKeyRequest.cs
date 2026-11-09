using System.Text.Json.Serialization;
using MixSystems.Fiskaly.Authentication.ValueObjects;
using MixSystems.Fiskaly.Management.ApiKeys.Enums;
using MixSystems.Fiskaly.SignDE.Common;

namespace MixSystems.Fiskaly.Management.ApiKeys.Requests;

public sealed class CreateApiKeyRequest
{
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    [JsonPropertyName("status")]
    public ApiKeyStatus Status { get; init; } = ApiKeyStatus.Enabled;

    [JsonPropertyName("metadata")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public MetadataCollection? Metadata { get; init; }

    [JsonPropertyName("managed_by_organization_id")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public OrganizationId? ManagedByOrganizationId { get; init; }
}
