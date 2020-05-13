using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static SupremeLeagueManager.Models.Player;

namespace SupremeLeagueManager.Models.Global_Models
{
    public static class PlayerSkills
    {
        public static double Compute(Player Player)
        {
            double averageSkills = 0;

            switch (Player.Position)
            {
                case PlayerPosition.GK:
                    averageSkills = (Player.GoalKeeper + Player.Diving + Player.Handling + Player.Reflex + Player.Speed + Player.Acceleration) / 6;
                    break;
                case PlayerPosition.CB:
                    averageSkills = (Player.Defence + Player.Tackling + Player.Covering + Player.Heading + Player.Speed + Player.Acceleration) / 6;
                    break;
                case PlayerPosition.LB:
                case PlayerPosition.RB:
                    averageSkills = (Player.Defence + Player.Attack + Player.Technique + Player.LongPassAccuracy + Player.Speed + Player.Acceleration) / 6;
                    break;
                case PlayerPosition.DM:
                    averageSkills = (Player.Defence + Player.Midfield + Player.Tackling + Player.Covering + Player.Speed + Player.Acceleration) / 6;
                    break;
                case PlayerPosition.CM:
                    averageSkills = (Player.Midfield + Player.ShortPassAccuracy + Player.LongPassAccuracy + Player.Technique + 
                                     Player.Speed + Player.Acceleration) / 6;
                    break;
                case PlayerPosition.LM:
                case PlayerPosition.RM:
                    averageSkills = (Player.Midfield + Player.Attack + Player.Technique + Player.LongPassAccuracy + Player.Speed + Player.Acceleration) / 6;
                    break;
                case PlayerPosition.AM:
                    averageSkills = (Player.Midfield + Player.Attack + Player.Technique + Player.ShortPassAccuracy +
                                     Player.LongPassAccuracy + Player.ShotPower + Player.ShotAccuracy + Player.Speed + Player.Acceleration) / 9;
                    break;
                case PlayerPosition.LW:
                case PlayerPosition.RW:
                    averageSkills = (Player.Attack + Player.Technique + Player.ShortPassAccuracy + Player.LongPassAccuracy + Player.ShotPower +
                                     Player.ShotAccuracy + Player.Speed + Player.Acceleration) / 8;
                    break;
                case PlayerPosition.SS:
                    averageSkills = (Player.Midfield + Player.Attack + Player.Technique + Player.ShortPassAccuracy + Player.ShotPower + 
                                     Player.ShotAccuracy + Player.Speed + Player.Acceleration) / 8;
                    break;
                case PlayerPosition.CF:
                    averageSkills = (Player.Attack + Player.Technique + Player.ShortPassAccuracy + Player.ShotPower + Player.ShotAccuracy + 
                                     Player.Speed + Player.Acceleration) / 7;
                    break;
                default:
                    break;
            }

            return averageSkills;
        }
    }
}