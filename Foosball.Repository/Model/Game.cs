using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Foosball.Domain.Model;

namespace Foosball.Repository.Model
{
    [Table("Games")]
    public class Game : IGame
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public Guid Id { get; set; }

        [Column("Timestamp")]
        public DateTime Timestamp { get; set; }

        [Column("WinnerId")]
        public Guid WinnerId { get; set; }

        public IPlayer Winner { get { return DbWinner; } }

        [ForeignKey("WinnerId")]
        public Player DbWinner { get; set; }

        [Column("WinnerScore")]
        public int WinnerScore { get; set; }

        [Column("LoserId")]
        public Guid LoserId { get; set; }

        public IPlayer Loser { get { return DbLoser; } }

        [ForeignKey("LoserId")]
        public Player DbLoser { get; set; }

        [Column("LoserScore")]
        public int LoserScore { get; set; }
    }
}
