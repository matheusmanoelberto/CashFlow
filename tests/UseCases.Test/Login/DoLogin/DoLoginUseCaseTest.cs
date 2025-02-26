using CashFlow.Application.UserCases.Login.DoLogin;
using CommonTestUtilities.Cryptography;
using CommonTestUtilities.Repositories;
using CommonTestUtilities.Requests;
using CommonTestUtilities.Token;
using FluentAssertions;

namespace UseCases.Test.Login.DoLogin;
public class DoLoginUseCaseTest
{
    [Fact]
    public async Task Success() 
    {
        var request = RequestLoginJsonBuild.Build();
        var useCase = CreateUseCase();

        var result = await useCase.Execute(request);

        result.Should().NotBeNull();
        result.Token.Should().NotBeNullOrWhiteSpace();
    }

    [Fact]
    public async Task Error_User_Not_Found() { }


    [Fact]
    public async Task Error_Password_Not_Match() { }

    private DoLoginUseCase CreateUseCase(CashFlow.Domain.Entities.User user)
    {
        var passwordEncripter = PasswordEncripterBuilder.Build();
        var tokenGenerator = JwtTokenGeneratorBuilder.Build();
        var readRepository = new UserReadOnlyRepositoryBuilder().GetUserByEmail(user).Build();

        return new DoLoginUseCase(readRepository, passwordEncripter, tokenGenerator);
     }

}