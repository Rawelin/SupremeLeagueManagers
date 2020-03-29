using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SupremeLeagueManager.Models
{
    public class Player : Person
    {
        public PlayerPosition Position { get; set; }
        public int LeftFootPlaysSkill { get; set; }
        public int RightFootPlaysSkill { get; set; }
        public int Speed { get; set; }
        public int Acceleration { get; set; }
        public int Reflex { get; set; }
        public int Diving { get; set; }
        public int Tackling { get; set; }
        public int Covering { get; set; }
        public int Heading { get; set; }
        public int LongPassAccuracy { get; set; }
        public int ShortPassAccuracy { get; set; }
        public int ShotPower { get; set; }
        public int ShotAccuracy { get; set; }

        private double averageSkills;

        public Player() : base(){}

        public double GetAverageSkils()
        {
            return averageSkills;
        }

        public void SetAverageSkills()
        {
            switch (Position)
            {
                // simply example how to calculate player average skils
                case PlayerPosition.GoalKeeper:
                    averageSkills = (Speed + Acceleration + Reflex + Diving) / 4;
                    break;
                case PlayerPosition.Defender:
                    averageSkills = (Speed + Acceleration + Tackling + Covering + Heading) / 5;
                    break;
                case PlayerPosition.Midfielder:
                    averageSkills = (Speed + Acceleration + ShortPassAccuracy + LongPassAccuracy) / 4;
                    break;
                case PlayerPosition.Attacker:
                    averageSkills = (Speed + Acceleration + ShotPower + ShotAccuracy) / 4;
                    break;
                default:
                    break;
            }
        }

        public enum PlayerPosition { GoalKeeper = 1, Defender = 2, Midfielder = 3, Attacker = 4 };

    }
}