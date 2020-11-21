using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SupremeLeagueManager.Models.SinglePlayer.Models
{
    public class FixtureVM
    {
        public string ErrorMessage { get; set; }
        public List<List<Tuple<Team, Team>>> AllFixtures { get; set; }
    }
}