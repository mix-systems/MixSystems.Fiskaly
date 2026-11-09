using MixSystems.Fiskaly.SignDE.Common;

namespace MixSystems.Fiskaly.SignDE.Transactions.Enums;

public static class PaymentTypeExtensions
{
    public static string ToApiString(this PaymentType paymentType) =>
        EnumApiValueProvider.GetApiName(paymentType);
}
