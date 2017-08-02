using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using Game.Models;

namespace Game.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }
    }
}
