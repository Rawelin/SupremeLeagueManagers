using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using SupremeLeagueManager.Models.Global;
using SLMContextDB;

namespace SupremeLeagueManager.Models.Admin
{
    public static class CRUD
    {
        internal static int AddPlayer(dictTeamsPlayersM v)
        {
            int r = 0;

            try
            {
                dictTeamsPlayers player  = new dictTeamsPlayers()
                {
                    IdDictTeams = v.IdDictTeams,
                    IdDictCountries = v.IdDictCountries,
                    IdDictPositions = v.IdDictPositions,
                    IdDictPositionsActual = v.IdDictPositions,
                    IdDictPersons = 1,
                    BirthDate = v.BirthDate,
                    FirstName = v.FirstName,
                    LastName = v.LastName,
                    LeftFootSkills = v.LeftFootSkills,
                    RightFootSkills = v.RightFootSkills,
                    GoalKeeper = v.GoalKeeper,
                    Defence = v.Defence,
                    Midfield = v.Midfield,
                    Attack = v.Attack,
                    Diving = v.Diving,
                    Handling = v.Handling,
                    Tackling = v.Tackling,
                    Covering = v.Covering,
                    LongPassAccuracy = v.LongPassAccuracy,
                    ShortPassAccuracy = v.ShortPassAccuracy,
                    ShotAccuracy = v.ShotAccuracy,
                    Speed = v.Speed,
                    Acceleration = v.Acceleration,
                    Reflex = v.Reflex,
                    Heading = v.Heading,
                    ShotPower = v.ShotPower,
                    Technique = v.Technique,
                    Endurance = v.Endurance,
                    Stamina = v.Stamina,
                    AverageSkills = 0,
                    AverageDynamicSkills = 0,
                    Active = 1
                };

                using (Entities slmCtx = new Entities())
                {
                    slmCtx.dictTeamsPlayers.Add(player);
                    slmCtx.SaveChanges();

                    r = 1;
                }
            }
            catch(Exception ex)
            {
                ErrorHandling.InsertError("Admin", "CRUD", "AddPlayer", ex);
            }

            return r;
        }
    }
}