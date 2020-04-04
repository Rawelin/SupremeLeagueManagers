using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SupremeLeagueManager.Models
{
    public class Team
    {
        public string Name { get; set; }
        public string City { get; set; }
        public List<Player> Players { get; set; }

        private double teamPower;
        
        public Team() { }

        public double GetTeamPower()
        {
            return teamPower;
        }

        public string GetFullName()
        {
            return Name + " " + City;
        }

        public void SetTeamPower()
        {
            double playersSkils = 0;

            foreach (var player in Players)
            {
                playersSkils += player.GetAverageSkils();
            }

            teamPower = playersSkils / 11;
        }
    }
}