namespace CommonLibrary.Core.Entity.Base;

public interface IEntity<T>
{
    T Id { get; set; }
}