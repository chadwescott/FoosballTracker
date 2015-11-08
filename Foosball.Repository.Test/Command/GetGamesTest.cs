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
            Assert.IsTrue(games.First().Player1 != null);
            Assert.IsTrue(games.First().Player2 != null);
        }
    }
}
