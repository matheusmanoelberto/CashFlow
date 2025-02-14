using CashFlow.Domain.Enums;

namespace CashFlow.Domain.Expensions;

public static class PaymentTypeExtensions
{
    public static string PaymentTypeToString(this PaymentType paymentType)
    {
        return paymentType switch
        {
            PaymentType.Cash => "Dinheiro",
            PaymentType.CreditCart => "Cartão de Crédito",
            PaymentType.DebitCard => "Cartào de Débito",
            PaymentType.EletronicTransfer => "Transferencia bancaria",
            _ => string.Empty
        };
    }
}