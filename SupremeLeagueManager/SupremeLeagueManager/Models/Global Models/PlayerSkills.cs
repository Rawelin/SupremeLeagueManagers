using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static SupremeLeagueManager.Models.Player;

namespace SupremeLeagueManager.Models.Global_Models
{
    public static class PlayerSkills
    {
        public static double Compute(Player player, PlayerPosition position)
        {
            double averageSkills = 0;

            switch (position)
            {
                case PlayerPosition.GK:
                    averageSkills = (player.GoalKeeper + player.Diving + player.Handling + player.Reflex + player.Speed + player.Acceleration) / 6;
                    break;
                case PlayerPosition.CB:
                    averageSkills = (player.Defence + player.Tackling + player.Covering + player.Heading + player.Speed + player.Acceleration) / 6;
                    break;
                case PlayerPosition.LB:
                case PlayerPosition.RB:
                    averageSkills = (player.Defence + player.Attack + player.Technique + player.LongPassAccuracy + player.Speed + player.Acceleration) / 6;
                    break;
                case PlayerPosition.DM:
                    averageSkills = (player.Defence + player.Midfield + player.Tackling + player.Covering + player.Speed + player.Acceleration) / 6;
                    break;
                case PlayerPosition.CM:
                    averageSkills = (player.Midfield + player.ShortPassAccuracy + player.LongPassAccuracy + player.Technique + 
                                     player.Speed + player.Acceleration) / 6;
                    break;
                case PlayerPosition.LM:
                case PlayerPosition.RM:
                    averageSkills = (player.Midfield + player.Attack + player.Technique + player.LongPassAccuracy + player.Speed + player.Acceleration) / 6;
                    break;
                case PlayerPosition.AM:
                    averageSkills = (player.Midfield + player.Attack + player.Technique + player.ShortPassAccuracy +
                                     player.LongPassAccuracy + player.ShotPower + player.ShotAccuracy + player.Speed + player.Acceleration) / 9;
                    break;
                case PlayerPosition.LW:
                case PlayerPosition.RW:
                    averageSkills = (player.Attack + player.Technique + player.ShortPassAccuracy + player.LongPassAccuracy + player.ShotPower +
                                     player.ShotAccuracy + player.Speed + player.Acceleration) / 8;
                    break;
                case PlayerPosition.SS:
                    averageSkills = (player.Midfield + player.Attack + player.Technique + player.ShortPassAccuracy + player.ShotPower + 
                                     player.ShotAccuracy + player.Speed + player.Acceleration) / 8;
                    break;
                case PlayerPosition.CF:
                    averageSkills = (player.Attack + player.Technique + player.ShortPassAccuracy + player.ShotPower + player.ShotAccuracy + 
                                     player.Speed + player.Acceleration) / 7;
                    break;
                default:
                    break;
            }

            return averageSkills;
        }
    }
}