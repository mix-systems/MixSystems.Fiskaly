using System.Text.Json.Serialization;
using MixSystems.Fiskaly.SignDE.Common;

namespace MixSystems.Fiskaly.SignDE.Tss.Requests;

public class CreateTssRequest
{
    [JsonPropertyName("metadata")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public MetadataCollection? Metadata { get; init; }
}
