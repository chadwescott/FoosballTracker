namespace Foosball.Domain.Model
{
    public interface IPlayerRecord : IPlayer
    {
        int Wins { get; set; }
        int Losses { get; set; }
        int GoalsScored { get; set; }
        int GoalsAllowed { get; set; }
    }
}