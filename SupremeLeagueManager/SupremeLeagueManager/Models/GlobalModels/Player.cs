﻿using SupremeLeagueManager.Models.Global_Models;
using SupremeLeagueManager.Models.GlobalModels;
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
        public int LeftFootSkills { get; set; }
        public int RightFootSkills { get; set; }

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
        private double averageDynamicSkills;

        public Player() : base() { }

        public double GetAverageSkills()
        {
            return averageSkills;
        }

        public double GetAverageDynamicSkills(int currentPosition, int formation)
        {
            return averageDynamicSkills = new PlayerDynamicSkills(this, currentPosition, formation).GetDynamicSkills();
        }

        public void SetAverageSkills()
        {
            averageSkills = PlayerSkills.Compute(this);
        }

        public enum PlayerPosition { GK = 1, CB = 2, LB = 3, RB = 4, DM = 5, CM = 6, LM = 7, RM = 8, AM = 9, LW = 10, RW = 11, SS = 12, CF = 13 };
    }
}