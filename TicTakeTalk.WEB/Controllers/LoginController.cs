﻿using Microsoft.AspNetCore.Mvc;

namespace TicTakeTalk.Web.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
