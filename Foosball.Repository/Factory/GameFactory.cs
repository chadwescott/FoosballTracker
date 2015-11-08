using System;
using Foosball.Domain.Model;
using Foosball.Repository.Model;

namespace Foosball.Repository.Factory
{
    internal static class GameFactory
    {
        public static Game MakeGame(IGame game)
        {
            return new Game
            {
                Id = game.Id,
                Player1Id = game.Player1.Id,
                Player1Score = game.Player1Score,
                Player2Id = game.Player2.Id,
                Player2Score = game.Player2Score,
                Timestamp = game.Timestamp == new DateTime() ? DateTime.Now : game.Timestamp
            };
        }
    }
}
