using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Foosball.Domain.Model;
using Foosball.Repository.Factory;

namespace Foosball.Repository.Tables
{
    [Table("Games")]
    internal class DbGame : IGame
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public Guid Id { get; set; }

        [Column("Timestamp")]
        public DateTime Timestamp { get; set; }

        [Column("LoserId")]
        public Guid LoserId { get; set; }

        [ForeignKey("LoserId")]
        public DbPlayer DbLoser { get; set; }

        [NotMapped]
        public IPlayer Loser
        {
            get { return DbLoser; }
            set { DbLoser = DbPlayerFactory.Make(value); }
        }

        [Column("LoserScore")]
        public int LoserScore { get; set; }

        [Column("LoserRating")]
        public double LoserRating { get; set; }

        [Column("LoserDelta")]
        public double LoserDelta { get; set; }

        [Column("WinnerId")]
        public Guid WinnerId { get; set; }

        [ForeignKey("WinnerId")]
        public DbPlayer DbWinner { get; set; }

        [NotMapped]
        public IPlayer Winner
        {
            get { return DbWinner; }
            set { DbWinner = DbPlayerFactory.Make(value); }
        }

        [Column("WinnerScore")]
        public int WinnerScore { get; set; }

        [Column("WinnerRating")]
        public double WinnerRating { get; set; }

        [Column("WinnerDelta")]
        public double WinnerDelta { get; set; }
    }
}
