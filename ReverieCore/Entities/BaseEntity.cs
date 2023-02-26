using ReverieCore.Enums;

namespace ReverieCore.Entities;

public class BaseEntity<TId> : IBaseEntity
{
    public TId Id { get; set; } = default!;
    public Status Status { get; set; }
    public DateTimeOffset CreateDate { get; set; }
    public DateTimeOffset UpdateDate { get; set; }
}