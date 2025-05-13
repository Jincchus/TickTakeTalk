using Microsoft.AspNetCore.Mvc;

namespace TicTakeTalk.Web.Controllers
{
    public class AlertController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Detail()
        {
            return View();
        }

        public IActionResult AlertSubBar()
        {
            return View();
        }
    }
}
