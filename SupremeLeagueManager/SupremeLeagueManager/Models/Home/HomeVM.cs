using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SupremeLeagueManager.Models.Home
{
    public class HomeVM
    {
        public List<Team> Teams = new List<Team>();
        public int Status { get; set; }
        public string ErrorMessage { get; set; }
    }
}