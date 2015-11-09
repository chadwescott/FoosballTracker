using System;
using Foosball.Domain.Model;

namespace Foosball.Repository.Test.Model
{
    internal class Game : IGame
    {
        public Guid Id { get; set; }
        public DateTime Timestamp { get; set; }
        public Guid Player1Id { get; set; }
        public IPlayer Winner { get; set; }
        public Guid Player2Id { get; set; }
        public IPlayer Loser { get; set; }
        public int WinnerScore { get; set; }
        public int LoserScore { get; set; }
    }
}
