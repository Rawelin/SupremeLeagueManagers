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
            SetData();
        }

        public Provider GetData()
        {
            return provider;
        }

        private void SetData()
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
    }
}