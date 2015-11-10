using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Foosball.Domain.Model;

namespace Foosball.Repository.Model
{
    [Table("Players")]
    public class Player : IPlayer
    {
        [Column("Id")]
        public Guid Id { get; set; }

        [Column("UserName")]
        [Required]
        public string UserName { get; set; }

        [Column("FirstName")]
        [Required]
        public string FirstName { get; set; }

        [Column("LastName")]
        [Required]
        public string LastName { get; set; }

        [Column("Rating")]
        [Required]
        public double Rating { get; set; }

        [NotMapped]
        public IEnumerable<IGame> Games { get; set; }
    }
}
