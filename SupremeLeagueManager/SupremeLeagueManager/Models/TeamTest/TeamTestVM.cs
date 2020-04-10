using SupremeLeagueManager.Models.Global_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SupremeLeagueManager.Models.TeamTest
{
    public class TeamTestVM
    {
        public List<Team> Teams = new List<Team>();
        public Team Team = new Team();
        public string ErrorMessage;
    }
}