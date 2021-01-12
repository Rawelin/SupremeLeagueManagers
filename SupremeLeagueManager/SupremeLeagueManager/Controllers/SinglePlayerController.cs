using SupremeLeagueManager.Models;
using SupremeLeagueManager.Models.SinglePlayer;
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
            return View(new SinglePlayerData().GetData());
        }

        public ActionResult UpdateDB(Provider provider)
        {
            return Json(new UpdateDB(provider).GetData(), JsonRequestBehavior.AllowGet);
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
            return PartialView(new Table().GetTable());
        }

        public ActionResult _Statistic()
        {
            return PartialView();
        }

        public ActionResult _Fixture()
        {
            return PartialView(new Fixture().GetFixtures());
        }
    }
}