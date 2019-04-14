using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Foosball.Domain.Model;

namespace Foosball.Repository.Tables
{
    [Table("Players")]
    internal class DbPlayer : IPlayer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public Guid Id { get; set; }

        [NotMapped]
        public string DisplayName { get { return string.Format("{0} {1}", FirstName, LastName); } }

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
    }
}
