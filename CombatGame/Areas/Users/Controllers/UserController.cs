using CombatGame.Models;
using Microsoft.AspNetCore.Mvc;

namespace RedditClone.Areas.Users.Controllers
{
    [Area("Users")]
    public class UserController : Controller
    {
        private CharacterDbContext context { get; set; }

        public UserController(CharacterDbContext ctx)
        {
            context = ctx;
        }
        public ActionResult index(int id)
        {
            var teams = context.Teams
                    .Where(p => p.User.UserId == id)
                    .OrderBy(p => p.TeamId);

            ViewBag.User = context.Users.Find(id);
            return View(teams.ToList());
        }

    }
}
