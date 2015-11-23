using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using CooperVision.Web.Grid;
using Foosball.Domain.Model;

namespace Foosball.Web.Models
{
    public class GamesViewModel : IGame, IViewModel
    {
        public Guid Id { get; set; }

        public DateTime Timestamp { get; set; }

        public string GridTimestamp { get { return Timestamp.ToString(Constants.GridDateFormat); } }

        public bool ShowSummary { get; set; }
        public string Summary
        {
            get
            {
                return string.Format("{0} def. {1} ({2} - {3})", Winner.DisplayName, Loser.DisplayName, WinnerScore,
                    LoserScore);
            }
        }

        [DisplayName("Winner")]
        public IPlayer Winner { get; set; }

        [DisplayName("Winner Score")]
        [Range(typeof(int), "0", "10")]
        public int WinnerScore { get; set; }

        [DisplayName("Winner Rating")]
        public double WinnerRating { get; set; }

        [DisplayName("Winner Delta")]
        public double WinnerDelta { get; set; }

        [DisplayName("Loser")]
        public IPlayer Loser { get; set; }

        [DisplayName("Loser Score")]
        [Range(typeof(int), "0", "10")]
        public int LoserScore { get; set; }

        [DisplayName("Loser Rating")]
        public double LoserRating { get; set; }

        [DisplayName("Loser Delta")]
        public double LoserDelta { get; set; }

        [DisplayName("Players")]
        public SelectList Players { get; set; }
        public Guid WinnerId { get; set; }
        public Guid LoserId { get; set; }
        public string recid { get { return Id.ToString(); } set { Id = new Guid(value); } }
    }
}