

using ClosedXML.Excel;

namespace CashFlow.Application.UserCases.Expenses.Reports.Excel;
public class GenerateExpensesRepostExceluseCase : IGenerateExpensesRepostExceluseCase
{
    public Task<byte[]> Execute(DateOnly month)
    {
       var workbook = new XLWorkbook();

        workbook.Author = "Mtaheus Manoel";
        workbook.Style.Font.FontSize = 12;
        workbook.Style.Font.FontName = "Times New Roman";

        var worksheet = workbook.Worksheets.Add(month.ToString("Y"));
    }
}