using SupremeLeagueManager.Models.Global_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SupremeLeagueManager.Models.TeamTest
{
    public class TeamManagementVM
    {
        public List<Team> Teams = new List<Team>();
        public Team Team = new Team();
        public List<Tuple<Team, Team>> AllPairs { get; set; }
        public List<List<Tuple<Team, Team>>> AllFixtures { get; set; }
        public string ErrorMessage;
    }
}