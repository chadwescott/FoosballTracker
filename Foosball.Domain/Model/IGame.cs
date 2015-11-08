using System;

namespace Foosball.Domain.Model
{
    public interface IGame
    {
        Guid Id { get; }
        DateTime Timestamp { get; }
        IPlayer Player1 { get; }
        IPlayer Player2 { get; }
        int Player1Score { get; }
        int Player2Score { get; }
    }
}
