using SupremeLeagueManager.Models.Home;
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
            return View(new Data().GetData());
        }

        public ActionResult SetSinglePlayer(Provider provider)
        {
            return Json(new SinglePlayerGame(provider).GetStatus(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult _SinglePlayer()
        {
            return PartialView(new CreateTeams().GetTeams());
        }

        public ActionResult _Options()
        {
            return PartialView(new Data().GetData());
        }
    }
}