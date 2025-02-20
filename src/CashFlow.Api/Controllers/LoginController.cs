using CashFlow.Application.UserCases.Login.DoLogin;
using CashFlow.Comunnication.Requests;
using CashFlow.Comunnication.Responses;
using Microsoft.AspNetCore.Mvc;

namespace CashFlow.Api.Controllers
{
    public class LoginController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(ResponseRegisteredUserJson), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> Login(
       [FromServices] IDoLoginUseCase userCase,
       [FromBody] RequestLoginJson request)
        {
            var response = await userCase.Execute(request);
            return Created(string.Empty, response);
        }
    }
}
