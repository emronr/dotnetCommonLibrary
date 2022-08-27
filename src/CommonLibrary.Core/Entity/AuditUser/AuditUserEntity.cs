using CommonLibrary.Core.Entity.Audit;

namespace CommonLibrary.Core.Entity.AuditUser;

public abstract class AuditUserEntity<T> : AuditEntity<T>, IAuditUserEntity<T>
{
    public string CreatedBy { get; set; } = null!;
    public string? LastUpdatedBy { get; set; }
}