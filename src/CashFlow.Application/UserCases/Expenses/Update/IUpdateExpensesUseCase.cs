using CashFlow.Comunnication.Requests;

namespace CashFlow.Application.UserCases.Expenses.Update;

public interface IUpdateExpensesUseCase
{
    Task Execute(long id, RequestExpenseJson request);
}
