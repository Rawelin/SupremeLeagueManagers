using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SupremeLeagueManager.Models;

namespace SLMTest
{
    [TestClass]
    public class PlayerTest
    {
        [TestMethod]
        public void GoalKeeperSkillTests()
        {
            Player szczesny = new Player();

            szczesny.Name = "Maciej";
            szczesny.Surname = "Szczęsny";
            szczesny.Position = Player.PlayerPosition.GoalKeeper;
            szczesny.Speed = 80;
            szczesny.Acceleration = 80;
            szczesny.Reflex = 90;
            szczesny.Diving = 94;
            szczesny.SetAverageSkills();

            Assert.AreEqual(szczesny.GetAverageSkils(), 86);
        }

        [TestMethod]
        public void DefenderSkillTests()
        {
            Player ramos = new Player();

            ramos.Name = "Sergio";
            ramos.Surname = "Ramos";
            ramos.Position = Player.PlayerPosition.Defender;
            ramos.Speed = 86;
            ramos.Acceleration = 86;
            ramos.Tackling = 96;
            ramos.Covering = 96;
            ramos.Heading = 98;
            ramos.SetAverageSkills();

            Assert.AreEqual(ramos.GetAverageSkils(), 92);
        }

        [TestMethod]
        public void MidfielderSkillTests()
        {
            Player deBruyne = new Player();

            deBruyne.Name = "Kevin";
            deBruyne.Surname = "De Bruyne";
            deBruyne.Position = Player.PlayerPosition.Midfielder;
            deBruyne.Speed = 88;
            deBruyne.Acceleration = 90;
            deBruyne.ShortPassAccuracy = 94;
            deBruyne.LongPassAccuracy = 92;
            deBruyne.SetAverageSkills();

            Assert.AreEqual(deBruyne.GetAverageSkils(), 91);
        }

        [TestMethod]
        public void AtackerSkillTests()
        {
            Player ronaldo = new Player();

            ronaldo.Name = "Christiano";
            ronaldo.Surname = "Ronaldo";
            ronaldo.Position = Player.PlayerPosition.Attacker;
            ronaldo.Speed = 94;
            ronaldo.Acceleration = 94;
            ronaldo.ShotPower = 98;
            ronaldo.ShotAccuracy = 94;
            ronaldo.SetAverageSkills();

            Assert.AreEqual(ronaldo.GetAverageSkils(), 95);
        }
    }
}
