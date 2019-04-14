using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Foosball.Repository.Test.Command
{
    [TestClass]
    public class GetGamesTest : CommandTest
    {
        [TestMethod]
        public void GetGamesValidTest()
        {
            var games = Commands.GetGames().ToList();
            Assert.IsNotNull(games);
            Assert.IsNotNull(games.First().Winner);
            Assert.IsNotNull(games.First().Loser);
        }
    }
}
