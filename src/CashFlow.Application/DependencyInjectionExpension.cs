using CashFlow.Application.AutoMapper;
using CashFlow.Application.UserCases.Expenses.Delete;
using CashFlow.Application.UserCases.Expenses.GetAll;
using CashFlow.Application.UserCases.Expenses.GetById;
using CashFlow.Application.UserCases.Expenses.Register;
using CashFlow.Application.UserCases.Expenses.Reports.Excel;
using CashFlow.Application.UserCases.Expenses.Reports.Pdf;
using CashFlow.Application.UserCases.Expenses.Update;
using CashFlow.Application.UserCases.User.Register;
using Microsoft.Extensions.DependencyInjection;

namespace CashFlow.Application;

public static class DependencyInjectionExpension
{
    public static void AddApplication(this IServiceCollection services)
    {
        AddAutoMapper(services);
        AddUseCases(services);
    }

    private static void AddAutoMapper(IServiceCollection services)
    {
        services.AddAutoMapper(typeof(AutoMapping));

    }
    private static void AddUseCases(IServiceCollection services)
    {
        services.AddScoped<IRegisterExpenseUseCase, RegisterExpenseUseCase>();
        services.AddScoped<IGetAllExpenseUseCase, GetAllExpenseUseCase>();
        services.AddScoped<IGetExpensesByIdUseCase, GetExpensesByIdUseCase>();
        services.AddScoped<IDeleteExpensesUseCase, DeleteExpensesUseCase>();
        services.AddScoped<IUpdateExpensesUseCase, UpdateExpensesUseCase>();
        services.AddScoped<IGenerateExpensesReportExcelUseCase, GenerateExpensesReportExcelUseCase>();
        services.AddScoped<IGenerateExpensesReportPdfUseCase, GenerateExpensesReportPdfUseCase>();
        services.AddKeyedScoped<IRegisterUserUseCase>, RegisterUserUseCase();

    }
}
