using SLMContextDB;
using SupremeLeagueManager.Models.TeamTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SupremeLeagueManager.Models.TeamManagement
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
                    CRUD.SwaPlayers(provider.PlayerOne, provider.PlayerTwo);
                }
            }
            catch (Exception ex)
            {
                provider.ErrorMessage = ex.ToString();
            }
        }

        private void ChangeFormation()
        {
            try
            {
                using (Entities slmCtx = new Entities())
                {
                    CRUD.ChangeFormation(provider);
                }
            }
            catch (Exception ex)
            {
                provider.ErrorMessage = ex.ToString();
            }
        }

        private void Menu()
        {
            switch(provider.Status)
            {
                case 1:
                    SwapPlayer();
                    break;
                case 2:
                    ChangeFormation();
                    break;
            }
        }
    }
}