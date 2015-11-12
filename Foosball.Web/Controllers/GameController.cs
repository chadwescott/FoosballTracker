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
                            Text = p.UserName,
                            Value = p.Id.ToString()
                        });

            var model = new GameViewModel
            {
                WinnerScore = 10,
                LoserScore = 0,
                Players = new SelectList(selectItems, "Value", "Text")
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult Add(GameViewModel game)
        {
            game.Winner = Commands.GetPlayerById(game.WinnerId);
            game.Loser = Commands.GetPlayerById(game.LoserId);
            game.Id = Commands.SaveGame(game).Id;
            return RedirectToAction("Standings", "Player");
        }
    }
}