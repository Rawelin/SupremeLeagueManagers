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

        public ActionResult Registration(byte[] password, int idUser)
        {
            UsersM users = new UsersM(idUser, password);
            users.RegistrationConfirmation();

            return View(users);
        }

        public ActionResult UserRegistration(UsersM usersM)
        {
            int r = usersM.UserRegistration();

            return Json(r, JsonRequestBehavior.AllowGet);
        }
    }
}