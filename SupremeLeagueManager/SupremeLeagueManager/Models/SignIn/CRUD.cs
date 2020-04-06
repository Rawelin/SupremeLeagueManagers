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
            bool r = true;
            string t = string.Empty;

            using (Entities CtxSLM = new Entities())
            {
                try
                {
                    t = CtxSLM.Users.Where(a => a.eMail == email).Select(a => a.eMail).FirstOrDefault();

                    if(!(t is null) || t.Length > 0)
                    {
                        r = false;
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.ToString());
                }
            }

            return r;
        }

        public static bool AddNewUser(UsersM usersM)
        {
            bool r = false;

            using (Entities CtxSLM = new Entities())
            {
                try
                {
                    Users users = new Users();
                    users = usersM;
                    users.Password = users.Password.GetHashCode().ToString();

                    CtxSLM.Users.Add(users);
                    CtxSLM.SaveChanges();
                }
                catch(Exception ex)
                {
                    Debug.WriteLine(ex.ToString());
                }
            }

            return r;
        }
    }

}