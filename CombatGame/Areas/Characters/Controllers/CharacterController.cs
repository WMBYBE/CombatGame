using CombatGame.Models;
using Microsoft.AspNetCore.Mvc;

namespace CombatGame.Areas.Characters.Controllers
{
    [Area("Characters")]
    public class CharacterController : Controller
    {
        private CharacterDbContext context { get; set; }

        public CharacterController(CharacterDbContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            var characters = context.Characters.OrderBy(c => c.Name).ToList(); //Sends the lsit of forums to the index page so that you can see them all

            return View(characters);
        }
        public IActionResult viewCharacter(int id)
        {
            Character character = context.Characters.Find(id);

            return View(character);
        }
        [HttpGet]
        public IActionResult createCharacter()
        {
            ViewBag.Action = "create";
            ViewBag.Moves = context.Moves.OrderBy(g => g.Name).ToList();
            ViewBag.id = HttpContext.Session.GetInt32("id");
            return View("createCharacter", new Character());
        }
        [HttpPost]
        public IActionResult createCharacter(Character character)
        {
            context.Characters.Add(character);
            context.SaveChanges();
            return RedirectToAction("Index", "Home", new { area = "" });

        }
    }
}
