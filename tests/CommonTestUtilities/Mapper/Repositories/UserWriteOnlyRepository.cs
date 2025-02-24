using CashFlow.Domain.Repositories.User;
using Moq;

namespace CommonTestUtilities.Mapper.Repositories;

public class UserWriteOnlyRepositoryBuilder
{
    public static IUserWriteOnlyRepository Build()
    {
        var mock = new Mock<IUserWriteOnlyRepository>();

        return mock.Object;
    }
}