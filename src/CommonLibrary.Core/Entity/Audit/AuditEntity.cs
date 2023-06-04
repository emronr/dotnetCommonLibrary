using System;
using CommonLibrary.Core.Entity.Base;

namespace CommonLibrary.Core.Entity.Audit;

public abstract class AuditEntity<TKey> : Entity<TKey>, IAuditEntity<TKey>
    where TKey : IComparable
{
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}