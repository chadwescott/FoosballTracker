using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Foosball.Repository.Views
{
    [Table("V_GameSummary")]
    internal class DbGameSummary
    {
        [Key]
        [Column("GameId")]
        public Guid GameId { get; set; }
        public DateTime Timestamp { get; set; }
        public string LoserUserName { get; set; }
        public int LoserScore { get; set; }
        public double LoserRating { get; set; }
        public double LoserDelta { get; set; }
        public string WinnerUserName { get; set; }
        public int WinnerScore { get; set; }
        public double WinnerRating { get; set; }
        public double WinnerDelta { get; set; }
    }
}
