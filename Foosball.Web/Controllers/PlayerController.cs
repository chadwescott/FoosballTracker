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
            return RedirectToAction("Standings", "Player");
        }

        public ActionResult Standings()
        {
            return View();
        }
    }
}