using System.Text.Json.Serialization;
using MixSystems.Fiskaly.SignDE.Clients.ValueObjects;
using MixSystems.Fiskaly.SignDE.Common;
using MixSystems.Fiskaly.SignDE.Transactions.Enums;

namespace MixSystems.Fiskaly.SignDE.Transactions.Requests;

public abstract class TxRequest
{
    private readonly ClientId _clientId;
    private readonly TxState _state;
    [JsonPropertyName("client_id")]
    public required ClientId ClientId
    {
        get => _clientId;
        init => _clientId = value;
    }
    [JsonPropertyName("state")]
    public required TxState State
    {
        get => _state;
        init => _state = value;
    }
    [JsonPropertyName("metadata")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public MetadataCollection? Metadata { get; init; }
}
