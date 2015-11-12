using Foosball.Repository.Tables;

namespace Foosball.Repository.Command
{
    internal class SavePlayer : RepositorySave<DbPlayer>
    {
        public SavePlayer(DbPlayer model) : base(model)
        { }
    }
}
