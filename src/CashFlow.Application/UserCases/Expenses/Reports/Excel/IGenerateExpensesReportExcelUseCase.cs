
namespace CashFlow.Application.UserCases.Expenses.Reports.Excel;
public interface IGenerateExpensesReportExcelUseCase
{
    Task<byte[]> Execute(DateOnly month);

}