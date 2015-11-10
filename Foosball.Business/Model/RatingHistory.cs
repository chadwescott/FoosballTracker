using System;
using Foosball.Domain.Model;

namespace Foosball.Business.Model
{
    internal class RatingHistory : IRatingHistory
    {
        public Guid Id { get; set; }
        public IPlayer Player { get; set; }
        public IGame Game { get; set; }
        public double Rating { get; set; }
        public double Delta { get; set; }
    }
}
