using System;
using Foosball.Domain.Model;

namespace Foosball.Repository.Test.Model
{
    internal class Game : IGame
    {
        public Guid Id { get; set; }
        public DateTime Timestamp { get; set; }
        public Guid Player1Id { get; set; }
        public IPlayer Player1 { get; set; }
        public Guid Player2Id { get; set; }
        public IPlayer Player2 { get; set; }
        public int Player1Score { get; set; }
        public int Player2Score { get; set; }
    }
}
