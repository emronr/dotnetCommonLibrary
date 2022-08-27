using CommonLibrary.Core.Entity.Audit;

namespace CommonLibrary.Core.Entity.AuditUser;

public interface IAuditUserEntity<T> : IAuditEntity<T>
{
    string CreatedBy { get; set; }
    string? LastUpdatedBy { get; set; }
}