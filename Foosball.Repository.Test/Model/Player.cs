using System;
using Foosball.Domain.Model;

namespace Foosball.Repository.Test.Model
{
    internal class Player : IPlayer
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
