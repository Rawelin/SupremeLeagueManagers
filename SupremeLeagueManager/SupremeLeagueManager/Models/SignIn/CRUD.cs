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

            using (SLMContextDB.SLMEntities Ctx = new SLMContextDB.SLMEntities())
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

        public static int AddNewUser(UsersM usersM)
        {
            int IdUser = 0;

            using (SLMEntities CtxSLM = new SLMEntities())
            {
                try
                {
                    Users users = new Users()
                    {
                        
                        eMail = usersM.eMail,
                        Password = usersM.Password.GetHashCode().ToString(),
                        FirstName = "John",
                        LastName = "Doe",
                        AccountActivated = 0,
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
