using CashFlow.Comunnication.Requests;
using CashFlow.Comunnication.Responses;

namespace CashFlow.Application.UserCases.Expenses.Register;

public interface IRegisterExpenseUseCase
{
  Task<ResponseRegisteredExpensejson> Execute(RequestRegisterExpenseJson request);
}
