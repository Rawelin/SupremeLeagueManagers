using SupremeLeagueManager.Models.TeamTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SupremeLeagueManager.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Home()
        {
            return View(new CreateTeams().GetTeams());
        }

        public ActionResult _SinglePlayer()
        {
            return View(new CreateTeams().GetTeams());
        }
    }
}