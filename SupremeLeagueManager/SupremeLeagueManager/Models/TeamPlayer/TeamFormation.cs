using SupremeLeagueManager.Models.Global_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SupremeLeagueManager.Models
{
    public static class TeamFormation
    {
        // 1. 4-4-2
        // 2. 4-3-3
        // 3. 4.5.1
        // 4. 3.5.2

        public static double SetDefence(Team Team)
        {
            double defence = 0;

            switch (Team.Formation)
            {
                case 1:
                case 2:
                case 3:
                    defence = (Team.Players.Select(d => d.Defence).Skip(1).Take(4).Sum()) / 4;
                    break;
                case 4:
                    defence = (Team.Players.Select(d => d.Defence).Skip(1).Take(3).Sum()) / 3;
                    break;
            }

            return defence;
        }

        public static double SetMidfield(Team Team)
        {
            double midfield = 0;

            switch (Team.Formation)
            {
                case 1:
                    midfield = (Team.Players.Select(d => d.Midfield).Skip(5).Take(4).Sum()) / 4;
                    break;
                case 2:
                    midfield = (Team.Players.Select(d => d.Midfield).Skip(5).Take(3).Sum()) / 3;
                    break;
                case 3:
                    midfield = (Team.Players.Select(d => d.Midfield).Skip(5).Take(5).Sum()) / 5;
                    break;
                case 4:
                    midfield = (Team.Players.Select(d => d.Midfield).Skip(4).Take(5).Sum()) / 5;
                    break;
            }

            return midfield;
        }

        public static double SetAttack(Team Team)
        {
            double attack = 0;

            switch (Team.Formation)
            {
                case 1:
                    attack = (Team.Players.Select(d => d.Attack).Skip(9).Take(2).Sum()) / 2;
                    break;
                case 2:
                    attack = (Team.Players.Select(d => d.Attack).Skip(8).Take(3).Sum()) / 3;
                    break;
                case 3:
                    attack = (Team.Players.Select(d => d.Attack).Skip(10).Take(1).Sum());
                    break;
                case 4:
                    attack = (Team.Players.Select(d => d.Attack).Skip(9).Take(2).Sum()) / 2;
                    break;
            }

            return attack;
        }
    }
}