using System.Collections.Generic;
using System.Linq;
using Foosball.Repository.Tables;

namespace Foosball.Repository.Command
{
    internal class GetPlayers : RepositoryRead<DbPlayer, IEnumerable<DbPlayer>>
    {
        public override void Execute()
        {
            InvokeRepositoryRead(r =>
            {
                Result = r.GetAll().ToList();
            });
        }
    }
}
