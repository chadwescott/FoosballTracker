using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using CooperVision.Web.Grid;
using Foosball.Domain.Model;

namespace Foosball.Web.Models
{
    public class GameViewModel : IGame, IViewModel
    {
        public Guid Id { get; set; }
        public DateTime Timestamp { get; set; }

        [DisplayName("Winner")]
        public IPlayer Winner { get; set; }

        [DisplayName("Winner Score")]
        [Range(typeof(int), "0", "10")]
        public int WinnerScore { get; set; }

        [DisplayName("Loser")]
        public IPlayer Loser { get; set; }

        [DisplayName("Loser Score")]
        [Range(typeof(int), "0", "10")]
        public int LoserScore { get; set; }
        public SelectList Players { get; set; }
        public Guid WinnerId { get; set; }
        public Guid LoserId { get; set; }
        public string recid { get { return Id.ToString(); } set { Id = new Guid(value); } }
    }
}