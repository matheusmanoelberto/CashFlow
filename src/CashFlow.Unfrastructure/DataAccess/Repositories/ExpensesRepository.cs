using CashFlow.Domain.Entities;
using CashFlow.Domain.Repositories.Expenses;

namespace CashFlow.Infrastructure.DataAccess.Repositories;

internal class ExpensesRepository : IExpensesRepository
{
    private readonly CashFlowDbContext _dbContext;
    public ExpensesRepository(CashFlowDbContext context)
    {
        _dbContext = context;
    }
    public async Task Add(Expense expense)
    {
       await _dbContext.Expenses.AddAsync(expense);
    }
}