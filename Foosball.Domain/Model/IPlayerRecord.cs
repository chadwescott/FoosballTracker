namespace Foosball.Domain.Model
{
    public interface IPlayerRecord
    {
        IPlayer Player { get; }
        int Wins { get; }
        int Losses { get; }
        int GoalsScored { get; }
        int GoalsAllowed { get; }
    }
}
