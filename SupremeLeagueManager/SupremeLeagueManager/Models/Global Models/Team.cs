using SupremeLeagueManager.Models.Global_Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace SupremeLeagueManager.Models
{
    public class Team
    {
        public int TeamId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Emblems { get; set; }
        public List<Player> Players { get; set; }
        public TeamSkillsModel TeamSkillsModel { get; set; }

        public Team()
        {
            Players = new List<Player>();
            TeamSkillsModel = new TeamSkillsModel();
        }

        public TeamSkillsModel GetTeamSkills()
        {
            return TeamSkillsModel;
        }

        public string GetFullName()
        {
            return Name + " " + City;
        }

        public void SetTeamSkills()
        {
            TeamSkillsModel.GoalKeeper = TeamSkills.TeamGoalKeeper(Players);
            TeamSkillsModel.Defence = TeamSkills.TeamDefence(Players);
            TeamSkillsModel.Midfield = TeamSkills.TeamMidfield(Players);
            TeamSkillsModel.Attack = TeamSkills.TeamAttack(Players);
            TeamSkillsModel.Speed = TeamSkills.TeamSpeed(Players);
            TeamSkillsModel.Technick = TeamSkills.TeamTechnique(Players);
            TeamSkillsModel.Overall = TeamSkills.TeamOverall(Players);
        }
    }
}