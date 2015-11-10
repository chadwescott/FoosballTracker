using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Foosball.Domain.Model;

namespace Foosball.Repository.Model
{
    [Table("RatingHistory")]
    internal class RatingHistory : IRatingHistory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public Guid Id { get; set; }

        [Column("PlayerId")]
        [Required]
        public Guid PlayerId { get; set; }
        public IPlayer Player { get; set; }

        [Column("GameId")]
        [Required]
        public Guid GameId{ get; set; }
        public IGame Game { get; set; }

        [Column("Rating")]
        [Required]
        public double Rating { get; set; }

        [Column("Delta")]
        [Required]
        public double Delta { get; set; }
    }
}
