namespace Foosball.Domain.Model
{
    public interface IHasId<T>
    {
        T Id { get; }
    }
}
