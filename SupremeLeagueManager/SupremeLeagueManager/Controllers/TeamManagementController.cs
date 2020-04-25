using SupremeLeagueManager.Models.TeamTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SupremeLeagueManager.Controllers
{
    public class TeamManagementController : Controller
    {
        // GET: TeamTest
        public ActionResult TeamManagement()
        {
            return View(new CreateTeams().GetTeams());
        }

        public ActionResult _TeamManagement(Provider provider)
        {
            return PartialView(new TeamMenagement(provider).GetTeam());
        }

        public ActionResult _TeamSquad(Provider provider)
        {
            return PartialView(new TeamMenagement(provider).GetTeam());
        }

        public ActionResult _TeamSkills(Provider provider)
        {
            return PartialView(new TeamMenagement(provider).GetTeam());
        }

        public ActionResult _PlayerSkills()
        {
            return PartialView();
        }

        public ActionResult _FormationPitch(Provider provider)
        {
            return PartialView(new TeamMenagement(provider).GetTeam());
        }
    }
}