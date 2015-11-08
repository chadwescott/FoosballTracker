using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using Foosball.Domain.Model;

namespace Foosball.Web.Models
{
    public class GameViewModel : IGame
    {
        public Guid Id { get; set; }
        public DateTime Timestamp { get; set; }

        [DisplayName("Player 2")]
        public IPlayer Player1 { get; set; }

        [DisplayName("Player 2")]
        public IPlayer Player2 { get; set; }

        [DisplayName("Player 1 Score")]
        [Range(typeof(int), "0", "10")]
        public int Player1Score { get; set; }

        [DisplayName("Player 2 Score")]
        [Range(typeof(int), "0", "10")]
        public int Player2Score { get; set; }
        public SelectList Players { get; set; }
        public Guid Player1Id { get; set; }
        public Guid Player2Id { get; set; }
    }
}