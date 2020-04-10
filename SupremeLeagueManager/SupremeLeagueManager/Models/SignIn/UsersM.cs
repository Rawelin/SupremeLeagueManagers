using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Diagnostics;

using SLMContextDB;
using SupremeLeagueManager.Models.Global;

namespace SupremeLeagueManager.Models.SignIn
{
    public class UsersM : Users
    {
        public string Pass { get; set; }

        public UsersM()
        {

        }

        public UsersM(Users u)
        {
            IdUser = u.IdUser;
            eMail = u.eMail;
            Password = u.Password;
            FirstName = u.FirstName;
            LastName = u.LastName;
            LastLoginDate = u.LastLoginDate;
            AccountActivated = u.AccountActivated;
            Active = u.Active;         
        }
    }
}