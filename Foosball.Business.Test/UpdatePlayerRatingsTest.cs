using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Foosball.Business.Test
{
    [TestClass]
    public class UpdatePlayerRatingsTest
    {
        private readonly FoosballCommands _commands = new FoosballCommands();

        [TestMethod]
        public void CalculateRatings()
        {
            var games = _commands.GetGames().OrderBy(g => g.Timestamp);
            foreach (var game in games)
                _commands.UpdatePlayerRating(game);
        }
    }
}
