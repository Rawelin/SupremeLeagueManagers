using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using SLMContextDB;

namespace SupremeLeagueManager.Models.Admin
{
    public class dictTeamsPlayersM : dictTeamsPlayers
    {
        public string CountryCode { get; set; }
        public string PositionShortName { get; set; }
        public string PositionActualyShortName { get; set; }
        public int Age { get; set; }
    }
}