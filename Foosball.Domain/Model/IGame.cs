using System;

namespace Foosball.Domain.Model
{
    public interface IGame : IHasId<Guid>
    {
        DateTime Timestamp { get; set; }
        IPlayer Loser { get; set; }
        int LoserScore { get; set; }
        double LoserRating { get; set; }
        double LoserDelta { get; set; }
        IPlayer Winner { get; set; }
        int WinnerScore { get; set; }
        double WinnerRating { get; set; }
        double WinnerDelta { get; set; }
    }
}