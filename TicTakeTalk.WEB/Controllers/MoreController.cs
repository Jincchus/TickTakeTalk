using Microsoft.AspNetCore.Mvc;

namespace TicTakeTalk.Web.Controllers
{
    public class MoreController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
