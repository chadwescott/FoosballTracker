using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Foosball.Domain.Model;

namespace Foosball.Repository.Model
{
    [Table("Games")]
    internal class Game : IGame
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public Guid Id { get; set; }

        [Column("Timestamp")]
        public DateTime Timestamp { get; set; }

        [Column("Player1Id")]
        public Guid Player1Id { get; set; }

        public IPlayer Player1 { get { return DbPlayer1; } }

        [ForeignKey("Player1Id")]
        public Player DbPlayer1 { get; set; }

        [Column("Player2Id")]
        public Guid Player2Id { get; set; }

        public IPlayer Player2 { get { return DbPlayer2; } }

        [ForeignKey("Player2Id")]
        public Player DbPlayer2 { get; set; }

        [Column("Player1Score")]
        public int Player1Score { get; set; }

        [Column("Player2Score")]
        public int Player2Score { get; set; }
    }
}
