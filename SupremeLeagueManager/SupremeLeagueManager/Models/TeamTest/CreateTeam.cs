using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SupremeLeagueManager.Models.TeamTest
{
    public class CreateTeam
    {
        private TeamTestVM TeamTestVM = new TeamTestVM();
        public Provider provider;

        public CreateTeam(Provider provider)
        {
            this.provider = provider;
            SetTeam();
        }

        public TeamTestVM GetTeam()
        {
            return TeamTestVM;
        }

        private void SetTeam()
        {
            try
            {
                TeamTestVM.Team = new MockTeam(provider).GetTeam();
            }
            catch (Exception ex)
            {
                TeamTestVM.ErrorMessage = ex.ToString();
            }
        }
    }
}