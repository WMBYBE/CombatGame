using CombatGame.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            List<TeamMembers> members = context.TeamMembers
                    .Where(p => p.TeamId == id)
                    .Include(tm => tm.character)
                    .ToList();

            ViewBag.TeamMembers = members;
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
        [HttpGet]
        public IActionResult Edit(int Id)
        {
            List<Character> characters;
            {
                characters = context.Characters
                    .OrderBy(p => p.Name).ToList();
            }
            var team = context.Teams.Find(Id);
            ViewBag.team = team;
            ViewBag.Characters = characters;
            return View("Edit", new TeamMembers());
        }
        [HttpPost]
        public IActionResult edit(TeamMembers teamMember)
        {
            context.TeamMembers.Add(teamMember);
            context.SaveChanges();
            return RedirectToAction("Index", "Home", new { area = "" });

        }
    }
}
