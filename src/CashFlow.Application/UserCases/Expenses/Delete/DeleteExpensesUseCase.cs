
using CashFlow.Domain.Repositories;
using CashFlow.Domain.Repositories.Expenses;
using CashFlow.Exception;

namespace CashFlow.Application.UserCases.Expenses.Delete;

public class DeleteExpensesUseCase : IDeleteExpensesUseCase
{
    private readonly IExpensesWriteOnlyRepository _repository;
    private readonly IUnitOfWork _unitOfWork;
    public DeleteExpensesUseCase(IExpensesWriteOnlyRepository repository,
        IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;        
    }
    public async Task Execute(long id)
    {
        var result = await _repository.Delete(id);

        if (result == false) 
        {
            throw new NotFiniteNumberException(ResourceErrorMessages.EXPENSE_NOT_FOUND);
        }

        await _unitOfWork.Commit();

    }
}