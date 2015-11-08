using System.Linq;
using System.Web.Mvc;
using Foosball.Web.Models;

namespace Foosball.Web.Controllers
{
    public class GameController : BaseController
    {
        public ActionResult Index()
        {
            var games = Commands.GetGames().OrderByDescending(g => g.Timestamp);
            return View(games);
        }

        public ActionResult Create()
        {
            var players =
                Commands.GetPlayers()
                    .Select(
                        p =>
                            new SelectListItem
                            {
                                Text = string.Format("{0} {1}", p.FirstName, p.LastName),
                                Value = p.Id.ToString()
                            });
            var model = new GameViewModel
            {
                Player1Score = 0,
                Player2Score = 0,
                Players = new SelectList(players, "Value", "Text")
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult Create(GameViewModel game)
        {
            game.Player1 = new PlayerViewModel { Id = game.Player1Id };
            game.Player2 = new PlayerViewModel { Id = game.Player2Id };
            game.Id = Commands.SaveGame(game).Id;
            return RedirectToAction("Index");
        }
    }
}