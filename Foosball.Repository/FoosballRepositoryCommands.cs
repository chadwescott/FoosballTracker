using System;
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

        public IEnumerable<IGame> GetGamesByPlayerId(Guid playerId)
        {
            var command = new GetGamesByPlayerId(playerId);
            _executer.Execute(command);
            return command.Result;
        }

        public IPlayer GetPlayerById(Guid id)
        {
            var command = new GetPlayerById(id);
            _executer.Execute(command);
            return command.Result;
        }

        public IEnumerable<IPlayerGameLog> GetPlayerGameLogsByPlayerId(Guid playerId)
        {
            var command = new GetPlayerGameLogsByPlayerId(playerId);
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
            var winner = GetPlayerById(game.Winner.Id);
            var loser = GetPlayerById(game.Loser.Id);
            var dbGame = DbGameFactory.Make(game);
            var command = new SaveGame(dbGame);
            _executer.Execute(command);
            dbGame.Winner = winner;
            dbGame.Loser = loser;
            return command.Result;
        }

        public IPlayer SavePlayer(IPlayer player)
        {
            var command = new SavePlayer(DbPlayerFactory.Make(player));
            _executer.Execute(command);
            return command.Result;
        }
    }
}
