namespace LuftbornTask.Domain.Interfaces;

public interface IUnitOfWork
{
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default, bool isConcurrency = false);
}