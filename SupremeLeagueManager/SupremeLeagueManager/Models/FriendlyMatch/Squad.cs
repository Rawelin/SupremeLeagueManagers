using SupremeLeagueManager.Models.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SupremeLeagueManager.Models.FriendlyMatch
{
    public class Squad
    {
        private FriendlyMatchVM friendlyMatchVM = new FriendlyMatchVM();
        private Provider provider = new Provider();

        public Squad(Provider provider)
        {
            this.provider = provider;
            SetSquad();
        }

        public FriendlyMatchVM GetSquad()
        {
            return friendlyMatchVM;
        }

        private void SetSquad()
        {
            try
            {
                friendlyMatchVM.HomeTeam = provider.HomeTeam;
                friendlyMatchVM.AwayTeam = provider.AwayTeam;
            }
            catch (Exception ex)
            {
                ErrorHandling.InsertError("FriendlyMatch", "Squad", "SetSquad", ex);
                provider.ErrorMessage = ex.ToString();
            }
        }
    }
}