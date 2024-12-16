using CashFlow.Comunnication.Enums;
using CashFlow.Comunnication.Requests;
using CashFlow.Comunnication.Responses;

namespace CashFlow.Application_.UserCases.Expenses.Register;

public class RegisterExpenseUseCase
{
    public ResponseRegisteredExpensejson Execute(RequestRegisterExpenseJson request)
    {
        Validate(request);

        return new ResponseRegisteredExpensejson();
    }

    private void Validate(RequestRegisterExpenseJson request)
    {
        var titleIsEmpty = string.IsNullOrWhiteSpace(request.Title);
        if(titleIsEmpty)
        {
            throw new ArgumentException("The title is required.");
        }

        if(request.Amount <= 0)
        {
            throw new ArgumentException("The amount must be greater than zero.");
        }

        var result = DateTime.Compare(request.Date, DateTime.UtcNow);
        if (result > 0)
        {
            throw new ArgumentException("Expenses cannot be for the future.");
        }

        var paymentTypeIsValid = Enum.IsDefined(typeof(PaymentType), request.PaymentType);
        if (paymentTypeIsValid ==  false) {
            throw new ArgumentException(" Payment Type is not valid.");
        }
    }
}
