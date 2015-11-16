using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Foosball.Domain.Model;

namespace Foosball.Repository.Views
{
    [Table("V_PlayerGameLog")]
    internal class DbPlayerGameLog : IPlayerGameLog
    {
        [Key]
        [Column("Id")]
        public Guid Id { get; set; }

        [Column("PlayerId")]
        public Guid PlayerId { get; set; }

        [Column("Timestamp")]
        public DateTime Timestamp { get; set; }

        [Column("GoalsScored")]
        public int GoalsScored { get; set; }

        [Column("GoalsAllowed")]
        public int GoalsAllowed { get; set; }

        [Column("Rating")]
        public double Rating { get; set; }

        [Column("Delta")]
        public double Delta { get; set; }
    }
}
