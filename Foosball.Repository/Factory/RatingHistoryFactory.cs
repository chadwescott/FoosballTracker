using Foosball.Domain.Model;
using Foosball.Repository.Model;

namespace Foosball.Repository.Factory
{
    internal class RatingHistoryFactory
    {
        public static RatingHistory MakeGame(IRatingHistory ratingHistory)
        {
            return new RatingHistory
            {
                Id = ratingHistory.Id,
                Delta = ratingHistory.Delta,
                Game = ratingHistory.Game,
                GameId = ratingHistory.Game.Id,
                Player = ratingHistory.Player,
                PlayerId = ratingHistory.Player.Id,
                Rating = ratingHistory.Rating
            };
        }
    }
}
