using SupremeLeagueManager.Models.Match;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SupremeLeagueManager.Models.FriendlyMatch
{
    public class FriendlyMatchVM
    {
        public List<Team> Teams { get; set; }
        public Team HomeTeam { get; set; }
        public Team AwayTeam { get; set; }
        public MatchStatistics MatchStatistics {get; set;}
        public string ErrorMessage { get; set; }
    }
}