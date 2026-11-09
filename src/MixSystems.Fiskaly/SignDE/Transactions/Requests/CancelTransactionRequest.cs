using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using MixSystems.Fiskaly.SignDE.Transactions.Enums;
using MixSystems.Fiskaly.SignDE.Transactions.Schemas;

namespace MixSystems.Fiskaly.SignDE.Transactions.Requests;

public sealed class CancelTransactionRequest : TxRequest
{
    [SetsRequiredMembers]
    public CancelTransactionRequest()
    {
        State = TxState.Cancelled;
    }
    [JsonPropertyName("schema")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public TransactionSchema? Schema { get; init; }
}
