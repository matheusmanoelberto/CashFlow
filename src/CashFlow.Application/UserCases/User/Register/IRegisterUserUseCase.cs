using CashFlow.Comunnication.Requests;
using CashFlow.Comunnication.Responses;

namespace CashFlow.Application.UserCases.User.Register;

public interface IRegisterUserUseCase
{
    Task<ResponseRegisteredUserJson> Execute(RequestRegisterUserJson resquest);
}