using System;
using Foosball.Domain.Model;

namespace Foosball.Web.Models
{
    public class PlayerRecordViewModel : Player, IPlayerRecord, IGridModel
    {
        public string recid
        {
            get { return Id.ToString(); }
            set { Id = new Guid(value); }
        }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public double? WinPercentage {
            get
            {
                if (GamesPlayed == 0) return null;
                return (Wins * 100.0) / GamesPlayed;
            }
        }
        public int GoalsScored { get; set; }
        public int GoalsAllowed { get; set; }
        public int GamesPlayed { get { return Wins + Losses; } }
        public decimal GoalsScoredPerGame { get { return GamesPlayed == 0 ? 0 : GoalsScored / (decimal)GamesPlayed; } }
        public decimal GoalsAllowedPerGame { get { return GamesPlayed == 0 ? 0 : GoalsAllowed / (decimal)GamesPlayed; } }
    }
}