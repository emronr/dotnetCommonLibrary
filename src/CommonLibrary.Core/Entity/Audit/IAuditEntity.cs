using System;
using CommonLibrary.Core.Entity.Base;

namespace CommonLibrary.Core.Entity.Audit;

public interface IAuditEntity<TKey> : IEntity<TKey>
    where TKey : IComparable
{
    DateTime CreatedAt { get; set; }
    DateTime? UpdatedAt { get; set; }
}