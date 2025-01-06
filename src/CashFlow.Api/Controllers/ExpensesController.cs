using CashFlow.Application.UserCases.Expenses.Register;
using CashFlow.Comunnication.Requests;
using CashFlow.Comunnication.Responses;
using Microsoft.AspNetCore.Mvc;

namespace CashFlow.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ExpensesController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisteredExpensejson), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Register(
        [FromServices] IRegisterExpenseUseCase useCase, 
        [FromBody] RequestRegisterExpenseJson request)
    {

        var response = await useCase.Execute(request);
        return Created(string.Empty, response);
    }
}
