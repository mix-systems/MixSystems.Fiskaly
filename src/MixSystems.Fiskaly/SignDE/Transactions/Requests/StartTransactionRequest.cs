using System.Diagnostics.CodeAnalysis;
using MixSystems.Fiskaly.SignDE.Transactions.Enums;

namespace MixSystems.Fiskaly.SignDE.Transactions.Requests;

public class StartTransactionRequest : TxRequest
{
    [SetsRequiredMembers]
    public StartTransactionRequest()
    {
        State = TxState.Active;
    }
}
