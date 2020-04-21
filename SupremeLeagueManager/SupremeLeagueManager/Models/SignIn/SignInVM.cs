using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SupremeLeagueManager.Models.SignIn
{
    public class SignInVM
    {
        public UsersM UsersM = new UsersM();

        public SignInVM()
        {

        }

        public SignInVM(UsersM users)
        {
            this.UsersM = users;
        }
    }
}