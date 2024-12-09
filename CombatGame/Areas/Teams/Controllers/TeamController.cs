using CombatGame.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

namespace CombatGame.Areas.Teams.Controllers
{
    [Area("Teams")]
    public class TeamController : Controller
    {
        private CharacterDbContext context { get; set; }

        public TeamController(CharacterDbContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index(int id)
        {
            Team team = context.Teams.Find(id);

            List<Character> characters;
            {
                characters = context.Characters
                    .Where(p => p.teamId == id)
                    .OrderBy(p => p.Name).ToList();
            }

            ViewBag.Characters = characters;

            return View(team);
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Action = "Crete";
            ViewBag.Moves = context.Moves.OrderBy(g => g.Name).ToList();
            ViewBag.id = HttpContext.Session.GetInt32("id");
            return View("Create", new Team());
        }
        [HttpPost]
        public IActionResult Create(Team team)
        {
                context.Teams.Add(team);
                context.SaveChanges();
                return RedirectToAction("Index", "Home", new { area = "" });
            
        }
    }
}
