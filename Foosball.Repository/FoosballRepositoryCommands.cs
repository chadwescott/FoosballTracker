using System.Collections.Generic;
using Foosball.Domain.Command;
using Foosball.Domain.Model;
using Foosball.Repository.Command;
using Foosball.Repository.Factory;

namespace Foosball.Repository
{
    public class FoosballRepositoryCommands
    {
        private readonly CommandExecuter _executer = new CommandExecuter();

        public IEnumerable<IGame> GetGames()
        {
            var command = new GetGames();
            _executer.Execute(command);
            return command.Result;
        }

        public IEnumerable<IPlayerRecord> GetPlayerRecords()
        {
            var command = new GetPlayerRecords();
            _executer.Execute(command);
            return command.Result;
        }

        public IEnumerable<IPlayer> GetPlayers()
        {
            var command = new GetPlayers();
            _executer.Execute(command);
            return command.Result;
        }

        public IGame SaveGame(IGame game)
        {
            var command = new SaveGame(GameFactory.MakeGame(game));
            _executer.Execute(command);
            return command.Result;
        }

        public IPlayer SavePlayer(IPlayer player)
        {
            var command = new SavePlayer(PlayerFactory.MakePlayer(player));
            _executer.Execute(command);
            return command.Result;
        }

        public IRatingHistory SaveRatingHistory(IRatingHistory ratingHistory)
        {
            var command = new SaveRatingHistory(RatingHistoryFactory.MakeGame(ratingHistory));
            command.Execute();
            return command.Result;
        }
    }
}
