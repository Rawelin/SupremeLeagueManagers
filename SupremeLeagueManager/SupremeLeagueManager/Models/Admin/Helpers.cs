using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SupremeLeagueManager.Models.Admin
{
    public static class Helpers
    {
        public static int GetAge(DateTime birthDate)
        {
            int r = 0;

            while(birthDate <= DateTime.Now)
            {
                r++;
                birthDate = birthDate.AddYears(1);
            }

            return r;
        }
    }
}