using Foosball.Business.Model;
using Foosball.Domain.Command;
using Foosball.Domain.Model;
using Foosball.Repository;

namespace Foosball.Business
{
    internal class UpdatePlayerRating : ICommand
    {
        private readonly IGame _game;

        public UpdatePlayerRating(IGame game)
        {
            _game = game;
        }

        public void Execute()
        {
            var commands = new FoosballRepositoryCommands();
            var rating = new EloRating(_game.Winner.Rating, _game.Loser.Rating, 1, 0);

            var winnerHistory = new RatingHistory { Rating = rating.FinalResult1, Game = _game, Delta = rating.Point1, Player = _game.Winner };
            var loserHistory = new RatingHistory { Rating = rating.FinalResult2, Game = _game, Delta = rating.Point2, Player = _game.Loser };
            commands.SaveRatingHistory(winnerHistory);
            commands.SaveRatingHistory(loserHistory);

            _game.Winner.Rating = rating.FinalResult1;
            _game.Loser.Rating = rating.FinalResult2;
            commands.SavePlayer(_game.Winner);
            commands.SavePlayer(_game.Loser);
        }
    }
}
