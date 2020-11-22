
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SupremeLeagueManager.Models.SignIn
{
    public static class UserContext
    {
        public static UsersM GetUser()
        {
            HttpContext context = HttpContext.Current;
            UsersM user = (UsersM)context.Session["User"];

            return user;
        }
    }
}