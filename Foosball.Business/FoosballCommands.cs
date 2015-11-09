using System.Collections.Generic;
using Foosball.Domain.Model;
using Foosball.Repository;

namespace Foosball.Business
{
    public class FoosballCommands
    {
        private readonly FoosballRepositoryCommands _repositoryCommands = new FoosballRepositoryCommands();

        public IEnumerable<IGame> GetGames()
        {
            return _repositoryCommands.GetGames();
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
            return _repositoryCommands.SaveGame(game);
        }
    }
}
