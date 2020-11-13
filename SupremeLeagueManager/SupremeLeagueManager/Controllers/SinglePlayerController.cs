using SupremeLeagueManager.Models;
using SupremeLeagueManager.Models.TeamTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SupremeLeagueManager.Controllers
{
    public class SinglePlayerController : Controller
    {
        // GET: SinglePlayer
        public ActionResult SinglePlayer(int id)
        {
            return View(new CreateTeams().GetTeams());
        }

        public ActionResult _Squad()
        {
            return PartialView();
        }

        public ActionResult _Training()
        {
            return PartialView();
        }

        public ActionResult _Finance()
        {
            return PartialView();
        }

        public ActionResult _Calendar()
        {
            return PartialView();
        }

        public ActionResult _Table()
        {
            return PartialView();
        }

        public ActionResult _Statistic()
        {
            return PartialView();
        }

        public ActionResult _Fixture()
        {
            return PartialView();
        }
    }
}