using CashFlow.Domain.Repositories;

namespace CashFlow.Infrastructure.DataAccess.Repositories;

internal class UnitOfWork : IUnitOfWork
{
    private readonly CashFlowDbContext _dbContext;
    public UnitOfWork(CashFlowDbContext context)
    {
        _dbContext = context;
    }
    public async Task Commit() => await _dbContext.SaveChangesAsync();
}
