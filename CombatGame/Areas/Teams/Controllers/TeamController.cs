using CombatGame.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using System.Diagnostics.Metrics;

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
                    .OrderBy(p => p.Name).ToList();
            }
            List<TeamMembers> members;
            {
                members = context.TeamMembers
                    .Where(p => p.TeamId == id).ToList();
            }
            ViewBag.Characters = characters;
            ViewBag.members = members.Count();

            return View(team);
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Action = "Create";
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
