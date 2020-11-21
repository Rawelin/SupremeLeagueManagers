using SupremeLeagueManager.Models.Global;
using SupremeLeagueManager.Models.TeamManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SupremeLeagueManager.Models.Home
{
    public class Data
    {
        private HomeVM HomeVM = new HomeVM();

        public Data()
        {
            SetData();
        }

        public HomeVM GetData()
        {
            return HomeVM;
        }

        public void SetData()
        {
            try
            {
                HomeVM.Teams = CRUD.GetTeamsPlayers();
                HomeVM.Status = new SinglePlayerGame(true).GetGameStatus();
            }
            catch (Exception ex)
            {
                ErrorHandling.InsertError("Home", "Data", "SetData", ex);
                HomeVM.ErrorMessage = ex.ToString();
            }
        }
    }
}