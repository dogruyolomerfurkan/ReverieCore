using Microsoft.EntityFrameworkCore.Query;
using ReverieCore.Entities;
using System.Linq.Expressions;

namespace ReverieCore.Repositories.Abstract;

public interface IEFWriteRepository<T, TId> : IEFRepository<T, TId> where T : BaseEntity<TId>, new()
{
    void Add(T entity);
    Task AddAsync(T entity);
    void AddRange(IEnumerable<T> entities);
    Task AddRangeAsync(IEnumerable<T> entities);
    void Update(T entity);
    void UpdateRange(IEnumerable<T> entities);
    int ExecuteUpdate(Expression<Func<T, bool>> filter, Expression<Func<SetPropertyCalls<T>, SetPropertyCalls<T>>> setPropertyCalls);
    Task<int> ExecuteUpdateAsync(Expression<Func<T, bool>> filter, Expression<Func<SetPropertyCalls<T>, SetPropertyCalls<T>>> setPropertyCalls);
    int Remove(Expression<Func<T, bool>> filter);
    Task<int> RemoveAsync(Expression<Func<T, bool>> filter);
    int Save();
    Task<int> SaveAsync();
}