using System;

namespace Foosball.Domain.Model
{

    public interface IPlayerGameLog : IHasId<Guid>
    {
        Guid PlayerId { get; set; }
        DateTime Timestamp { get; set; }
        int GoalsScored { get; set; }
        int GoalsAllowed { get; set; }
        double Rating { get; set; }
        double Delta { get; set; }
    }
}
