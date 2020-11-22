using SupremeLeagueManager.Models.Global;
using SupremeLeagueManager.Models.Home;
using SupremeLeagueManager.Models.SinglePlayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SupremeLeagueManager.Models.SinglePlayer
{
    public class Fixture
    {
        private FixtureVM FixtureVM = new FixtureVM();

        public Fixture()
        {
            SetFixtures();
        }

        public FixtureVM GetFixtures()
        {
            return FixtureVM;
        }

        public void SetFixtures()
        {
            try
            {
                FixtureVM.AllFixtures = new League.Fixture().GetAllFixtures();
                FixtureVM.SinglePlayer = new SinglePlayerGame().GetSinglePlayer();
            }
            catch (Exception ex)
            {
                ErrorHandling.InsertError("SinglePlayer", "Fixture", "SetFixtures", ex);
            }
        }
    }
}