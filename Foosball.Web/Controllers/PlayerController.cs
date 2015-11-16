using System;
using System.Linq;
using System.Web.Mvc;
using Foosball.Web.Models;

namespace Foosball.Web.Controllers
{
    public class PlayerController : BaseController
    {
        public ActionResult Add()
        {
            var model = new PlayerViewModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Add(PlayerViewModel player)
        {
            Commands.AddPlayer(player);
            return RedirectToAction("Standings");
        }

        public ActionResult Details(string id)
        {
            Guid playerId;
            if (!Guid.TryParse(id, out playerId))
                return RedirectToAction("Standings");
            var gameLogs = Commands.GetPlayerGameLogsByPlayerId(playerId);
            var model = new PlayerDetailsViewModel(gameLogs.ToList()) { Player = Commands.GetPlayerById(playerId) };

            return View(model);
        }

        public ActionResult Standings()
        {
            return View();
        }
    }
}