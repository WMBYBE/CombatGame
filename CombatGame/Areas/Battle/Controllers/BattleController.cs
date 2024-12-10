﻿using CombatGame.Models;
using Microsoft.AspNetCore.Mvc;
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
            if (DateTime.Now.Ticks % 2 == 1)
            {
                ViewBag.Winner = Team1ID;
            }
            else
            {
                ViewBag.Winner = Team2ID;
            }
            return View();
        }
    }
}