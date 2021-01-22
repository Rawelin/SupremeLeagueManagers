using SupremeLeagueManager.Models.SignIn;
using SupremeLeagueManager.Models.TeamManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SupremeLeagueManager.Models.SinglePlayer.Models
{
    public class SinglePlayerVM
    {
        public string ErrorMessage { get; set; }
        public List<Team> Teams { get; set; }
        public List<TeamSinglePlayerM> Table { get; set; }
        public List<List<Tuple<Team, Team>>> AllFixtures { get; set; }
        public SinglePlayerM SinglePlayer { get; set; }
        public UsersM User { get; set; }
    }
}