using CombatGame.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using System.Diagnostics;

namespace CombatGame.Controllers
{
    public class HomeController : Controller
    {
        private CharacterDbContext context { get; set; }

        public HomeController(CharacterDbContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            var teams = context.Teams.OrderBy(c => c.Name).ToList(); //Sends the lsit of forums to the index page so that you can see them all

            return View(teams);
        }

    }
}
