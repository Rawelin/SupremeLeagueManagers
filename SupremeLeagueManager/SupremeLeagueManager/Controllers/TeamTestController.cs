using SupremeLeagueManager.Models.TeamTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SupremeLeagueManager.Controllers
{
    public class TeamTestController : Controller
    {
        // GET: TeamTest
        public ActionResult TeamTest()
        {
            return View(new CreateTeams().GetTeams());
        }

        public ActionResult _TeamSquad(Provider provider)
        {
            return PartialView(new CreateTeam(provider).GetTeam());
        }
    }
}