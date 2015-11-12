using System;

namespace Foosball.Domain.Model
{
    public class Player : IPlayer
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Rating { get; set; }
    }
}
