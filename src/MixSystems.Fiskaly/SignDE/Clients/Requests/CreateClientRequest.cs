using System.Text.Json.Serialization;
using MixSystems.Fiskaly.SignDE.Common;
using MixSystems.Fiskaly.SignDE.Clients.ValueObjects;

namespace MixSystems.Fiskaly.SignDE.Clients.Requests;

public class CreateClientRequest
{
    [JsonPropertyName("serial_number")]
    public required ClientSerialNumber SerialNumber { get; init; }
    [JsonPropertyName("metadata")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public MetadataCollection? Metadata { get; init; }
}
