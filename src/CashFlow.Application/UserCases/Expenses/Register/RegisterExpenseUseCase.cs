﻿using CashFlow.Comunnication.Enums;
using CashFlow.Comunnication.Requests;
using CashFlow.Comunnication.Responses;
using CashFlow.Exception.ExceptionsBase;

namespace CashFlow.Application.UserCases.Expenses.Register;

public class RegisterExpenseUseCase
{
    public ResponseRegisteredExpensejson Execute(RequestRegisterExpenseJson request)
    {
        Validate(request);

        return new ResponseRegisteredExpensejson();
    }

    private void Validate(RequestRegisterExpenseJson request)
    {

        var validator = new RegisterExpenseValidator();

        var result = validator.Validate(request);

        if (result.IsValid == false) {

            var errorMessagens = result.Errors.Select(f => f.ErrorMessage).ToList();

            throw new ErrorOnValidationException(errorMessagens);
        }
    }
}
