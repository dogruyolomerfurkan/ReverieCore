using Microsoft.EntityFrameworkCore;
using ReverieCore.Entities;

namespace ReverieCore.Repositories.Abstract;

public interface IEFRepository<T, TId> where T : BaseEntity<TId>, new() {
    DbSet<T> Entity { get; }
}