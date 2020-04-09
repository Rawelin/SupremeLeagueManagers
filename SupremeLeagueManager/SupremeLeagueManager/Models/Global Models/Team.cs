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
        public int Formation { get; set; }
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

        public void SetTeamSkills()
        {
            TeamSkillsModel = new TeamSkills(this).GetTeamSkillsModel();
        }

        public string GetFullName()
        {
            return Name + " " + City;
        }

        public string GetEmblemsName()
        {
            string emblemsName = Name + City + ".png";
            
            return emblemsName = emblemsName.Replace(" ", ""); 
        }
    }
}