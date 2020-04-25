using SLMContextDB;
using SupremeLeagueManager.Models.Global;
using SupremeLeagueManager.Models.Global_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SupremeLeagueManager.Models.TeamTest
{
    public class CreateTeams
    {
        private TeamTestVM TeamTestVM = new TeamTestVM();

        public CreateTeams()
        {
            SetTeams();
        }

        public TeamTestVM GetTeams()
        {
            return TeamTestVM;
        }
        private void SetTeams()
        {
            //try
            //{
            //    TeamTestVM.Team = new Team();
            //    TeamTestVM.Teams.AddRange(new MockTeam().GetTeams());
            //}
            //catch (Exception ex)
            //{
            //    TeamTestVM.ErrorMessage = ex.ToString();
            //}

            try
            {
                using (Entities slmCtx = new Entities())
                {
                    TeamTestVM.Teams = slmCtx.dictTeams.Where(t => t.Active == 1)
                                                       .Select(t => new Team
                                                       {
                                                           TeamId = t.IdDictTeams,
                                                           Name = t.Name,
                                                           City = t.City

                                                       })
                                                       .ToList();
                                                       
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.InsertError("TeamMeanagement", "CreateTeams", "SetTeams", ex);

            }

        }
    }
}