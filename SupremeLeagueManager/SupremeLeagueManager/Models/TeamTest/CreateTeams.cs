using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SupremeLeagueManager.Models.TeamTest
{
    public class CreateTeams
    {
        private TeamTestVM TeamTestVM = new TeamTestVM();

        public CreateTeams()
        {
            SetTeams();
        }

        public TeamTestVM GetTeams()
        {
            return TeamTestVM;
        }
        private void SetTeams()
        {
            Team realMadrid = new Team();
            List<Player> players = new List<Player>();

            players = new MockPlayer().GetPlayers();

            realMadrid.Name = "Real";
            realMadrid.City = "Madrid";
            realMadrid.Players = players;

            realMadrid.SetTeamPower();

            TeamTestVM.Teams.Add(realMadrid);

        }
    }
}