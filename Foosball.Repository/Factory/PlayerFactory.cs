using Foosball.Domain.Model;
using Foosball.Repository.Model;

namespace Foosball.Repository.Factory
{
    internal static class PlayerFactory
    {
        public static Player MakePlayer(IPlayer player)
        {
            return new Player
            {
                Id = player.Id,
                UserName = player.UserName,
                FirstName = player.FirstName,
                LastName = player.LastName,
                Rating = player.Rating
            };
        }
    }
}
