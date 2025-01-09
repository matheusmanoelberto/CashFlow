﻿using CashFlow.Application.AutoMapper;
using CashFlow.Application.UserCases.Expenses.Delete;
using CashFlow.Application.UserCases.Expenses.GetAll;
using CashFlow.Application.UserCases.Expenses.GetById;
using CashFlow.Application.UserCases.Expenses.Register;
using CashFlow.Application.UserCases.Expenses.Update;
using Microsoft.Extensions.DependencyInjection;

namespace CashFlow.Application;

public static class DependencyInjectionExpension
{
    public static void AddApplication(this IServiceCollection  services)
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

    }
}
