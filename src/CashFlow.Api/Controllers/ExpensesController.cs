﻿using CashFlow.Application.UserCases.Expenses.Register;
using CashFlow.Application.UserCases.Expenses.GetAll;
using CashFlow.Comunnication.Requests;
using CashFlow.Comunnication.Responses;
using Microsoft.AspNetCore.Mvc;
using CashFlow.Application.UserCases.Expenses.GetById;
using CashFlow.Application.UserCases.Expenses.Delete;
using CashFlow.Application.UserCases.Expenses.Update;

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
        [FromBody] RequestExpenseJson request)
    {

        var response = await useCase.Execute(request);
        return Created(string.Empty, response);
    }

    [HttpGet]
    [ProducesResponseType(typeof(ResponseExpensesJson), StatusCodes.Status200OK)]
    [ProducesResponseType( StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetAllExpenses([FromServices] IGetAllExpenseUseCase useCase,
        [FromHeader] DateOnly teste)
    {

        var response = await useCase.Execute();

        if (response.Expenses.Count != 0)
            return Ok(response);

        return NoContent();
    }

    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(ResponseExpenseJson), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseExpenseJson), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetById([FromServices] IGetExpensesByIdUseCase useCase, [FromRoute] long id)
    {

        var response = await useCase.Execute(id);
        return Ok(response);
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType( StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(
        [FromServices] IDeleteExpensesUseCase useCase, 
        [FromRoute] long id)
    {

        await useCase.Execute(id);

        return NoContent();
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Update(
        [FromServices] IUpdateExpensesUseCase useCase,
        [FromRoute] long id,
        [FromBody] RequestExpenseJson request)
    {

        await useCase.Execute(id, request);

        return NoContent();
    }
}
