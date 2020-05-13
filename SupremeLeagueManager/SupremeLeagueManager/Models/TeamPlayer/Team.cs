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
        public double GoalKeeper { get; set; }
        public double Defence { get; set; }
        public double Midfield { get; set; }
        public double Attack { get; set; }
        public double Header { get; set; }
        public double Speed { get; set; }
        public double Technique { get; set; }
        public double Overall { get; set; }
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

        public void ChangePlayer(int p1, int p2)
        {
            Player Tmp = Players[p1];
            Players[p1] = Players[p2];
            Players[p2] = Tmp;
        }

        public void SetTeamSkills()
        {
            TeamSkillsModel = new TeamSkills(this).GetTeamSkillsModel();
        }

        public void SetTeamDynamicSkills()
        {

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