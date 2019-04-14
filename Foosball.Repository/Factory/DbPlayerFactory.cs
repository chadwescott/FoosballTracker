using Foosball.Domain.Model;
using Foosball.Repository.Tables;

namespace Foosball.Repository.Factory
{
    internal static class DbPlayerFactory
    {
        public static DbPlayer Make(IPlayer player)
        {
            return new DbPlayer
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
