namespace Foosball.Domain.Model
{
    public class PlayerRecord : Player, IPlayerRecord
    {
        public virtual int Wins { get; set; }
        public virtual int Losses { get; set; }
        public virtual int GoalsScored { get; set; }
        public virtual int GoalsAllowed { get; set; }
    }
}
