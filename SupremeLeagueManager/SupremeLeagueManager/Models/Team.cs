using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace SupremeLeagueManager.Models
{
    public class Team
    {
        public int TeamId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Emblems { get; set; }
        public List<Player> Players { get; set; }

        private double teamPower;
        
        public Team()
        {
            Players = new List<Player>();
        }

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
            double playersSkils = Players.Select(p => p.GetAverageSkils())
                                         .Take(11)
                                         .Sum();

            teamPower = playersSkils / 11;
        }
    }
}