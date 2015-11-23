using System;
using Foosball.Domain.Model;

namespace Foosball.Web.Models
{
    public class PlayerResultsViewModel : GamesViewModel
    {

        public Guid PlayerId { get; set; }

        public IPlayer Opponent { get { return PlayerId == WinnerId ? Loser : Winner; } }

        public string Score
        {
            get { return string.Format("({0} - {1})", WinnerScore, LoserScore); }
        }

        public double Rating { get { return PlayerId == WinnerId ? WinnerRating : LoserRating; } }

        public double RatingDelta { get { return PlayerId == WinnerId ? WinnerDelta : LoserDelta; } }

        public string Result { get { return PlayerId == WinnerId ? "W" : "L"; } }
    }
}