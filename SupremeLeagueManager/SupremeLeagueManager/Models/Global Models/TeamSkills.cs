using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SupremeLeagueManager.Models.Global_Models
{
    public class TeamSkills
    {
        private Team Team;

        public TeamSkills(Team Team)
        {
            this.Team = Team;
           
            TeamGoalKeeper();
            TeamSpeed();
            TeamTechnique();
            TeamDefence();
            TeamOverall();
        }

        public TeamSkillsModel GetTeamSkillsModel()
        {
            return Team.TeamSkillsModel;
        }

        private void TeamGoalKeeper()
        {
            Team.TeamSkillsModel.GoalKeeper = PlayerSkills.Compute(Team.Players[0], Player.PlayerPosition.GK);
        }

        public void TeamDefence()
        {
            // TO DO implement formation class to calculate team defence
            switch (Team.Formation)
            {
                case 1:
                case 2:
                case 3:
                    Team.TeamSkillsModel.Defence = (Team.Players.Select(d => d.Defence).Skip(1).Take(4).Sum()) / 4;
                    break;
                case 4:
                    Team.TeamSkillsModel.Defence = (Team.Players.Select(d => d.Defence).Skip(1).Take(3).Sum()) / 3;
                    break;
            }

        }

        public void TeamMidfield()
        {
            // TO DO implement formation class to calculate team midfield
           
        }

        public void  TeamAttack()
        {
            // TO DO implement formation class to calculate team attack
           
        }

        public void TeamSpeed()
        {
            double value = Team.Players.Select(p => p.Speed)
                                       .Take(11)
                                       .Sum();

            Team.TeamSkillsModel.Speed = value / 11;
        }

        public void TeamTechnique()
        {
            double value = Team.Players.Select(p => p.Technique)
                                       .Take(11)
                                       .Sum();

            Team.TeamSkillsModel.Technicque =  value / 11;
        }

        public void TeamOverall()
        {
            //double value  = Team.Players.Select(p => p.GetAverageSkils())
            //                            .Take(11)
            //                            .Sum();

            Team.TeamSkillsModel.Overall = (Team.TeamSkillsModel.GoalKeeper + Team.TeamSkillsModel.Defence +
                                           Team.TeamSkillsModel.Speed + Team.TeamSkillsModel.Technicque) / 4;
        }
    }
}