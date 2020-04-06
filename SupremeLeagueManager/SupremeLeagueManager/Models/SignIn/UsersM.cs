using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using SLMContextDB;

namespace SupremeLeagueManager.Models.SignIn
{
    public class UsersM : Users
    {
        public int UserRegistration()
        {
            int result = 0;

            if (CRUD.EmailExist(this.eMail))
            {
                CRUD.AddNewUser(this);
            }

            return result;
        }
    }
}