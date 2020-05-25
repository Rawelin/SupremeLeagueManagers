using SupremeLeagueManager.Models.Global_Models;
using SupremeLeagueManager.Models.TeamManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SupremeLeagueManager.Models.TeamTest
{
    public class TeamMenagement
    {
        private TeamManagementVM TeamTestVM = new TeamManagementVM();
        private Team Team;
        private Provider provider;

        public TeamMenagement(Provider provider)
        {
            this.provider = provider;
            SetTeam();
        }

        public TeamManagementVM GetTeam()
        {
            return TeamTestVM;
        }

        private void SetTeam()
        {
            try
            {
                switch (provider.Status)
                {
                    case 1: // Get team
                        Team = CRUD.GetTeamPlayers(provider.TeamId);
                        //Team = new MockTeam(provider).GetTeam();
                        break;
                    case 2: // Change formation
                        Team = new MockTeam(provider).GetTeam();
                        Team.Formation = (int)provider.FormationId;
                        Team.SetTeamSkills();
                        break;
                    case 3: // Change player
                        Team = new MockTeam(provider).GetTeam();
                        Team.ChangePlayer(provider.Player1, provider.Player2);
                        Team.Formation = (int)provider.FormationId;
                        Team.SetTeamSkills();
                        break;
                }
            }
            catch (Exception ex)
            {
                TeamTestVM.ErrorMessage = ex.ToString();
            }
            TeamTestVM.Team = Team;
        }
    }
}