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
                WinnerId = game.Winner.Id,
                WinnerScore = game.WinnerScore,
                LoserId = game.Loser.Id,
                LoserScore = game.LoserScore,
                Timestamp = game.Timestamp == new DateTime() ? DateTime.Now : game.Timestamp
            };
        }
    }
}
