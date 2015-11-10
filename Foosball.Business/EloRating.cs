using System;

namespace Foosball.Business
{
    public class EloRating
    {
        public double Point1 { get; set; }
        public double Point2 { get; set; }

        public double FinalResult1 { get; set; }
        public double FinalResult2 { get; set; }

        private const int KFactor = 400;

        public EloRating(double currentRating1, double currentRating2, double score1, double score2)
        {
            /*
            double CurrentR1 = 1500.0;
            double CurrentR2 = 1500.0;
 
            double Score1 = 20.0;
            double Score2 = 10;
            */

            double E = 0;

            if (score1 != score2)
            {
                if (score1 > score2)
                {
                    E = 120 - Math.Round(1 / (1 + Math.Pow(10, ((currentRating2 - currentRating1) / KFactor))) * 120);
                    FinalResult1 = currentRating1 + E;
                    FinalResult2 = currentRating2 - E;
                }
                else
                {
                    E = 120 - Math.Round(1 / (1 + Math.Pow(10, ((currentRating1 - currentRating2) / KFactor))) * 120);
                    FinalResult1 = currentRating1 - E;
                    FinalResult2 = currentRating2 + E;
                }
            }
            else
            {
                if (currentRating1 == currentRating2)
                {
                    FinalResult1 = currentRating1;
                    FinalResult2 = currentRating2;
                }
                else
                {
                    if (currentRating1 > currentRating2)
                    {
                        E = (120 - Math.Round(1 / (1 + Math.Pow(10, ((currentRating1 - currentRating2) / KFactor))) * 120)) - (120 - Math.Round(1 / (1 + Math.Pow(10, ((currentRating2 - currentRating1) / KFactor))) * 120));
                        FinalResult1 = currentRating1 - E;
                        FinalResult2 = currentRating2 + E;
                    }
                    else
                    {
                        E = (120 - Math.Round(1 / (1 + Math.Pow(10, ((currentRating2 - currentRating1) / KFactor))) * 120)) - (120 - Math.Round(1 / (1 + Math.Pow(10, ((currentRating1 - currentRating2) / KFactor))) * 120));
                        FinalResult1 = currentRating1 + E;
                        FinalResult2 = currentRating2 - E;
                    }
                }
            }
            Point1 = FinalResult1 - currentRating1;
            Point2 = FinalResult2 - currentRating2;
        }
    }
}
