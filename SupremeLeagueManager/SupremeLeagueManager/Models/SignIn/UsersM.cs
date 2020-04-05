using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SupremeLeagueManager.Models.SignIn
{
    public class UsersM
    {
        public int IdUser { get; set; }
        public string eMail { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime LastLoginDate { get; set; }
        public int AccountActivated { get; set; }
        public int Active { get; set; }
    }
}