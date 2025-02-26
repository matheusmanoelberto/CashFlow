using Bogus;
using CashFlow.Comunnication.Requests;

namespace CommonTestUtilities.Requests;

public class RequestLoginJsonBuild
{
    public static RequestLoginJson Build()
    {
        return new Faker<RequestLoginJson>()
            .RuleFor(user => user.Email, faker => faker.Internet.Email())
            .RuleFor(user => user.Password, faker => faker.Internet.Password(prefix: "!Aa1"));
    }
}
