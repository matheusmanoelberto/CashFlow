using CashFlow.Domain.Enums;

namespace CashFlow.Domain.Expensions;

public static class PaymentTypeExtensions
{
    public static string PaymentTypeToString(this PaymentType paymentType)
    {
        return paymentType switch
        {
            PaymentType.Cash => "Dinheiro",
            PaymentType.CreditCart => "Cart�o de Cr�dito",
            PaymentType.DebitCard => "Cart�o de D�bito",
            PaymentType.EletronicTransfer => "Transferencia bancaria",
            _ => string.Empty
        };
    }
}