using MixSystems.Fiskaly.SignDE.Common;

namespace MixSystems.Fiskaly.SignDE.Transactions.Enums;

public static class ReceiptTypeExtensions
{
    public static string ToApiString(this ReceiptType receiptType) =>
        EnumApiValueProvider.GetApiName(receiptType);
}
