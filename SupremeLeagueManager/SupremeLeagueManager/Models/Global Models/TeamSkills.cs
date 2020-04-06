using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SupremeLeagueManager.Models.Global_Models
{
    public static class TeamSkills
    {
        public static double TeamGoalKeeper(List<Player> Players)
        {
            double value = PlayerSkills.Compute(Players[0], Player.PlayerPosition.GK);

            return value;
        }

        public static double TeamDefence(List<Player> Players)
        {
            // TO DO implement formation class to calculate team defence
            double value = 0;

            return value;
        }

        public static double TeamMidfield(List<Player> Players)
        {
            // TO DO implement formation class to calculate team midfield
            double value = 0;

            return value / 11;
        }

        public static double TeamAttack(List<Player> Players)
        {
            // TO DO implement formation class to calculate team attack
            double value = 0;

            return value / 11;
        }

        public static double TeamSpeed(List<Player> Players)
        {
            double value = Players.Select(p => p.Speed)
                                  .Take(11)
                                  .Sum();

            return value / 11;
        }

        public static double TeamTechnique(List<Player> Players)
        {
            double value = Players.Select(p => p.Technique)
                                  .Take(11)
                                  .Sum();

            return value / 11;
        }

        public static double TeamOverall(List<Player> Players)
        {
            double value  = Players.Select(p => p.GetAverageSkils())
                                   .Take(11)
                                   .Sum();

            return value / 11;
        }
    }
}