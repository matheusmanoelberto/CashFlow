using CashFlow.Application.UserCases.User.Register;
using CashFlow.Comunnication.Requests;
using CashFlow.Comunnication.Responses;
using Microsoft.AspNetCore.Mvc;

namespace CashFlow.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisteredUserJson), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status201Created)]
    public async Task<IActionResult> Register(
        [FromServices] IRegisterUserUseCase userCase,
        [FromBody] RequestRegisterUserJson request)
    {
        var response = await userCase.Execute(request);
        return Created(string.Empty, response);
    }

}