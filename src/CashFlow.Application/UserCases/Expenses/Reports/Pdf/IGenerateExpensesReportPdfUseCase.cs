namespace CashFlow.Application.UserCases.Expenses.Reports.Pdf;

public interface IGenerateExpensesReportPdfUseCase
{
    Task<byte[]> Execute(DateOnly month);
}