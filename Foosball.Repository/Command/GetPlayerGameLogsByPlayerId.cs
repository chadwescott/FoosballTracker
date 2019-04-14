using System;
using System.Collections.Generic;
using System.Linq;
using Foosball.Domain.Model;
using Foosball.Repository.Views;

namespace Foosball.Repository.Command
{
    internal class GetPlayerGameLogsByPlayerId : RepositoryRead<DbPlayerGameLog, IEnumerable<IPlayerGameLog>>
    {
        private readonly Guid _playerId;

        public GetPlayerGameLogsByPlayerId(Guid playerId)
        {
            _playerId = playerId;
        }

        public override void Execute()
        {
            InvokeRepositoryRead(
                r => Result = r.SearchFor(l => l.PlayerId == _playerId).OrderBy(l => l.Timestamp).ToList());
        }
    }
}
