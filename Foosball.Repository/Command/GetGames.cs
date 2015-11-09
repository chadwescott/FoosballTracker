using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Foosball.Repository.Model;

namespace Foosball.Repository.Command
{
    internal class GetGames : RepositoryRead<Game, IEnumerable<Game>>
    {
        public override void Execute()
        {
            InvokeRepositoryRead(r =>
            {
                Result = r.GetAll().Include(g => g.DbWinner).Include(g => g.DbLoser).ToList();
            });
        }
    }
}
