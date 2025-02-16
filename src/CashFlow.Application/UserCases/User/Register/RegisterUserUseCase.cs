using AutoMapper;
using CashFlow.Comunnication.Requests;
using CashFlow.Comunnication.Responses;

namespace CashFlow.Application.UserCases.User.Register
{
    public class RegisterUserUseCase : IRegisterUserUseCase
    {
        private readonly IMapper _mapper;

        public RegisterUserUseCase(IMapper mapper)
        {
            _mapper = mapper;
        }

        public async Task<ResponseRegisteredUserJson> Execute(RequestRegisterUserJson resquest)
        {

        }

        private void Validate(RequestRegisterUserJson request)
        {
            var result = new RegisterUserValidator(request);

        }
    }
}