using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Foosball.Repository.Test.Command
{
    [TestClass]
    public class GetPlayerGameLogsByIdTest : CommandTest
    {
        [TestMethod]
        public void GetPlayerGameLogsByIdValidTest()
        {
            var playerId = new Guid("7CA7900C-AB85-E511-ACA1-C8A8A3194C25");
            var playerRecords = Commands.GetPlayerGameLogsByPlayerId(playerId);
            Assert.IsNotNull(playerRecords);
        }
    }
}
