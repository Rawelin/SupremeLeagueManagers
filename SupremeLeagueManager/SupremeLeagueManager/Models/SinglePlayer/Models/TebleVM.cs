using SupremeLeagueManager.Models.TeamManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SupremeLeagueManager.Models.SinglePlayer.Models
{
    public class TebleVM
    {
        public List<TeamSinglePlayerM> Table { get; set; }
        public string ErrorMessage { get; set; }

    }
}