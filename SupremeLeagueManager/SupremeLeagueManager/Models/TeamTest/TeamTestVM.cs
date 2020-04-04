using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SupremeLeagueManager.Models.TeamTest
{
    public class TeamTestVM
    {
        public List<Team> Teams { get; set; }

        public TeamTestVM()
        {
            Teams = new List<Team>();
        }
    }
}