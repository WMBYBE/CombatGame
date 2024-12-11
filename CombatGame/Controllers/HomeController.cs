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

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(User user)
        {
            string name = user.UserName;
            IQueryable<User> query = context.Users.Where(m => m.UserName == name);
            //List<User> identification = query.ToList();
            var foundUser = query.FirstOrDefault();

            string password = user.Password;
            IQueryable<User> passwords = context.Users.Where(m => m.Password == password);
            var foundPassword = passwords.FirstOrDefault();

            if ((foundUser != null) && foundPassword != null)
            {


                HttpContext.Session.SetInt32("id", foundUser.UserId);
                ViewBag.id = foundUser.UserId;

                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.error = "Invalid username or password";
                return View();
            }

        }
        public IActionResult Leaderboard()
        {
            return View();
        }

    }
}
