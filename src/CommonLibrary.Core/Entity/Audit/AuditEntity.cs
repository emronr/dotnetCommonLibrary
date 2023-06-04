using System;
using CommonLibrary.Core.Entity.Base;

namespace CommonLibrary.Core.Entity.Audit;

public abstract class AuditEntity<T> : Entity<T>, IAuditEntity<T>
{
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}