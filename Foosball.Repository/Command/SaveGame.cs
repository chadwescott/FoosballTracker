using Foosball.Repository.Tables;

namespace Foosball.Repository.Command
{
    internal class SaveGame : RepositorySave<DbGame>
    {
        public SaveGame(DbGame result) : base(result)
        { }
    }
}
