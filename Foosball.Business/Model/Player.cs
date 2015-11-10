using System;
using Foosball.Domain.Model;

namespace Foosball.Business.Model
{
    internal class Player : IPlayer
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get;  set; }
        public string LastName { get;  set; }
        public double Rating { get;  set; }
    }
}
