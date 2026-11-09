using System.Text.Json.Serialization;
using MixSystems.Fiskaly.SignDE.Admin.ValueObjects;

namespace MixSystems.Fiskaly.SignDE.Admin.Requests;

public sealed class AdminAuthenticationRequest
{
    [JsonPropertyName("admin_pin")]
    public required AdminPin AdminPin { get; init; }
}
