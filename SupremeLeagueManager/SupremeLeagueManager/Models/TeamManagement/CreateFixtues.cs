using SupremeLeagueManager.Models.Global;
using SupremeLeagueManager.Models.League;
using SupremeLeagueManager.Models.TeamTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SupremeLeagueManager.Models.TeamManagement
{
    public class CreateFixtues
    {
        private TeamManagementVM TeamManagementVM = new TeamManagementVM();

        public CreateFixtues()
        {
            SetFixtures();
        }

        public TeamManagementVM GetFixtures()
        {
            return TeamManagementVM;
        }

        private void SetFixtures()
        {
            try
            {
                TeamManagementVM.AllFixtures = new Fixture().GetAllFixtures();
            }
            catch (Exception ex)
            {
                ErrorHandling.InsertError("TeamManagement", "CreateFixtues", "SetFixtures", ex);
            }
        }
    }
}