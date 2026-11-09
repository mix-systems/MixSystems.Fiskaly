using System.Text.Json.Serialization;

namespace MixSystems.Fiskaly.SignDE.Transactions.Schemas;

public class Other : StandardV1SchemaPayload
{
    [JsonExtensionData]
    public Dictionary<string, object>? AdditionalData { get; init; }
}
