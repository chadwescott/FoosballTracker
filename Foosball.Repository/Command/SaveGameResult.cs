using System;
using Foosball.Repository.Model;

namespace Foosball.Repository.Command
{
    internal class SaveGameResult : RepositorySave<PlayerRecord>
    {
        public SaveGameResult(PlayerRecord model)
            : base(model)
        { }

        protected override bool IsNew(PlayerRecord model)
        {
            return model.Id == Guid.Empty;
        }
    }
}
