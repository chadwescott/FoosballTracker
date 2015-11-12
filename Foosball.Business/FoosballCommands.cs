using System;
using System.Collections.Generic;
using Foosball.Domain.Command;
using Foosball.Domain.Model;
using Foosball.Repository;

namespace Foosball.Business
{
    public class FoosballCommands
    {
        private readonly CommandExecuter _executer = new CommandExecuter();
        private readonly FoosballRepositoryCommands _repositoryCommands = new FoosballRepositoryCommands();

        public IEnumerable<IGame> GetGames()
        {
            return _repositoryCommands.GetGames();
        }

        public IPlayer GetPlayerById(Guid id)
        {
            return _repositoryCommands.GetPlayerById(id);
        }

        public IEnumerable<IPlayerRecord> GetPlayerRecords()
        {
            return _repositoryCommands.GetPlayerRecords();
        }

        public IEnumerable<IPlayer> GetPlayers()
        {
            return _repositoryCommands.GetPlayers();
        }

        public IGame SaveGame(IGame game)
        {
            if (game.Winner.Id == game.Loser.Id)
                throw new Exception("The winner and loser can't be the same player!");
            game = _repositoryCommands.SaveGame(game);
            UpdatePlayerRating(game);
            return game;
        }

        internal void UpdatePlayerRating(IGame game)
        {
            var command = new UpdatePlayerRating(game);
            _executer.Execute(command);
        }
    }
}
