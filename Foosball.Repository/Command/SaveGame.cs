using System;
using Foosball.Repository.Model;

namespace Foosball.Repository.Command
{
    internal class SaveGame : RepositorySave<Game>
    {
        public SaveGame(Game result)
            : base(result)
        { }

        protected override bool IsNew(Game model)
        {
            return Result.Id == Guid.Empty;
        }
    }
}
