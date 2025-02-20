using CashFlow.Comunnication.Requests;
using CashFlow.Comunnication.Responses;

namespace CashFlow.Application.UserCases.Login.DoLogin
{
    public interface IDoLoginUseCase
    {
        Task<ResponseRegisteredUserJson> Execute(RequestLoginJson request);
    }
}
