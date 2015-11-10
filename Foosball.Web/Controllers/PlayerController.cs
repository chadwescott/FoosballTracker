using System.Web.Mvc;

namespace Foosball.Web.Controllers
{
    public class PlayerController : BaseController
    {
        public ActionResult Add()
        {
            return View();
        }
        public ActionResult Standings()
        {
            return View();
        }
    }
}