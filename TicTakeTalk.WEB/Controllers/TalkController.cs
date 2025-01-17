using Microsoft.AspNetCore.Mvc;

namespace TicTakeTalk.Web.Controllers
{
    public class TalkController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult TalkSubBar()
        {
            return View();
        }
    }
}
