using System;
using CommonLibrary.Core.Entity.Base;

namespace CommonLibrary.Core.Entity.Audit;

public interface IAuditEntity<T> : IEntity<T>
{
    DateTime CreatedAt { get; set; }
    DateTime? UpdatedAt { get; set; }
}