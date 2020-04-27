using SLMContextDB;
using SupremeLeagueManager.Models.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SupremeLeagueManager.Models.TeamManagement
{
    public static class CRUD
    {
        public static Team GetTeam(int? id)
        {
            Team team = new Team();

            try
            {
                using (Entities slmCtx = new Entities())
                {
                    team = slmCtx.dictTeams
                                  .Where(t=> t.IdDictTeams == id &&  
                                             t.Active == 1 )
                                  .Select(t => new Team
                                  {
                                      TeamId = t.IdDictTeams,
                                      Name = t.Name,
                                      City = t.City,
                                      Formation = t.IdDictFormations
                                  })
                                  .FirstOrDefault();
                                  
                }

            }
            catch (Exception ex)
            {
                ErrorHandling.InsertError("TeamManagement", "CRUD", "GetTeam", ex);
            }

            return team;
        }

        public static List<Team> GetTeams()
        {
            List<Team> teams = new List<Team>();

            try
            {
                using (Entities slmCtx = new Entities())
                {
                    teams = slmCtx.dictTeams
                                  .Where(t => t.Active == 1)
                                  .Select(t => new Team
                                  {
                                      TeamId = t.IdDictTeams,
                                      Name = t.Name,
                                      City = t.City,
                                      Formation = t. IdDictFormations
                                  })
                                  .ToList();
                }

            }
            catch (Exception ex)
            {
                ErrorHandling.InsertError("TeamManagement", "CRUD", "GetTeams", ex);
            }

            return teams;
        }
    }
}