using Foosball.Repository.Model;

namespace Foosball.Repository.Command
{
    internal class SaveGame : RepositorySave<Game>
    {
        public SaveGame(Game result) : base(result)
        { }
    }
}
