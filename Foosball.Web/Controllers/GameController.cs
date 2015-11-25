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
            var model = new GameViewModel
            {
                WinnerScore = 10,
                LoserScore = 0,
                Players = GetPlayersSelectList()
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult Add(GameViewModel game)
        {
            game.Winner = Commands.GetPlayerById(game.WinnerId);
            game.Loser = Commands.GetPlayerById(game.LoserId);
            game.Id = Commands.SaveGame(game).Id;
            game.Players = GetPlayersSelectList();
            game.ShowSummary = true;
            return View(game);
        }

        private SelectList GetPlayersSelectList()
        {
            var players = Commands.GetPlayers().OrderBy(p => p.DisplayName).ToList();
            var selectItems =
                players.Select(
                    p =>
                        new SelectListItem
                        {
                            Text = p.DisplayName,
                            Value = p.Id.ToString()
                        });
            return new SelectList(selectItems, "Value", "Text");
        }
    }
}