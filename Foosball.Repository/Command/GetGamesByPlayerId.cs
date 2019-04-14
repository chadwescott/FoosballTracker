using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Foosball.Domain.Model;
using Foosball.Repository.Tables;

namespace Foosball.Repository.Command
{
    internal class GetGamesByPlayerId : RepositoryRead<DbGame, IEnumerable<IGame>>
    {
        private readonly Guid _playerId;

        public GetGamesByPlayerId(Guid playerId)
        {
            _playerId = playerId;
        }

        public override void Execute()
        {
            InvokeRepositoryRead(r =>
            {
                Result =
                    r.GetAll()
                        .Include(g => g.DbWinner)
                        .Include(g => g.DbLoser)
                        .Where(g => g.WinnerId == _playerId || g.LoserId == _playerId)
                        .ToList();
            });
        }
    }
}
