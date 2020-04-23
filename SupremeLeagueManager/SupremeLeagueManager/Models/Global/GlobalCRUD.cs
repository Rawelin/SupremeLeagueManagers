using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SupremeLeagueManager.Models.Admin;

using SLMContextDB;

namespace SupremeLeagueManager.Models.Global
{
    public static class GlobalCRUD
    {
        internal static List<ListM> GetDictTeams()
        {
            List<ListM> r = new List<ListM>();

            try
            {
                using (Entities slmCtx = new Entities())
                {
                    r = slmCtx.dictTeams.Where(a => a.Active == 1)
                        .Select(a => new ListM
                        {
                            Id = a.IdDictTeams,
                            Description = a.Name + " " + a.City
                        }).ToList();
                }
            }
            catch(Exception ex)
            {
                ErrorHandling.InsertError("Admin", "GlobalCRUD", "GetDictTeams", ex);
            }

            return r;
        }

        internal static List<ListM> GetPositions()
        {
            List<ListM> r = new List<ListM>();

            try
            {
                using (Entities slmCtx = new Entities())
                {
                    r = slmCtx.dictPositions
                        .Where(a => a.Active == 1)
                        .Select(a => new ListM {
                            Id = a.IdDictPositions,
                            Description = a.Description
                        }).ToList();
                }
            }
            catch(Exception ex)
            {
                ErrorHandling.InsertError("Admin", "GlobalCRUD", "GetTeamsPlayers", ex);
            }

            return r;
        }

        internal static List<ListM> GetPositionsShortName()
        {
            List<ListM> r = new List<ListM>();

            try
            {
                using (Entities slmCtx = new Entities())
                {
                    r = slmCtx.dictPositions
                        .Where(a => a.Active == 1)
                        .Select(a => new ListM
                        {
                            Id = a.IdDictPositions,
                            Description = a.ShortName
                        }).ToList();
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.InsertError("Admin", "GlobalCRUD", "GetTeamsPlayers", ex);
            }

            return r;
        }

        internal static List<ListM> GetCountries()
        {
            List<ListM> r = new List<ListM>();

            try
            {
                using (Entities slmCtx = new Entities())
                {
                    r = slmCtx.dictCountries
                        .Select(a => new ListM {
                            Id = a.IdDictCountries,
                            Description = a.CountryName
                        })
                        .OrderBy(a => a.Description)
                        .ToList();
                }
            }
            catch(Exception ex)
            {
                ErrorHandling.InsertError("Admin", "GlobalCRUD", "GetCountries", ex);
            }

            return r;
        }

        internal static List<dictTeamsPlayersM> GetTeamPlayers(int IdDictTeams)
        {
            List<dictTeamsPlayersM> r = new List<dictTeamsPlayersM>();

            try
            {
                using (Entities slmCtx = new Entities())
                {
                    r = slmCtx.dictTeamsPlayers
                        .Where(a => a.IdDictTeams == IdDictTeams)
                        .Select(a => new dictTeamsPlayersM {
                            IdDictTeamsPlayers = a.IdDictTeamsPlayers,
                            IdDictTeams = a.IdDictTeams,
                            IdDictCountries = a.IdDictCountries,
                            CountryCode = a.dictCountries.AlphaCode3,
                            IdDictPositions = a.IdDictPositions,
                            PositionShortName = a.dictPositions.ShortName,
                            Lp = a.Lp,
                            IdDictPersons = a.IdDictPersons,
                            BirthDate = a.BirthDate,
                            Age = 0,
                            FirstName = a.FirstName,
                            LastName = a.LastName,
                            LeftFootSkills = a.LeftFootSkills,
                            RightFootSkills = a.RightFootSkills,
                            GoalKeeper = a.GoalKeeper,
                            Defence = a.Defence,
                            Midfield = a.Midfield,
                            Attack = a.Attack,
                            Diving = a.Diving,
                            Handling = a.Handling,
                            Tackling = a.Tackling,
                            Covering = a.Covering,
                            LongPassAccuracy = a.LongPassAccuracy,
                            ShortPassAccuracy = a.ShortPassAccuracy,
                            ShotAccuracy = a.ShotAccuracy,
                            Speed = a.Speed,
                            Acceleration = a.Acceleration,
                            Reflex = a.Reflex,
                            Heading = a.Heading,
                            ShotPower = a.ShotPower,
                            Technique = a.Technique,
                            Endurance = a.Endurance,
                            Stamina = a.Stamina,
                            AverageSkills = a.AverageSkills,
                            AverageDynamicSkills = a.AverageDynamicSkills,
                            Active = a.Active
                        })
                        .OrderBy(a => a.Lp)
                        .ToList();
                }

                for(int i = 0; i < r.Count; i++)
                {
                    r[i].Age = Helpers.GetAge(r[i].BirthDate);
                }
            }
            catch(Exception ex)
            {
                ErrorHandling.InsertError("Admin", "GlobalCRUD", "GetTeamsPlayers", ex);
            }

            return r;
        }
    }
}