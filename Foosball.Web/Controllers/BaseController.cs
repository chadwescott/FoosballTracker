using System.Web.Mvc;
using Foosball.Business;

namespace Foosball.Web.Controllers
{
    public abstract class BaseController : Controller
    {
        protected readonly FoosballCommands Commands = new FoosballCommands();
    }
}