using System;
using Foosball.Repository.Tables;

namespace Foosball.Repository.Command
{
    internal class GetPlayerById : RepositoryRead<DbPlayer, DbPlayer>
    {
        private readonly Guid _id;

        public GetPlayerById(Guid id)
        {
            _id = id;
        }

        public override void Execute()
        {
            InvokeRepositoryRead(r => Result = r.GetById(_id));
        }
    }
}
