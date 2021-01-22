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

                SinglePlayerVM.AllFixtures = new League.Fixture().GetAllFixtures();
                SinglePlayerVM.Teams = CRUD.GetAllTeamsSinglePlayer();
                SinglePlayerVM.SinglePlayer = new SinglePlayerGame().GetSinglePlayer();
                SinglePlayerVM.Table = new Table().GetTable();
                SinglePlayerVM.User = UserContext.GetUser();
            }
            catch (Exception ex)
            {
                ErrorHandling.InsertError("SinglePlayer", "SinglePlayerData", "SetData", ex);
            }
        }
    }
}