using System;

namespace Foosball.Domain.Model
{
    public class Game : IGame
    {
        public  Guid Id { get; set; }
        public  DateTime Timestamp { get; set; }
        public  IPlayer Loser { get; set; }
        public  int LoserScore { get; set; }
        public  double LoserRating { get; set; }
        public  double LoserDelta { get; set; }
        public  IPlayer Winner { get; set; }
        public  int WinnerScore { get; set; }
        public  double WinnerRating { get; set; }
        public  double WinnerDelta { get; set; }
    }
}
