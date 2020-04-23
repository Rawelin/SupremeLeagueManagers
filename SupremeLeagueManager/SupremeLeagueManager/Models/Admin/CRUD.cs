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
                    Lp = FindNextLp(v.IdDictTeams),
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

        internal static int SaveTeamSetting(List<dictTeamsPlayersM> teamsPlayers)
        {
            int correct = 0;

            try
            {
                using (Entities slmCtx = new Entities())
                {
                    for(int i = 0; i < teamsPlayers.Count; i++)
                    {
                        dictTeamsPlayers players = new dictTeamsPlayers();

                        players = slmCtx.dictTeamsPlayers.Find(teamsPlayers[i].IdDictTeamsPlayers);

                        players.IdDictCountries = teamsPlayers[i].IdDictCountries;
                        players.IdDictPositions = teamsPlayers[i].IdDictPositions;
                        players.Lp = teamsPlayers[i].Lp;
                        players.IdDictPersons = teamsPlayers[i].IdDictPersons;
                        players.FirstName = teamsPlayers[i].FirstName;
                        players.LastName = teamsPlayers[i].LastName;
                        players.LeftFootSkills = teamsPlayers[i].LeftFootSkills;
                        players.RightFootSkills = teamsPlayers[i].RightFootSkills;
                        players.GoalKeeper = teamsPlayers[i].GoalKeeper;
                        players.Defence = teamsPlayers[i].Defence;
                        players.Midfield = teamsPlayers[i].Midfield;
                        players.Attack = teamsPlayers[i].Attack;
                        players.Diving = teamsPlayers[i].Diving;
                        players.Handling = teamsPlayers[i].Handling;
                        players.Tackling = teamsPlayers[i].Tackling;
                        players.Covering = teamsPlayers[i].Covering;
                        players.LongPassAccuracy = teamsPlayers[i].LongPassAccuracy;
                        players.ShortPassAccuracy = teamsPlayers[i].ShortPassAccuracy;
                        players.ShotAccuracy = teamsPlayers[i].ShotAccuracy;
                        players.Speed = teamsPlayers[i].Speed;
                        players.Acceleration = teamsPlayers[i].Acceleration;
                        players.Reflex = teamsPlayers[i].Reflex;
                        players.Heading = teamsPlayers[i].Heading;
                        players.ShotPower = teamsPlayers[i].ShotPower;
                        players.Technique = teamsPlayers[i].Technique;
                        players.Endurance = teamsPlayers[i].Endurance;
                        players.Stamina = teamsPlayers[i].Stamina;

                        slmCtx.SaveChanges();
                    }

                    correct = 1;
                }
            }
            catch(Exception ex)
            {
                ErrorHandling.InsertError("Admin", "CRUD", "SaveTeamSetting", ex);
            }

            return correct;
        }

        private static int FindNextLp(int IdDictTeams)
        {
            int lp = 0;
            int[] playerLp;

            try
            {
                using (Entities slmCtx = new Entities())
                {
                    playerLp = slmCtx.dictTeamsPlayers
                                    .Where(a => a.IdDictTeams == IdDictTeams)
                                    .OrderBy(a => a.Lp)
                                    .Select(a => a.Lp).ToArray();
                }

                if (playerLp.Length == 0)
                {
                    lp = 0;
                }
                else
                {
                    for(int i = 0; i < playerLp.Length; i++)
                    {
                        if(i < playerLp.Length - 1)
                        {
                            if ((playerLp[i]) + 1 != playerLp[i + 1])
                            {
                                lp = playerLp[i] + 1;

                                return lp;
                            }
                        }
                        else
                        {
                            lp = playerLp[i] + 1;

                            return lp;
                        }

                    }
                }
            }
            catch(Exception ex)
            {
                ErrorHandling.InsertError("Admin", "CRUD", "FindNextLp", ex);
            }

            return lp;
        }
    }
}