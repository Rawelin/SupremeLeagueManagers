using SupremeLeagueManager.Models.Global_Models;
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
            Team arsenal = new Team();

            arsenal.TeamId = 1;
            arsenal.Formation = 2;
            arsenal.Name = "Arsenal";
            arsenal.City = "London";
            arsenal.Players = new MockPlayer().GetPlayers()[0];
            arsenal.SetTeamSkills();

            Team atletico = new Team();

            atletico.TeamId = 2;
            atletico.Formation = 1;
            atletico.Name = "Atletico";
            atletico.City = "Madrid";
            atletico.Players = new MockPlayer().GetPlayers()[1];
            atletico.SetTeamSkills();

            Team barcelona = new Team();

            barcelona.TeamId = 3;
            barcelona.Formation = 2;
            barcelona.Name = "FC";
            barcelona.City = "Barcelona";
            barcelona.Players = new MockPlayer().GetPlayers()[1];
            barcelona.SetTeamSkills();

            Team bayern = new Team();

            bayern.TeamId = 4;
            bayern.Formation = 2;
            bayern.Name = "Bayern";
            bayern.City = "Munich";
            bayern.Players = new MockPlayer().GetPlayers()[0];
            bayern.SetTeamSkills();

            Team benfica = new Team();

            benfica.TeamId = 5;
            benfica.Formation = 2;
            benfica.Name = "Benfica";
            benfica.City = "Lisabona";   
            benfica.Players = new MockPlayer().GetPlayers()[1];
            benfica.SetTeamSkills();

            Team borussia = new Team();

            borussia.TeamId = 6;
            borussia.Formation = 2;
            borussia.Name = "Borussia";
            borussia.City = "Dortmund";
            borussia.Players = new MockPlayer().GetPlayers()[0];
            borussia.SetTeamSkills();

            Team chelsea = new Team();

            chelsea.TeamId = 7;
            chelsea.Formation = 1;
            chelsea.Name = "Chelsea";
            chelsea.City = "London";
            chelsea.Players = new MockPlayer().GetPlayers()[1];
            chelsea.SetTeamSkills();

            Team juventus = new Team();

            juventus.TeamId = 8;
            juventus.Formation = 3;
            juventus.Name = "Juventus";
            juventus.City = "Torino";
            juventus.Players = new MockPlayer().GetPlayers()[0];
            juventus.SetTeamSkills();

            Team manchesterCity = new Team();

            manchesterCity.TeamId = 9;
            manchesterCity.Formation = 2;
            manchesterCity.Name = "Manchester";
            manchesterCity.City = "City";
            manchesterCity.Players = new MockPlayer().GetPlayers()[1];
            manchesterCity.SetTeamSkills();

            Team manchesterUnited = new Team();

            manchesterUnited.TeamId = 10;
            manchesterUnited.Formation = 2;
            manchesterUnited.Name = "Manchester";
            manchesterUnited.City = "United";
            manchesterUnited.Players = new MockPlayer().GetPlayers()[0];
            manchesterUnited.SetTeamSkills();

            Team napoli = new Team();

            napoli.TeamId = 11;
            napoli.Formation = 2;
            napoli.Name = "FC";
            napoli.City = "Napoli";
            napoli.Players = new MockPlayer().GetPlayers()[1];
            napoli.SetTeamSkills();

            Team porto = new Team();

            porto.TeamId = 12;
            porto.Formation = 4;
            porto.Name = "FC";
            porto.City = "Porto";
            porto.Players = new MockPlayer().GetPlayers()[1];
            porto.SetTeamSkills();

            Team psg = new Team();

            psg.TeamId = 13;
            psg.Formation = 2;
            psg.Name = "PSG";
            psg.City = "Paris";
            psg.Players = new MockPlayer().GetPlayers()[1];
            psg.SetTeamSkills();

            Team realMadrid = new Team();

            realMadrid.TeamId = 14;
            realMadrid.Formation = 2;
            realMadrid.Name = "Real";
            realMadrid.City = "Madrid";
            realMadrid.Players = new MockPlayer().GetPlayers()[0];
            realMadrid.SetTeamSkills();

            Team schalke = new Team();

            schalke.TeamId = 15;
            schalke.Formation = 1;
            schalke.Name = "Schalke 04";
            schalke.City = "Gelsenkirchen";
            schalke.Players = new MockPlayer().GetPlayers()[1];
            schalke.SetTeamSkills();

            Team sevilla = new Team();

            sevilla.TeamId = 16;
            sevilla.Formation = 4;
            sevilla.Name = "FC";
            sevilla.City = "Sevilla";
            sevilla.Players = new MockPlayer().GetPlayers()[0];
            sevilla.SetTeamSkills();

            mockTeams.Add(arsenal);
            mockTeams.Add(atletico);
            mockTeams.Add(barcelona);
            mockTeams.Add(bayern);
            mockTeams.Add(benfica);
            mockTeams.Add(borussia);
            mockTeams.Add(chelsea);
            mockTeams.Add(juventus);
            mockTeams.Add(manchesterCity);
            mockTeams.Add(manchesterUnited);
            mockTeams.Add(napoli);
            mockTeams.Add(porto);
            mockTeams.Add(psg);
            mockTeams.Add(realMadrid);
            mockTeams.Add(schalke);
            mockTeams.Add(sevilla);

            //mockTeams = mockTeams.OrderBy(s => Guid.NewGuid()).ToList();
        }
    }
}