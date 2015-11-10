using Foosball.Repository.Model;

namespace Foosball.Repository.Command
{
    internal class SavePlayer : RepositorySave<Player>
    {
        public SavePlayer(Player model) : base(model)
        { }
    }
}
