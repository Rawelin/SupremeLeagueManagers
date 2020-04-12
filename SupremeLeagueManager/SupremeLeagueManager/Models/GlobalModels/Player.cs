using SupremeLeagueManager.Models.Global_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SupremeLeagueManager.Models
{
    public class Player : Person
    {
        public int PlayerId { get; set; }
        public int TeamId { get; set; }

        public PlayerPosition Position { get; set; }

        //leg play skills
        public int LeftFootPlaysSkill { get; set; }
        public int RightFootPlaysSkill { get; set; }

        // formation skils
        public double GoalKeeper { get; set; }
        public double Defence { get; set; }
        public double Midfield { get; set; }
        public double Attack { get; set; }

        // goalkepper skills
        public double Diving { get; set; }
        public double Handling { get; set; }

        // defender's skills
        public double Tackling { get; set; }
        public double Covering { get; set; }

        // midfielder's skils
        public double LongPassAccuracy { get; set; }
        public double ShortPassAccuracy { get; set; }

        // strikers skills
        public double ShotAccuracy { get; set; }

        // general skills
        public double Speed { get; set; }
        public double Acceleration { get; set; }
        public double Reflex { get; set; }
        public double Heading { get; set; }
        public double ShotPower { get; set; }
        public double Technique { get; set; }
        public double Endurance { get; set; }
        public double Stamina { get; set; }

        private double averageSkills;

        public Player() : base() { }

        public double GetAverageSkils()
        {
            return averageSkills;
        }

        public void SetAverageSkills()
        {
            averageSkills = PlayerSkills.Compute(this);
        }
      
        public enum PlayerPosition { GK = 1, CB = 2, LB = 4, RB = 5, DM = 6, CM = 7, LM = 8, RM = 9, AM = 10, LW = 11, RW = 12, SS = 13, CF = 14 };

    }
}