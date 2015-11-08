using System.Collections.Generic;
using System.Linq;
using Foosball.Repository.Model;

namespace Foosball.Repository.Command
{
    internal class GetPlayers : RepositoryRead<Player, IEnumerable<Player>>
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
