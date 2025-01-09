
using AutoMapper;
using CashFlow.Comunnication.Responses;
using CashFlow.Domain.Repositories.Expenses;
using CashFlow.Exception;
using CashFlow.Exception.ExceptionsBase;

namespace CashFlow.Application.UserCases.Expenses.GetById;

public class GetExpensesByIdUseCase : IGetExpensesByIdUseCase
{
    private readonly IMapper _mapper;
    private readonly IExpensesReadOnlyRepository _repository;
    public GetExpensesByIdUseCase(IExpensesReadOnlyRepository repository, IMapper mapper)
    {
        _mapper = mapper;
        _repository = repository;
        
    }

    public async Task<ResponseExpenseJson> Execute(long id)
    {
        var result = await _repository.GetById(id);

        if(result == null)
        {
            throw new NotFoundException(ResourceErrorMessages.EXPENSE_NOT_FOUND);
        }

        return _mapper.Map<ResponseExpenseJson>(result);
    }
}
