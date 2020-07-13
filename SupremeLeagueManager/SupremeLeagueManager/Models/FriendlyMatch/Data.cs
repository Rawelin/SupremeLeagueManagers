using SupremeLeagueManager.Models.Match;
using SupremeLeagueManager.Models.TeamManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SupremeLeagueManager.Models.FriendlyMatch
{
    public class Data
    {
        private FriendlyMatchVM FriendlyMatch = new FriendlyMatchVM();

        public Data()
        {
            SetData();
        }

        public FriendlyMatchVM GetData()
        {
            return FriendlyMatch;
        }

        private void SetData()
        {
            try
            {
                FriendlyMatch.Teams = CRUD.GetTeamsPlayers();
                FriendlyMatch.MatchStatistics = new MatchStatistics();
            }
            catch (Exception ex)
            {
                FriendlyMatch.ErrorMessage = ex.ToString();
            }
        }
    }
}