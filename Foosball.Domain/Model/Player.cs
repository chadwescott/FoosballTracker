using System;

namespace Foosball.Domain.Model
{
    public class Player : IPlayer
    {
        public Guid Id { get; set; }
        public string DisplayName { get { return string.Format("{0} {1}", FirstName, LastName); } }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Rating { get; set; }
    }
}
