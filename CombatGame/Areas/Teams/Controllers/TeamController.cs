using CombatGame.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

namespace CombatGame.Areas.Teams.Controllers
{
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
    }
}
