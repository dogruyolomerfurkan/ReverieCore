using ReverieCore.Enums;

namespace ReverieCore.Entities
{
    public interface IBaseEntity
    {
        Status Status { get; set; }
        DateTimeOffset CreateDate { get; set; }
        DateTimeOffset UpdateDate { get; set; }
    }
}