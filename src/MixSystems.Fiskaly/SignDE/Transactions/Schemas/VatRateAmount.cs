using System.Text.Json.Serialization;
using MixSystems.Fiskaly.SignDE.Common;
using MixSystems.Fiskaly.SignDE.Transactions.Enums;
using MixSystems.Fiskaly.SignDE.Transactions.ValueObjects;

namespace MixSystems.Fiskaly.SignDE.Transactions.Schemas;

public class VatRateAmount
{
    [JsonPropertyName("vat_rate")]
    public VatRate VatRate { get; init; }
    [JsonPropertyName("amount")]
    public MoneyAmount Amount { get; init; } = MoneyAmount.Zero(CurrencyCode.EUR);
}
