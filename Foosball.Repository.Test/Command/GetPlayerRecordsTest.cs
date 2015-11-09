using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Foosball.Repository.Test.Command
{
    [TestClass]
    public class GetPlayerRecordsTest : CommandTest
    {
        [TestMethod]
        public void GetGamesValidTest()
        {
            var playerRecords = Commands.GetPlayerRecords().ToList();
            Assert.IsNotNull(playerRecords);
        }
    }
}
