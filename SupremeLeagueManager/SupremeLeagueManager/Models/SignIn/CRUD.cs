using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Diagnostics;

using SLMContextDB;

namespace SupremeLeagueManager.Models.SignIn
{
    public static class CRUD
    {
        public static bool EmailExist(string email)
        {
            bool r = false;
            string t = string.Empty;

            using (Entities Ctx = new Entities())
            {
                try
                {
                    t = Ctx.Users.Where(a => a.eMail == email).Select(a => a.eMail).FirstOrDefault();

                    if (!(t is null) || t.Length > 0)
                    {
                        r = true;
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.ToString());
                }
            }

            return r;
        }

        internal static Users GetUserById(int idUser)
        {
            Users users = new Users();

            try
            {
                using (Entities Ctx = new Entities())
                {
                    users = Ctx.Users.Find(idUser);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }

            return users;
        }

        public static int AddNewUser(UsersM usersM)
        {
            int IdUser = 0;

            using (Entities CtxSLM = new Entities())
            {
                try
                {
                    Users users = new Users()
                    {

                        eMail = usersM.eMail,
                        Password = usersM.Password,
                        FirstName = "John",
                        LastName = "Doe",
                        AccountActivated = 0,
                        LastLoginDate = DateTime.Now,
                        Active = 0
                    };

                    CtxSLM.Users.Add(users);
                    CtxSLM.SaveChanges();

                    IdUser = users.IdUser;
}
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.ToString());
                }
            }

            return IdUser;
        }
    }
}
