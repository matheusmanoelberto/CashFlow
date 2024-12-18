using CashFlow.Application.UserCases.Expenses.Register;
using CashFlow.Comunnication.Requests;
using CashFlow.Comunnication.Responses;
using CashFlow.Exception.ExceptionsBase;
using Microsoft.AspNetCore.Mvc;

namespace CashFlow.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ExpensesController : ControllerBase
{
    [HttpPost]
    public IActionResult Register([FromBody] RequestRegisterExpenseJson request)
    {
        try
        {
            var userCase = new RegisterExpenseUseCase();
            var response = userCase.Execute(request);
            return Created(string.Empty, response);
        }
        catch (ErrorOnValidationException ex)
        {
            var errorResponse = new ResponseErrorJson(ex.Message);

            return BadRequest(errorResponse);
        }
        catch
        {
            var errorResponse = new ResponseErrorJson("unknown error");

            return StatusCode(StatusCodes.Status500InternalServerError, errorResponse);
        }
    }
}
