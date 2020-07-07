using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SupremeLeagueManager.Models.FriendlyMatch
{
    public class MatchTeams
    {
        private FriendlyMatchVM FriendlyMatchVM = new FriendlyMatchVM();
        private Provider provider = new Provider();


        public MatchTeams(Provider provider)
        {
            this.provider = provider;
            SetData();
        }

        public FriendlyMatchVM GetData()
        {
            return FriendlyMatchVM;
        }

        private void SetData()
        {
            try
            {
                FriendlyMatchVM.HomeTeam = provider.HomeTeam; 
                FriendlyMatchVM.AwayTeam = provider.AwayTeam; 
            }
            catch (Exception ex)
            {
                FriendlyMatchVM.ErrorMessage = ex.ToString();
            }
        }
    }
}