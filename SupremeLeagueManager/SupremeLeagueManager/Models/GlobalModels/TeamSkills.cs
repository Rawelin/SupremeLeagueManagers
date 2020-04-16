using SupremeLeagueManager.Models.Global_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SupremeLeagueManager.Models
{
    public class TeamSkills
    {
        private Team Team;

        public TeamSkills(Team Team)
        {
            this.Team = Team;
           
            TeamGoalKeeper();
            TeamFormationsSkill();
            TeamSpeed();
            TeamTechnique();
            TeamOverall();
        }

        public TeamSkillsModel GetTeamSkillsModel()
        {
            return Team.TeamSkillsModel;
        }

        private void TeamGoalKeeper()
        {
            Team.TeamSkillsModel.GoalKeeper = PlayerSkills.Compute(Team.Players[0]);
        }

        private void TeamFormationsSkill()
        {
            Team.TeamSkillsModel.Defence = TeamFormation.SetDefence(Team);
            Team.TeamSkillsModel.Midfield = TeamFormation.SetMidfield(Team);
            Team.TeamSkillsModel.Attack = TeamFormation.SetAttack(Team);
        }

        private void TeamSpeed()
        {
            double value = Team.Players.Select(p => p.Speed)
                                       .Take(11)
                                       .Sum();

            Team.TeamSkillsModel.Speed = value / 11;
        }

        private void TeamTechnique()
        {
            double value = Team.Players.Select(p => p.Technique)
                                       .Take(11)
                                       .Sum();

            Team.TeamSkillsModel.Technicque =  value / 11;
        }

        private void TeamOverall()
        {
            //double value  = Team.Players.Select(p => p.GetAverageSkils())
            //                            .Take(11)
            //                            .Sum();

            Team.TeamSkillsModel.Overall = (Team.TeamSkillsModel.GoalKeeper + Team.TeamSkillsModel.Defence + Team.TeamSkillsModel.Midfield + 
                                            Team.TeamSkillsModel.Attack + Team.TeamSkillsModel.Speed + Team.TeamSkillsModel.Technicque) / 6;
        }
    }
}