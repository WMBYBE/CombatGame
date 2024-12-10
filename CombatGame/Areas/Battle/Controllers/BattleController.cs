using CombatGame.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CombatGame.Areas.Battle.Controllers
{
    [Area("Battle")]
    public class BattleController : Controller
    {
        private CharacterDbContext context { get; set; }

        public BattleController(CharacterDbContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            var teams = context.Teams.OrderBy(c => c.Name).ToList(); //Sends the lsit of forums to the index page so that you can see them all

            return View(teams);
        }
        public IActionResult Result(int team1, int team2)
        {
            if (DateTime.Now.Ticks % 2 == 1)
            {
                ViewBag.Win = team1;
            }
            else
            {
                ViewBag.Win = team2;
            }
            return View();
        }
    }
}
