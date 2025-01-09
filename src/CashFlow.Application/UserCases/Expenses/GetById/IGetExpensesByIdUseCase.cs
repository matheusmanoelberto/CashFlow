
using CashFlow.Comunnication.Responses;

namespace CashFlow.Application.UserCases.Expenses.GetById;

public interface IGetExpensesByIdUseCase
{
    Task<ResponseExpenseJson> Execute(long id);
}
