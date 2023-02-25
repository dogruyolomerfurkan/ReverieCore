using ReverieCore.Enums;

namespace ReverieCore.Entities;

public class BaseEntity<TId>
{
    public TId Id { get; set; } = default!;
    public Status Status { get; set; }
    public DateTimeOffset CreateDate { get; set; } = DateTime.UtcNow;
    public DateTimeOffset UpdateDate { get; set; } = DateTime.UtcNow;
}