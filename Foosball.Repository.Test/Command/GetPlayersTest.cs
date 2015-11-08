using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Foosball.Repository.Test.Command
{
    [TestClass]
    public class GetPlayersTest : CommandTest
    {
        [TestMethod]
        public void ValidTest()
        {
            var actual = Commands.GetPlayers();
            Assert.AreEqual(2, actual.Count());
        }
    }
}
