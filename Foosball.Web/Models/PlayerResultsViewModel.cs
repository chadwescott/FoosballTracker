using System;
using Foosball.Domain.Model;

namespace Foosball.Web.Models
{
    public class PlayerResultsViewModel : GameViewModel
    {

        public Guid PlayerId { get; set; }

        private double PlayerScore { get { return PlayerId == WinnerId ? WinnerScore : LoserScore; } }

        public IPlayer Opponent { get { return PlayerId == WinnerId ? Loser : Winner; } }

        private double OpponentScore { get { return PlayerId == WinnerId ? LoserScore : WinnerScore; } }

        public string Score
        {
            get { return string.Format("{0} - {1}", PlayerScore, OpponentScore); }
        }

        public double Rating { get { return PlayerId == WinnerId ? WinnerRating : LoserRating; } }

        public double RatingDelta { get { return PlayerId == WinnerId ? WinnerDelta : LoserDelta; } }

        public string Result { get { return PlayerId == WinnerId ? "W" : "L"; } }
    }
}