using SupremeLeagueManager.Models.Global;
using SupremeLeagueManager.Models.Home;
using SupremeLeagueManager.Models.SignIn;
using SupremeLeagueManager.Models.SinglePlayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CRUD = SupremeLeagueManager.Models.TeamManagement.CRUD;

namespace SupremeLeagueManager.Models.SinglePlayer
{
    public class SinglePlayerData
    {
        private SinglePlayerVM SinglePlayerVM = new SinglePlayerVM();

        public SinglePlayerData()
        {
            SetData();
        }

        public SinglePlayerVM GetData()
        {
            return SinglePlayerVM;
        }

        private void SetData()
        {
            try
            {
                SinglePlayerVM.Teams = CRUD.GetAllTeamsSinglePlayer();
                SinglePlayerVM.SinglePlayer = new SinglePlayerGame().GetSinglePlayer();
                SinglePlayerVM.Table = CRUD.GetTeamsSinglePlayer(UserContext.GetUser().IdUser)
                                           .OrderByDescending(t => t.Points)
                                           .ThenByDescending(t => t.GoalsFor - t.GoalsAgainst)
                                           .ThenByDescending(t => t.GoalsFor)
                                           .ThenByDescending(t => t.Won)
                                           .ToList();
                SinglePlayerVM.User = UserContext.GetUser();
            }
            catch (Exception ex)
            {
                ErrorHandling.InsertError("SinglePlayer", "SinglePlayerData", "SetData", ex);
            }
        }
    }
}