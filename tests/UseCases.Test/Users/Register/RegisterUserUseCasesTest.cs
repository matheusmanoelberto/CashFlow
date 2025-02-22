using CashFlow.Application.UserCases.User.Register;
using CommonTestUtilities.Requests;
using FluentAssertions;

namespace UseCases.Test.Users.Register;

public class RegisterUserUseCasesTest
{
    [Fact]
    public async Task Success()
    {
        var request = RequestRegisterUserJsonBuilder.Build();
        var useCase = new CreateUseCase();

        var result = await useCase.Execute(request);
        
        result.Should().NotBeNull();
        result.Name.Should().Be(request.Name);
        result.Token.Should().NotBeNullOrWhiteSpace();
    }

    private RegisterUserUseCases CreateUseCase()
    {
        return new RegisterUserUseCase();
    }
}