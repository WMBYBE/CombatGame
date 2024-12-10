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
    }
}
