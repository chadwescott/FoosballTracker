using System;

namespace Foosball.Domain.Model
{
    public interface IGame : IHasId
    {
        DateTime Timestamp { get; }
        IPlayer Winner { get; set; }
        IPlayer Loser { get; set; }
        int WinnerScore { get; set; }
        int LoserScore { get; }
    }
}
