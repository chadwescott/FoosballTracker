using System;

namespace Foosball.Domain.Model
{
    public interface IHasId
    {
        Guid Id { get; }
    }
}
