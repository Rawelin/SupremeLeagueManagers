using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using SupremeLeagueManager.Models.SignIn;

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

        public ActionResult _SignIn()
        {
            UsersM users = new UsersM();

            return PartialView(users);
        }

        public ActionResult _Registration()
        {
            UsersM users = new UsersM();

            return PartialView(users);
        }
    }
}