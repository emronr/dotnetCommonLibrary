using CommonLibrary.Core.Entity.Audit;

namespace CommonLibrary.Core.Entity.AuditUser;

public interface IAuditUserEntity<TKey, TUserKey> : IAuditEntity<TKey>
where TKey : IComparable
    
{
    TUserKey? CreatedBy { get; set; }
    TUserKey? LastUpdatedBy { get; set; }
}