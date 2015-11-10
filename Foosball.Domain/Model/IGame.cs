using System;

namespace Foosball.Domain.Model
{
    public interface IGame : IHasId
    {
        DateTime Timestamp { get; }
        IPlayer Winner { get; }
        IPlayer Loser { get; }
        int WinnerScore { get; }
        int LoserScore { get; }
    }
}
