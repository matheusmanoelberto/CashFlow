using FluentValidation;
using FluentValidation.Validators;

namespace CashFlow.Application.UserCases.User;

public class PasswordValidator<T> : PropertyValidator<T, string>
{
    public override string Name => "PassworValidator";

    public override bool IsValid(ValidationContext<T> context, string password)
    {
        throw new NotImplementedException();
    }
}