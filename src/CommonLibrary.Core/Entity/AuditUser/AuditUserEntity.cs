using CommonLibrary.Core.Entity.Audit;

namespace CommonLibrary.Core.Entity.AuditUser;

public abstract class AuditUserEntity<TKey, TUserKey> : AuditEntity<TKey>, IAuditUserEntity<TKey, TUserKey>
    where TKey : IComparable
{
    public TUserKey? CreatedBy { get; set; }
    public TUserKey? LastUpdatedBy { get; set; }
}