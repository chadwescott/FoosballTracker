using System;
using Foosball.Domain.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Foosball.Repository.Test.Command
{
    [TestClass]
    public class SaveGameTest : CommandTest
    {
        [TestMethod]
        public void InsertTest()
        {
            var game = new Game
            {
                Winner = new Player { Id = new Guid("7CA7900C-AB85-E511-ACA1-C8A8A3194C25") },
                Loser = new Player { Id = new Guid("7DA7900C-AB85-E511-ACA1-C8A8A3194C25") },
                WinnerScore = 10,
                LoserScore = 5
            };
            var actual = Commands.SaveGame(game);
            Assert.AreNotEqual(Guid.Empty, actual.Id);
        }
    }
}
