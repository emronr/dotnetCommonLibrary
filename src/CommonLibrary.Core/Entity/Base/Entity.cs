namespace CommonLibrary.Core.Entity.Base;

public class Entity<TKey> : IEntity<TKey>
    where TKey : IComparable
{
    public TKey Id { get; set; }
}