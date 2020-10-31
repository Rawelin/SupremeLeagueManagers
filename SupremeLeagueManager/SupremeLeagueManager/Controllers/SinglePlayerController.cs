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
        public ActionResult SinglePlayer()
        {
            return View(new CreateTeams().GetTeams());
        }
    }
}