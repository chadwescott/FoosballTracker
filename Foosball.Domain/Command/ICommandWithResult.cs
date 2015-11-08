namespace Foosball.Domain.Command
{
    public interface ICommandWithResult<out T> : ICommand
    {
        T Result { get; }
    }
}
