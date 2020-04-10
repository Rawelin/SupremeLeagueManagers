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

        public ActionResult UserSignIn(UsersM usersM)
        {
            int result = 0;

            UsersM users2  = new UsersM(CRUD.GetUsersByEmail(usersM.eMail));

            PasswordHash passwordHash = new PasswordHash(usersM.Pass);
            usersM.Password = passwordHash.ToArray();

            if (usersM.Password.SequenceEqual(users2.Password))
            {
                result = 1;
            }

            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult UserRegistration(UsersM usersM)
        {
            SignInManagement sign = new SignInManagement(usersM);
            sign.UserRegistration();

            /*
             * 0 - OK
             * 1 - eMail istnieje w bazie danych
             * 2 - Utworzenie konta nie powiodło się.
             * 3 - Błąd podczas próby wysłania maila.
             */

            return Json(sign.GetStatus(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult Confirmation(byte[] password, int idUser)
        {
            SignInManagement sign = new SignInManagement();
            sign.Confirmation(password, idUser);

            return View(sign.GetUsersM());
        }
    }
}