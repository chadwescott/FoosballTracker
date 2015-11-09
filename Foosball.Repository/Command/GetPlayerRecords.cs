using System.Collections.Generic;
using System.Linq;
using Foosball.Repository.Model;

namespace Foosball.Repository.Command
{
    internal class GetPlayerRecords : RepositoryRead<PlayerRecord, IEnumerable<PlayerRecord>>
    {
        public override void Execute()
        {
            InvokeRepositoryRead(r => { Result = r.GetAll().ToList(); });
        }
    }
}
