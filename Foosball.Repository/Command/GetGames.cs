using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Foosball.Domain.Model;
using Foosball.Repository.Tables;

namespace Foosball.Repository.Command
{
    internal class GetGames : RepositoryRead<DbGame, IEnumerable<IGame>>
    {
        public override void Execute()
        {
            InvokeRepositoryRead(r =>
            {
                Result =
                    r.GetAll()
                        .Include(g => g.DbWinner)
                        .Include(g => g.DbLoser)
                        .ToList();
            });
        }
    }
}
