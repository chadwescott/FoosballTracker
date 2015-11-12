using Foosball.Domain.Model;

namespace Foosball.Web.Models
{
    public class PlayerRecordViewModel : Player, IPlayerRecord
    {
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int GoalsScored { get; set; }
        public int GoalsAllowed { get; set; }
        public int GamesPlayed { get { return Wins + Losses; } }
        public decimal GoalsScoredPerGame { get { return GamesPlayed == 0 ? 0 : GoalsScored / (decimal)GamesPlayed; } }
        public decimal GoalsAllowedPerGame { get { return GamesPlayed == 0 ? 0 : GoalsAllowed / (decimal)GamesPlayed; } }
    }
}