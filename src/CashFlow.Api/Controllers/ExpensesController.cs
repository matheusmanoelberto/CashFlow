using CashFlow.Application.UserCases.Expenses.Register;
using CashFlow.Comunnication.Requests;
using Microsoft.AspNetCore.Mvc;

namespace CashFlow.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ExpensesController : ControllerBase
{
    [HttpPost]
    public IActionResult Register([FromBody] RequestRegisterExpenseJson request)
    {
        var userCase = new RegisterExpenseUseCase();
        var response = userCase.Execute(request);
        return Created(string.Empty, response);
    }
}
