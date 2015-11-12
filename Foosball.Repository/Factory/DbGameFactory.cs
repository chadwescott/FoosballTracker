using System;
using Foosball.Domain.Model;
using Foosball.Repository.Tables;

namespace Foosball.Repository.Factory
{
    internal static class DbGameFactory
    {
        public static DbGame Make(IGame game)
        {
            return new DbGame
            {
                Id = game.Id,
                WinnerScore = game.WinnerScore,
                WinnerRating = game.WinnerRating,
                WinnerDelta = game.WinnerDelta,
                WinnerId = game.Winner.Id,
                LoserScore = game.LoserScore,
                LoserRating = game.LoserRating,
                LoserDelta = game.LoserDelta,
                LoserId = game.Loser.Id,
                Timestamp = game.Timestamp == new DateTime() ? DateTime.Now : game.Timestamp
            };
        }
    }
}
