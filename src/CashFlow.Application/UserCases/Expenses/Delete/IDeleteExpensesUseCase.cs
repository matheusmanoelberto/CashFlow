namespace CashFlow.Application.UserCases.Expenses.Delete;

public interface IDeleteExpensesUseCase
{
    Task Execute(long id);
}