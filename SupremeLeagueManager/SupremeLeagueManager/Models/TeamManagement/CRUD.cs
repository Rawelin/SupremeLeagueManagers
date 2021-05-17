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
        public static Team GetTeamPlayers(int? id)
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
                                      GoalKeeper = 0,
                                      Defence = 0,
                                      Midfield = 0,
                                      Attack = 0,
                                      Header = 0,
                                      Speed = 0,
                                      Technique = 0,
                                      Overall = 0,
                                      Players = slmCtx.dictTeamsPlayers
                                                       .Where(p => p.IdDictTeams == id && p.Active == 1)
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
                                                           AverageDynamicSkills = (double)p.AverageDynamicSkills,
                                                           SkillDifference = 0

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
                ErrorHandling.InsertError("TeamManagement", "CRUD", "GetTeamPlayers", ex);
            }

            return team;
        }

        public static List<Team> GetTeamsPlayers()
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
                                      Formation = t.IdDictFormations,
                                      Pressing = (int)t.Pressing,
                                      Aggression = (int)t.Aggression,
                                      AttackLevel = (int)t.AttackLevel,
                                      GoalKeeper = 0,
                                      Defence = 0,
                                      Midfield = 0,
                                      Attack = 0,
                                      Header = 0,
                                      Speed = 0,
                                      Technique = 0,
                                      Overall = 0,
                                      Players = slmCtx.dictTeamsPlayers
                                                       .Where(p => p.IdDictTeams == t.IdDictTeams && p.Active == 1)
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
                                                           AverageDynamicSkills = (double)p.AverageDynamicSkills,
                                                           SkillDifference = 0

                                                       })
                                                       .OrderBy(p => p.IndexPosition)
                                                       .ToList()
                                  }).
                                  ToList();

                    for (int i = 0; i < teams.Count; i++)
                    {
                        for (int j = 0; j < teams[i].Players.Count; j++)
                        {
                            teams[i].Players[j].Age = Helpers.GetAge(teams[i].Players[j].DOB);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                ErrorHandling.InsertError("TeamManagement", "CRUD", "GetTeamsPlayers", ex);
            }

            return teams;
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
                                      Formation = t.IdDictFormations,
                                      CountryId = t.IdCountries,
                                      Pressing = (int)t.Pressing,
                                      AttackLevel = (int)t.AttackLevel,
                                      Aggression = (int)(t.Aggression),
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

        public static List<TeamSinglePlayerM> GetTeamsSinglePlayer(int id)
        {
            List<TeamSinglePlayerM> table = new List<TeamSinglePlayerM>();

            try
            {
                using (Entities slmCtx = new Entities())
                {
                    table = slmCtx.Teams.Where(t => t.IdUser == id &&
                                                    t.Active == 1)
                                         .Select(t => new TeamSinglePlayerM
                                         {
                                             IdTeam = t.IdTeam,
                                             IdDictTeams = t.IdDictTeams,
                                             IdCountries = t.IdCountries,
                                             IdDictFormations = t.IdDictFormations,
                                             Name = t.Name,
                                             City = t.City,
                                             Pressing = t.Pressing,
                                             AttackLevel = t.AttackLevel,
                                             Aggression = t.Aggression,
                                             Played= t.Played,
                                             Won = t.Won,
                                             Drawn = t.Drawn,
                                             Lost = t.Lost,
                                             GoalsFor = t.GoalsFor,
                                             GoalsAgainst = t.GoalsAgainst,
                                             Points = t.Points
                                         })
                                         .ToList();
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.InsertError("TeamManagement", "CRUD", "GetTeamsSinglePlayer", ex);
            }

            return table;
        }

        public static List<Team> GetAllTeamsSinglePlayer()
        {
            List<Team> teams = new List<Team>();

            try
            {
                using (Entities slmCtx = new Entities())
                {
                    teams = slmCtx.Teams
                                  .Where(t => t.Active == 1)
                                  .Select(t => new Team
                                  {
                                      SPTeamId = t.IdTeam,
                                      TeamId = t.IdDictTeams,
                                      Name = t.Name,
                                      City = t.City,
                                      Formation = t.IdDictFormations,
                                      Pressing = (int)t.Pressing,
                                      Aggression = (int)t.Aggression,
                                      AttackLevel = (int)t.AttackLevel,
                                      GoalKeeper = 0,
                                      Defence = 0,
                                      Midfield = 0,
                                      Attack = 0,
                                      Header = 0,
                                      Speed = 0,
                                      Technique = 0,
                                      Overall = 0,
                                      Players = slmCtx.TeamsPlayer
                                                       .Where(p => p.IdDictTeams == t.IdDictTeams && p.Active == 1)
                                                       .Select(p => new Player
                                                       {
                                                           IdTeamsPlayer = p.IdTeamsPlayers,
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
                                                           AverageDynamicSkills = (double)p.AverageDynamicSkills,
                                                           SkillDifference = 0

                                                       })
                                                       .OrderBy(p => p.IndexPosition)
                                                       .ToList()
                                  }).
                                  ToList();

                    for (int i = 0; i < teams.Count; i++)
                    {
                        for (int j = 0; j < teams[i].Players.Count; j++)
                        {
                            teams[i].Players[j].Age = Helpers.GetAge(teams[i].Players[j].DOB);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                ErrorHandling.InsertError("TeamManagement", "CRUD", "GetTeamsPlayers", ex);
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

        public static void SwaPlayersSP(Player playerOne, Player playerTwo)
        {
            try
            {
                using (Entities slmCtx = new Entities()) 
                {
                    TeamsPlayer firstPlayer = slmCtx.TeamsPlayer.Find(playerOne.IdTeamsPlayer);
                    firstPlayer.Lp = playerOne.IndexPosition;

                    TeamsPlayer secondPlayer = slmCtx.TeamsPlayer.Find(playerTwo.IdTeamsPlayer);
                    secondPlayer.Lp = playerTwo.IndexPosition;

                    slmCtx.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.InsertError("TeamManagement", "CRUD", "SwaPlayersSP", ex);
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

        public static void ChangeFormationSP(Provider provider)
        {
            try
            {
                using (Entities slmCtx = new Entities())
                {
                    Teams team = slmCtx.Teams.Find(provider.TeamId);
                    team.IdDictFormations = (int)provider.FormationId;

                    slmCtx.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.InsertError("TeamManagement", "CRUD", "ChangeFormationSP", ex);
            }
        }

        public static void ChangeTeamSettingsSP(Provider provider)
        {
            try
            {
                using (Entities slmCtx = new Entities())
                {
                    Teams team = slmCtx.Teams.Find(provider.TeamId);

                    team.Pressing = provider.SliderObject.Pressing;
                    team.AttackLevel = provider.SliderObject.AttackLevel;
                    team.Aggression = provider.SliderObject.Aggression;

                    slmCtx.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.InsertError("TeamManagement", "CRUD", "ChangeTeamSettingsSP", ex);
            }
        }

        public static void DayIncrementation(Provider provider)
        {
            try
            {
                using (Entities slmCtx = new Entities())
                {
                    SLMContextDB.SinglePlayer singlePlayer = slmCtx.SinglePlayer.Find(provider.SinglePlayer.IdSinglePlayer);

                    singlePlayer.Season = provider.SinglePlayer.Season;
                    singlePlayer.Year = provider.SinglePlayer.Year;
                    singlePlayer.Month = provider.SinglePlayer.Month;
                    singlePlayer.Week = provider.SinglePlayer.Week;
                    singlePlayer.Day = provider.SinglePlayer.Day;

                    slmCtx.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.InsertError("TeamManagement", "CRUD", "DayIncrementation", ex);
            }
        }
    }
}