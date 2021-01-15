using SLMContextDB;
using SupremeLeagueManager.Models.Global;
using SupremeLeagueManager.Models.TeamManagement;
using SupremeLeagueManager.Models.TeamTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SupremeLeagueManager.Models.SinglePlayer
{
    public class UpdateDB
    {
        private Provider provider;

        public UpdateDB(Provider provider)
        {
            this.provider = provider;
            Menu();
        }

        public Provider GetData()
        {
            return provider;
        }

        private void SwapPlayer()
        {
            try
            {
                using (Entities slmCtx = new Entities())
                {
                    CRUD.SwaPlayersSP(provider.PlayerOne, provider.PlayerTwo);
                }
            }
            catch (Exception ex)
            {
                provider.ErrorMessage = ex.ToString();
                ErrorHandling.InsertError("SinglePlayer", "UpdateDB", "SwaPlayers", ex);
            }
        }

        private void ChangeFormation()
        {
            try
            {
                using (Entities slmCtx = new Entities())
                {
                    CRUD.ChangeFormationSP(provider);
                }
            }
            catch (Exception ex)
            {
                provider.ErrorMessage = ex.ToString();
                ErrorHandling.InsertError("SinglePlayer", "UpdateDB", "ChangeFormation", ex);
            }
        }

        private void ChangeTeamSettings()
        {
            try
            {
                using (Entities slmCtx = new Entities())
                {
                    CRUD.ChangeTeamSettingsSP(provider);
                }
            }
            catch (Exception ex)
            {
                provider.ErrorMessage = ex.ToString();
                ErrorHandling.InsertError("SinglePlayer", "UpdateDB", "ChangeTeamSettings", ex);
            }
        }

        private void DayIncrementation()
        {
            try
            {
                using (Entities slmCtx = new Entities())
                {
                    CRUD.DayIncrementation(provider);
                }
            }
            catch (Exception ex)
            {
                provider.ErrorMessage = ex.ToString();
                ErrorHandling.InsertError("SinglePlayer", "UpdateDB", "DayIncrementation", ex);
            }
        }

        private void Menu()
        {
            switch (provider.Status)
            {
                case 1:
                    SwapPlayer();
                    break;
                case 2:
                    ChangeFormation();
                    break;
                case 3:
                    ChangeTeamSettings();
                    break;
                case 4:
                    DayIncrementation();
                    break;
            }
        }
    }
}