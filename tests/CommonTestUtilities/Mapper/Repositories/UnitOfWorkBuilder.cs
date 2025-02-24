using CashFlow.Domain.Repositories;
using Moq;

namespace CommonTestUtilities.Mapper.Repositories;
public class UnitOfWorkBuilder
{
    public static IUnitOfWork Build()
    {
        var mock = new Mock<IUnitOfWork>();

        return mock.Object;
    }
}