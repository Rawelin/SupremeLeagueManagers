using SupremeLeagueManager.Models;
using SupremeLeagueManager.Models.TeamTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLMTest
{
    class TeamTest
    {
        Team RealMadrid;

        public TeamTest()
        {
            CreateTestTeam();
        }

        private void CreateTestTeam()
        {
            RealMadrid = new Team();

            RealMadrid.TeamId = 14;
            RealMadrid.Formation = 2;
            RealMadrid.Name = "Real";
            RealMadrid.City = "Madrid";
            RealMadrid.Players = new MockPlayer().GetPlayers()[0];
            RealMadrid.SetTeamSkills();
        }
    }
}
