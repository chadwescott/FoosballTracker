using System;

namespace Foosball.Domain.Model
{
    public interface IPlayer : IHasId
    {
        string UserName { get; }
        string FirstName { get; }
        string LastName { get; }
        double Rating { get; set; }
    }
}
