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

            _game.WinnerRating = rating.FinalResult1;
            _game.WinnerDelta = rating.Point1;
            _game.LoserRating = rating.FinalResult2;
            _game.LoserDelta = rating.Point2;
            commands.SaveGame(_game);

            _game.Winner.Rating = rating.FinalResult1;
            _game.Loser.Rating = rating.FinalResult2;
            commands.SavePlayer(_game.Winner);
            commands.SavePlayer(_game.Loser);
        }
    }
}
