
namespace CashFlow.Application.UserCases.Expenses.Reports.Excel;
public interface IGenerateExpensesRepostExceluseCase
{
    Task<byte[]> Execute(DateOnly month);

}