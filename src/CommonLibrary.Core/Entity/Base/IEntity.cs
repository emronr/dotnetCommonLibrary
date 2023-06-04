namespace CommonLibrary.Core.Entity.Base;

public interface IEntity<TKey>
    where TKey : IComparable
{
    TKey Id { get; set; }
}