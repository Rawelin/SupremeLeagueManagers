using SupremeLeagueManager.Models.Global_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SupremeLeagueManager.Models.GlobalModels
{
    public class TeamDynamicSkills
    {
        private Team Team;

        public TeamDynamicSkills(Team Team)
        {
            this.Team = Team;
        }

        public TeamSkillsModel GetTeamDynamicSkillsModel()
        {
            return Team.TeamSkillsModel;
        }


    }
}