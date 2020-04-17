using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using SupremeLeagueManager.Models.Admin;

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
    }
}