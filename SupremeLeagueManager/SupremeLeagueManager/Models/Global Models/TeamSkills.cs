using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SupremeLeagueManager.Models.Global_Models
{
    public class TeamSkills
    {
        private TeamSkillsModel TeamSkillsModel;
        List<Player> Players;

        public TeamSkills(TeamSkillsModel TeamSkillsModel, List<Player> Players)
        {
            this.TeamSkillsModel = TeamSkillsModel;
            this.Players = Players;

            TeamGoalKeeper();
            TeamSpeed();
            TeamTechnique();
            TeamOverall();
        }

        public TeamSkillsModel GetTeamSkillsModel()
        {
            return TeamSkillsModel;
        }

        private void TeamGoalKeeper()
        {
            TeamSkillsModel.GoalKeeper = PlayerSkills.Compute(Players[0], Player.PlayerPosition.GK);
        }

        public void TeamDefence()
        {
            // TO DO implement formation class to calculate team defence

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
            double value = Players.Select(p => p.Speed)
                                  .Take(11)
                                  .Sum();

            TeamSkillsModel.Speed = value / 11;
        }

        public void TeamTechnique()
        {
            double value = Players.Select(p => p.Technique)
                                  .Take(11)
                                  .Sum();

            TeamSkillsModel.Technicque =  value / 11;
        }

        public void TeamOverall()
        {
            double value  = Players.Select(p => p.GetAverageSkils())
                                   .Take(11)
                                   .Sum();

            TeamSkillsModel.Overall = value / 11;
        }
    }
}