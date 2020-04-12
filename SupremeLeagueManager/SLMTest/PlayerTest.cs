using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SupremeLeagueManager.Models;
using SupremeLeagueManager.Models.TeamTest;

namespace SLMTest
{
    [TestClass]
    public class PlayerTest
    {
        Team RealMadrid;

        public PlayerTest()
        {
            CreateTestTeam();
        }

        [TestMethod]
        public void GKSkillsTest()
        {
            Player Courtois = RealMadrid.Players[0];
            Assert.AreEqual(Courtois.GetAverageSkils(), 88.6, 0.1);
        }

        [TestMethod]
        public void LBRBSkillsTest()
        {
            Player Marcelo = RealMadrid.Players[1];
            Assert.AreEqual(Marcelo.GetAverageSkils(), 83.8, 0.1);
        }

        [TestMethod]
        public void CBSkillsTest()
        {
            Player Ramos = RealMadrid.Players[2];
            Assert.AreEqual(Ramos.GetAverageSkils(), 93.1, 0.1);
        }

        [TestMethod]
        public void DMSkillsTest()
        {
            Player Casemiro = RealMadrid.Players[5];
            Assert.AreEqual(Casemiro.GetAverageSkils(), 84.8, 0.1);
        }

        [TestMethod]
        public void CMSkillsTest()
        {
            Player Modric = RealMadrid.Players[7];
            Assert.AreEqual(Modric.GetAverageSkils(), 90.8, 0.1);
        }

        [TestMethod]
        public void LWRWSkillsTest()
        {
            Player Hazard = RealMadrid.Players[8];
            Assert.AreEqual(Hazard.GetAverageSkils(), 90.3, 0.1);
        }

        [TestMethod]
        public void CFSkillsTest()
        {
            Player Benzema = RealMadrid.Players[10];
            Assert.AreEqual(Benzema.GetAverageSkils(), 88.3, 0.1);
        }

        [TestMethod]
        public void AMSkillsTest()
        {
            Player Benzema = RealMadrid.Players[11];
            Assert.AreEqual(Benzema.GetAverageSkils(), 88.6, 0.1);
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
