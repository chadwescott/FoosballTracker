using System;

namespace Foosball.Domain.Model
{
    public class PlayerGameLog : IPlayerGameLog
    {
        public Guid Id { get; set; }
        public Guid PlayerId { get; set; }
        public DateTime Timestamp { get; set; }
        public int GoalsScored { get; set; }
        public int GoalsAllowed { get; set; }
        public double Rating { get; set; }
        public double Delta { get; set; }
    }
}
