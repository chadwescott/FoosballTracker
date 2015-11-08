using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Foosball.Domain.Model;

namespace Foosball.Repository.Model
{
    [Table("Players")]
    internal class Player : IPlayer
    {
        [Column("Id")]
        public Guid Id { get; set; }

        [Column("FirstName")]
        [Required]
        public string FirstName { get; set; }

        [Column("LastName")]
        [Required]
        public string LastName { get; set; }

        public IEnumerable<IGame> Games { get; set; }
    }
}
