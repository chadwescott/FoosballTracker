using System;
using Foosball.Domain.Model;

namespace Foosball.Web.Models
{
    public class PlayerViewModel : IPlayer
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}