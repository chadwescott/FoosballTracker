using System;
using Foosball.Domain.Model;
using Foosball.Repository.Test.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Foosball.Repository.Test.Command
{
    [TestClass]
    public class SaveGameTest : CommandTest
    {
        [TestMethod]
        public void InsertTest()
        {
            IGame game = new Game
            {
                Player1 = new Player { Id = new Guid("7CA7900C-AB85-E511-ACA1-C8A8A3194C25") },
                Player2 = new Player { Id = new Guid("7DA7900C-AB85-E511-ACA1-C8A8A3194C25") },
                Player1Score = 10,
                Player2Score = 5
            };
            game = Commands.SaveGame(game);
            Assert.AreNotEqual(Guid.Empty, game.Id);
        }
    }
}
