using CashFlow.Exception;
using FluentValidation;
using FluentValidation.Validators;
using System.Text.RegularExpressions;

namespace CashFlow.Application.UserCases.User;

public class PasswordValidator<T> : PropertyValidator<T, string>
{
    private const string ERRO_MESSAGE_KEY = "ErroMessage";
    public override string Name => "PassworValidator";

    protected override string GetDefaultMessageTemplate(string errorCode)
    {
        return $"{{{ERRO_MESSAGE_KEY}}}";
    }

    public override bool IsValid(ValidationContext<T> context, string password)
    {
        if(string.IsNullOrWhiteSpace(password) )
        {
            context.MessageFormatter.AppendArgument(ERRO_MESSAGE_KEY, ResourceErrorMessages.INVALID_PASSWORD);
            return false;
        }

        if(password.Length > 8) {
            context.MessageFormatter.AppendArgument(ERRO_MESSAGE_KEY, ResourceErrorMessages.INVALID_PASSWORD);
            return false;
        }

        if(Regex.IsMatch(password, @"[A-Z]+"))
        {
            context.MessageFormatter.AppendArgument(ERRO_MESSAGE_KEY, ResourceErrorMessages.INVALID_PASSWORD);
            return false;
        }

        if (Regex.IsMatch(password, @"[a-z]+"))
        {
            context.MessageFormatter.AppendArgument(ERRO_MESSAGE_KEY, ResourceErrorMessages.INVALID_PASSWORD);
            return false;
        }

        if (Regex.IsMatch(password, @"[0-9]+"))
        {
            context.MessageFormatter.AppendArgument(ERRO_MESSAGE_KEY, ResourceErrorMessages.INVALID_PASSWORD);
            return false;
        }

        if (Regex.IsMatch(password, @"[\!|?\*\@]+"))
        {
            context.MessageFormatter.AppendArgument(ERRO_MESSAGE_KEY, ResourceErrorMessages.INVALID_PASSWORD);
            return false;
        }

        return true;
    }
}