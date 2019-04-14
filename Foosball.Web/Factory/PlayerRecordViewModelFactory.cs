using Foosball.Domain.Model;
using Foosball.Web.Models;

namespace Foosball.Web.Factory
{
    internal static class PlayerRecordViewModelFactory
    {
        public static PlayerRecordViewModel Make(IPlayerRecord model)
        {
            return new PlayerRecordViewModel
            {
                FirstName = model.FirstName,
                GoalsAllowed = model.GoalsAllowed,
                GoalsScored = model.GoalsScored,
                Id = model.Id,
                LastName = model.LastName,
                Losses = model.Losses,
                Rating = model.Rating,
                UserName = model.UserName,
                Wins = model.Wins
            };
        }
    }
}