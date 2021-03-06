﻿using System;

namespace Foosball.Domain.Model
{
    public interface IRatingHistory : IHasId<Guid>
    {
        IPlayer Player { get; }
        IGame Game { get; }
        double Rating { get; }
        double Delta { get; }
    }
}
