using SupremeLeagueManager.Models.FriendlyMatch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SupremeLeagueManager.Controllers
{
    public class FriendlyMatchController : Controller
    {
        // GET: FriendlyMatch
        public ActionResult FriendlyMatch()
        {
            return View(new Data().GetData());
        }

        public ActionResult _TeamSelection(Provider provider)
        {
            return PartialView();
        }

        public ActionResult _SquadSelection(Provider provider)
        {
            return PartialView();
        }

        public ActionResult _MatchArena(Provider provider)
        {
            return PartialView(new MatchTeams(provider).GetData());
        }
    }
}