using CashFlow.Comunnication.Responses;

namespace CashFlow.Application.UserCases.Expenses.GetAll;

public interface IGetAllExpenseUseCase
{
    Task<ResponseExpensesJson> Execute();
}
