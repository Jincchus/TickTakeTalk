using Microsoft.AspNetCore.Mvc;

namespace TicTakeTalk.Web.Controllers
{
    public class CalendarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
