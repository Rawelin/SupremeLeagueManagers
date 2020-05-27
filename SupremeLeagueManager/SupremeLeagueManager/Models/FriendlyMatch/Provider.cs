using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SupremeLeagueManager.Models.FriendlyMatch
{
    public class Provider
    {
        public int HomeTeamId { get; set; } 
        public int AwayTeamId { get; set; } 
        public Team HomeTeam { get; set; }
        public Team AwayTeam { get; set; }
    }
}