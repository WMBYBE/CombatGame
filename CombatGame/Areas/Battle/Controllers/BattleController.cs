using CombatGame.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            ViewBag.teams = context.Teams.OrderBy(c => c.Name).ToList(); //Sends the lsit of forums to the index page so that you can see them all

            return View();
        }
        public IActionResult Result(int Team1ID, int Team2ID)
        {
            var team1 = context.Teams.Find(Team1ID);
            var team2 = context.Teams.Find(Team2ID);
            if (DateTime.Now.Ticks % 2 == 1)
            {
                ViewBag.Winner = team1.Name;

                team1.TotalWins += 1;

                var user1 = context.Users.FirstOrDefault(u => u.UserId == team1.UserId);
                if (user1 != null)
                {
                    user1.TotalWins += 1;
                }
            else
            {
                ViewBag.Winner = team2.Name;

                team2.TotalWins += 1;

                var user2 = context.Users.FirstOrDefault(u => u.UserId == team2.UserId);
                if (user2 != null)
                {
                    user2.TotalWins += 1;
                }
            }
            }
            context.SaveChanges();
            return View();
        }
    }
}
