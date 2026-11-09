using System.Text.Json.Serialization;
using MixSystems.Fiskaly.SignDE.Tss.ValueObjects;

namespace MixSystems.Fiskaly.SignDE.Admin.Responses;

public class AdminAuthenticationResponse
{
    [JsonIgnore]
    public TssId TssId { get; init; }
}
