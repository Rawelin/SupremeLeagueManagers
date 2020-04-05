using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SupremeLeagueManager.Models.TeamTest
{
    public class MockTeam
    {
        private List<Team> mockTeams = new List<Team>();
        private Team team = new Team();
        private Provider provider;

        public MockTeam()
        {
            CreateMockTeamsList();
        }

        public MockTeam(Provider provider)
        {
            this.provider = provider;
            CreateMockTeamsList();
            SetTeam();
        }

        public List<Team> GetTeams()
        {
            return mockTeams;
        }

        public Team GetTeam()
        {
            return team;
        }

        private void SetTeam()
        {
             team = mockTeams.Where(t => t.TeamId == provider.TeamId)
                             .FirstOrDefault();
        }

        private void CreateMockTeamsList()
        {
            Team realMadrid = new Team();

            realMadrid.TeamId = 1;
            realMadrid.Name = "Real";
            realMadrid.City = "Madrid";
            realMadrid.Emblems = "real.png";
            realMadrid.Players = new MockPlayer().GetPlayers()[0];
            realMadrid.SetTeamPower();

            Team barcelona = new Team();

            barcelona.TeamId = 2;
            barcelona.Name = "FC";
            barcelona.City = "Barcelona";
            barcelona.Emblems = "barcelona.png";
            barcelona.Players = new MockPlayer().GetPlayers()[1];
            barcelona.SetTeamPower();

            Team arsenal = new Team();

            arsenal.TeamId = 3;
            arsenal.Name = "Arsenal";
            arsenal.City = "London";
            arsenal.Emblems = "arsenal.png";
            arsenal.Players = new MockPlayer().GetPlayers()[0];
            arsenal.SetTeamPower();

            Team atletico = new Team();

            atletico.TeamId = 4;
            atletico.Name = "Atletico";
            atletico.City = "Madrid";
            atletico.Emblems = "atletico.png";
            atletico.Players = new MockPlayer().GetPlayers()[1];
            atletico.SetTeamPower();

            Team bayern = new Team();

            bayern.TeamId = 5;
            bayern.Name = "Bayern";
            bayern.City = "Monachium";
            bayern.Emblems = "bayern.png";
            bayern.Players = new MockPlayer().GetPlayers()[0];
            bayern.SetTeamPower();

            Team benfica = new Team();

            benfica.TeamId = 6;
            benfica.Name = "Benfica";
            benfica.City = "Lisabona";
            benfica.Emblems = "benfica.png";
            benfica.Players = new MockPlayer().GetPlayers()[1];
            benfica.SetTeamPower();

            Team borussia = new Team();

            borussia.TeamId = 7;
            borussia.Name = "Borussia";
            borussia.City = "Dortmund";
            borussia.Emblems = "borussia.png";
            borussia.Players = new MockPlayer().GetPlayers()[1];
            borussia.SetTeamPower();

            Team chelsea = new Team();

            chelsea.TeamId = 8;
            chelsea.Name = "Chelsea";
            chelsea.City = "London";
            chelsea.Emblems = "chelsea.png";
            chelsea.Players = new MockPlayer().GetPlayers()[1];
            chelsea.SetTeamPower();

            mockTeams.Add(realMadrid);
            mockTeams.Add(barcelona);
            mockTeams.Add(arsenal);
            mockTeams.Add(atletico);
            mockTeams.Add(bayern);
            mockTeams.Add(benfica);
            mockTeams.Add(borussia);
            mockTeams.Add(chelsea);

            mockTeams = mockTeams.OrderBy(s => Guid.NewGuid()).ToList();
        }
    }
}