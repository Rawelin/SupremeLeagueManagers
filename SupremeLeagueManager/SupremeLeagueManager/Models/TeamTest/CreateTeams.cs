using SLMContextDB;
using SupremeLeagueManager.Models.Global_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SupremeLeagueManager.Models.TeamTest
{
    public class CreateTeams
    {
        private TeamTestVM TeamTestVM = new TeamTestVM();

        public CreateTeams()
        {
            SetTeams();
        }

        public TeamTestVM GetTeams()
        {
            return TeamTestVM;
        }
        private void SetTeams()
        {
            try
            {
                TeamTestVM.Team = new Team();
                TeamTestVM.Teams.AddRange(new MockTeam().GetTeams());
            }
            catch (Exception ex)
            {
                TeamTestVM.ErrorMessage = ex.ToString();
            }
        }
    }
}