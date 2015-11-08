using System;

namespace Foosball.Domain.Model
{
    public interface IPlayer
    {
        Guid Id { get; }
        string FirstName { get; }
        string LastName { get; }
    }
}
