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
            arsenal.Name = "Arsenal";
            arsenal.City = "London";
            arsenal.Emblems = "arsenal.png";
            arsenal.Players = new MockPlayer().GetPlayers()[0];
            arsenal.SetTeamPower();

            Team atletico = new Team();

            atletico.TeamId = 2;
            atletico.Name = "Atletico";
            atletico.City = "Madrid";
            atletico.Emblems = "atletico.png";
            atletico.Players = new MockPlayer().GetPlayers()[1];
            atletico.SetTeamPower();

            Team barcelona = new Team();

            barcelona.TeamId = 3;
            barcelona.Name = "FC";
            barcelona.City = "Barcelona";
            barcelona.Emblems = "barcelona.png";
            barcelona.Players = new MockPlayer().GetPlayers()[1];
            barcelona.SetTeamPower();

            Team bayern = new Team();

            bayern.TeamId = 4;
            bayern.Name = "Bayern";
            bayern.City = "Monachium";
            bayern.Emblems = "bayern.png";
            bayern.Players = new MockPlayer().GetPlayers()[0];
            bayern.SetTeamPower();

            Team benfica = new Team();

            benfica.TeamId = 5;
            benfica.Name = "Benfica";
            benfica.City = "Lisabona";
            benfica.Emblems = "benfica.png";
            benfica.Players = new MockPlayer().GetPlayers()[1];
            benfica.SetTeamPower();

            Team borussia = new Team();

            borussia.TeamId = 6;
            borussia.Name = "Borussia";
            borussia.City = "Dortmund";
            borussia.Emblems = "borussia.png";
            borussia.Players = new MockPlayer().GetPlayers()[0];
            borussia.SetTeamPower();

            Team chelsea = new Team();

            chelsea.TeamId = 7;
            chelsea.Name = "Chelsea";
            chelsea.City = "London";
            chelsea.Emblems = "chelsea.png";
            chelsea.Players = new MockPlayer().GetPlayers()[1];
            chelsea.SetTeamPower();

            Team juventus = new Team();

            juventus.TeamId = 8;
            juventus.Name = "Juventus";
            juventus.City = "Torino";
            juventus.Emblems = "juventus.png";
            juventus.Players = new MockPlayer().GetPlayers()[0];
            juventus.SetTeamPower();

            Team manchesterCity = new Team();

            manchesterCity.TeamId = 9;
            manchesterCity.Name = "Manchester";
            manchesterCity.City = "City";
            manchesterCity.Emblems = "manchester city.png";
            manchesterCity.Players = new MockPlayer().GetPlayers()[1];
            manchesterCity.SetTeamPower();

            Team manchesterUnited = new Team();

            manchesterUnited.TeamId = 10;
            manchesterUnited.Name = "Manchester";
            manchesterUnited.City = "United";
            manchesterUnited.Emblems = "manu.png";
            manchesterUnited.Players = new MockPlayer().GetPlayers()[0];
            manchesterUnited.SetTeamPower();

            Team napoli = new Team();

            napoli.TeamId = 11;
            napoli.Name = "FC";
            napoli.City = "Napoli";
            napoli.Emblems = "napoli.png";
            napoli.Players = new MockPlayer().GetPlayers()[1];
            napoli.SetTeamPower();

            Team porto = new Team();

            porto.TeamId = 12;
            porto.Name = "FC";
            porto.City = "Porto";
            porto.Emblems = "porto.png";
            porto.Players = new MockPlayer().GetPlayers()[1];
            porto.SetTeamPower();

            Team psg = new Team();

            psg.TeamId = 13;
            psg.Name = "PSG";
            psg.City = "Paris";
            psg.Emblems = "psg.png";
            psg.Players = new MockPlayer().GetPlayers()[1];
            psg.SetTeamPower();

            Team realMadrid = new Team();

            realMadrid.TeamId = 14;
            realMadrid.Name = "Real";
            realMadrid.City = "Madrid";
            realMadrid.Emblems = "real.png";
            realMadrid.Players = new MockPlayer().GetPlayers()[0];
            realMadrid.SetTeamPower();

            Team schalke = new Team();

            schalke.TeamId = 15;
            schalke.Name = "Schalke 04";
            schalke.City = "Gelsenkirchen";
            schalke.Emblems = "schalke.png";
            schalke.Players = new MockPlayer().GetPlayers()[1];
            schalke.SetTeamPower();

            Team sevilla = new Team();

            sevilla.TeamId = 16;
            sevilla.Name = "FC";
            sevilla.City = "Sevilla";
            sevilla.Emblems = "sevilla.png";
            sevilla.Players = new MockPlayer().GetPlayers()[0];
            sevilla.SetTeamPower();

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