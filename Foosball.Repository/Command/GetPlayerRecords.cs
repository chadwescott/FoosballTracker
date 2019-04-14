using System.Collections.Generic;
using System.Linq;
using Foosball.Repository.Views;

namespace Foosball.Repository.Command
{
    internal class GetPlayerRecords : RepositoryRead<DbPlayerRecord, IEnumerable<DbPlayerRecord>>
    {
        public override void Execute()
        {
            InvokeRepositoryRead(r => { Result = r.GetAll().ToList(); });
        }
    }
}
