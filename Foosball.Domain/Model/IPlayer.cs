using System;

namespace Foosball.Domain.Model
{
    public interface IPlayer : IHasId<Guid>
    {
        string DisplayName { get; }
        string UserName { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        double Rating { get; set; }
    }
}