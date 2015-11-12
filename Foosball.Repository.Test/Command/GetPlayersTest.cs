using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Foosball.Repository.Test.Command
{
    [TestClass]
    public class GetPlayersTest : CommandTest
    {
        [TestMethod]
        public void GetPlayersValidTest()
        {
            var actual = Commands.GetPlayers();
            Assert.AreEqual(2, actual.Count());
        }
    }
}
