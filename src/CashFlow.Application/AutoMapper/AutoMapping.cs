using AutoMapper;
using CashFlow.Comunnication.Requests;
using CashFlow.Comunnication.Responses;
using CashFlow.Domain.Entities;

namespace CashFlow.Application.AutoMapper;

public class AutoMapping : Profile
{
    public AutoMapping()
    {
        RequestToEntity();
        EntityToResponse();
    }

    private void RequestToEntity()
    {
        CreateMap<RequestExpenseJson, Expense>();
        CreateMap<RequestRegisterUserJson, User>();
    }

    private void EntityToResponse()
    {
        CreateMap<Expense, ResponseRegisteredExpensejson>();
        CreateMap<Expense, ResponseShortExpenseJson>();
        CreateMap<Expense, ResponseRegisteredExpensejson>();
        CreateMap<Expense, ResponseExpenseJson>();
    }
}