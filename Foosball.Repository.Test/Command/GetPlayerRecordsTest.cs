using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Foosball.Repository.Test.Command
{
    [TestClass]
    public class GetPlayerRecordsTest : CommandTest
    {
        [TestMethod]
        public void GetPlayerRecordsValidTest()
        {
            var playerRecords = Commands.GetPlayerRecords().ToList();
            Assert.IsNotNull(playerRecords);
        }
    }
}
