using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using SupremeLeagueManager.Models.SignIn;

using SupremeLeagueManager.Models.Global;

namespace SupremeLeagueManager.Controllers
{
    public class SignInController : Controller
    {
        // GET: SignIn
        public ActionResult SignIn()
        {
            SignInVM signInVM = new SignInVM();

            return View(signInVM);
        }

        public ActionResult Registration(string password, int idUser)
        {
            SignInVM signInVM = new SignInVM();

            return View(signInVM);
        }

        public ActionResult UserRegistration(UsersM usersM)
        {
            int r = usersM.UserRegistration();

            return Json(r, JsonRequestBehavior.AllowGet);
        }
    }
}