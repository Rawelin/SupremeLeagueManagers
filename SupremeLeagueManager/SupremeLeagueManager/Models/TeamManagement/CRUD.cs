using SLMContextDB;
using SupremeLeagueManager.Models.Admin;
using SupremeLeagueManager.Models.Global;
using SupremeLeagueManager.Models.TeamTest;
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
                                  .Where(t => t.IdDictTeams == id &&
                                             t.Active == 1)
                                  .Select(t => new Team
                                  {
                                      TeamId = t.IdDictTeams,
                                      Name = t.Name,
                                      City = t.City,
                                      Formation = t.IdDictFormations,
                                      Players = slmCtx.dictTeamsPlayers
                                                       .Where(p => p.IdDictTeams == id)
                                                       .Select(p => new Player
                                                       {
                                                           PlayerId = p.IdDictTeamsPlayers,
                                                           Name = p.FirstName,
                                                           Surname = p.LastName,
                                                           CountryName = p.dictCountries.CountryName,
                                                           DOB = p.BirthDate,
                                                           Age = 0,
                                                           TeamId = p.IdDictTeams,
                                                           IndexPosition = p.Lp,
                                                           PositionShort = p.dictPositions.ShortName,
                                                           LeftFootSkills = p.LeftFootSkills,
                                                           RightFootSkills = p.RightFootSkills,
                                                           GoalKeeper = (double)p.GoalKeeper,
                                                           Defence = (double)p.Defence,
                                                           Midfield = (double)p.Midfield,
                                                           Attack = (double)p.Attack,
                                                           Diving = (double)p.Diving,
                                                           Handling = (double)p.Handling,
                                                           Tackling = (double)p.Tackling,
                                                           Covering = (double)p.Covering,
                                                           LongPassAccuracy = (double)p.LongPassAccuracy,
                                                           ShortPassAccuracy = (double)p.ShortPassAccuracy,
                                                           ShotAccuracy = (double)p.ShotAccuracy,
                                                           Speed = (double)p.Speed,
                                                           Acceleration = (double)p.Acceleration,
                                                           Reflex = (double)p.Reflex,
                                                           Heading = (double)p.Heading,
                                                           ShotPower = (double)p.ShotPower,
                                                           Technique = (double)p.Technique,
                                                           Endurance = (double)p.Endurance,
                                                           Stamina = (double)p.Stamina,
                                                           AverageSkills = (double)p.AverageSkills,
                                                           AverageDynamicSkills = (double)p.AverageDynamicSkills
                                                           
                                                       })
                                                        .OrderBy(p => p.IndexPosition)
                                                        .ToList()
                                  })
                                  .FirstOrDefault();

                    for (int i = 0; i < team.Players.Count; i++)
                    {
                        team.Players[i].Age = Helpers.GetAge(team.Players[i].DOB);
                    }

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
                                      Formation = t.IdDictFormations
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

        public static void SwaPlayers(Player playerOne, Player playerTwo)
        {
            try
            {
                using (Entities slmCtx = new Entities())
                {
                    dictTeamsPlayers firstPlayer = slmCtx.dictTeamsPlayers.Find(playerOne.PlayerId);
                    firstPlayer.Lp = playerOne.IndexPosition;

                    dictTeamsPlayers secondPlayer = slmCtx.dictTeamsPlayers.Find(playerTwo.PlayerId);
                    secondPlayer.Lp = playerTwo.IndexPosition;

                    slmCtx.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.InsertError("TeamManagement", "CRUD", "SwaPlayers", ex);
            }

        }

        public static void ChangeFormation(Provider provider)
        {
            try
            {
                using (Entities slmCtx = new Entities())
                {
                    dictTeams team = slmCtx.dictTeams.Find(provider.TeamId);
                    team.IdDictFormations = (int)provider.FormationId;

                    slmCtx.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.InsertError("TeamManagement", "CRUD", "ChangeFormation", ex);
            }

        }
    }
}