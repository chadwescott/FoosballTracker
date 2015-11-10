using System.Linq;
using System.Web.Mvc;
using Foosball.Web.Models;

namespace Foosball.Web.Controllers
{
    public class GameController : BaseController
    {
        public ActionResult Log()
        {
            return View();
        }

        public ActionResult Add()
        {
            var players = Commands.GetPlayers().ToList();
            var selectItems =
                players.Select(
                    p =>
                        new SelectListItem
                        {
                            Text = string.Format("{0} {1}", p.FirstName, p.LastName),
                            Value = p.Id.ToString()
                        });

            var model = new GameViewModel
            {
                Winner = players.Single(p => p.FirstName == "Chad"),
                Loser = players.Single(p => p.FirstName == "Nancy"),
                WinnerScore = 10,
                LoserScore = 0,
                Players = new SelectList(selectItems, "Value", "Text")
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult Add(GameViewModel game)
        {
            game.Winner = new PlayerViewModel { Id = game.WinnerId };
            game.Loser = new PlayerViewModel { Id = game.LoserId };
            game.Id = Commands.SaveGame(game).Id;
            return RedirectToAction("Standings", "Player");
        }
    }
}