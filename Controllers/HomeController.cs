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
		
		[HttpGet("/tamagotchis")]
        public ActionResult Tamagotchis()
        {
            List<Tamagotchi> t = Tamagotchi.GetAllTamagotchi();
            return View(t);
        }

        [HttpGet("/tamagotchis/{id}")]
        public ActionResult GetTamagotchi(int id)
        {
            Tamagotchi t = Tamagotchi.Find(id);
			return View("GetTamagotchi", t);
        }
		
		[HttpPost("/tamagotchi/update/{id}")]
        public ActionResult UpdateTamagotchi(int id, string Command)
        {
            Tamagotchi t = Tamagotchi.Find(id);
			if(Command == "feed")
			{
				t.Feed();
			}
			else if(Command == "play")
			{
				t.Play();
			}
			else if(Command == "sleep")
			{
				t.Sleep();
			}
			else if(Command == "timepass")
			{
				t.Timepass();
			}
			else
			{
				throw new Exception("Invalid action: " + Command);
			}
			
			return View("GetTamagotchi", t);
        }

        [HttpPost("/tamagotchi/create")]
        public ActionResult CreatePlace()
        {
            Tamagotchi t = new Tamagotchi(Request.Form["name"], int.Parse(Request.Form["food"]), int.Parse(Request.Form["attention"]), int.Parse(Request.Form["rest"]));

            return View("GetTamagotchi", t);
        }
    }
}
