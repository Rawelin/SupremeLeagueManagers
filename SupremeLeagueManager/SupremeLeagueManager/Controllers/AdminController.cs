using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using SupremeLeagueManager.Models.Admin;
using SupremeLeagueManager.Models.Global;

namespace SupremeLeagueManager.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Admin()
        {
            AdminVM adminVM = new AdminVM();

            return View(adminVM);
        }

        public ActionResult GetTeamPlayers(int IdDictTeams)
        {
            return Json(GlobalCRUD.GetTeamPlayers(IdDictTeams).ToArray(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult AddPlayer(dictTeamsPlayersM teamPlayer)
        {
            int r = CRUD.AddPlayer(teamPlayer);

            return Json(1, JsonRequestBehavior.AllowGet);
        }

        public ActionResult SaveTeamSetting(List<dictTeamsPlayersM> teamsPlayers)
        {
            return Json(CRUD.SaveTeamSetting(teamsPlayers), JsonRequestBehavior.AllowGet);
        }
    }
}