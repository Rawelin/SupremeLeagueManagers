using SLMContextDB;
using SupremeLeagueManager.Models.Global;
using SupremeLeagueManager.Models.SignIn;
using SupremeLeagueManager.Models.TeamTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CRUD = SupremeLeagueManager.Models.TeamManagement.CRUD;

namespace SupremeLeagueManager.Models.Home
{
    public class SinglePlayerGame
    {
        private Provider provider;
        private HttpContext context;
        private UsersM user;

        public SinglePlayerGame(Provider provider)
        {
            this.provider = provider;
            SetUser();
            Menu();
        }

        public Provider GetStatus()
        {
            return provider;
        }

        private void CheckGame()
        {
            SLMContextDB.SinglePlayer singlePlayer = new SLMContextDB.SinglePlayer();

            try
            {
                using (Entities slmCtx = new Entities())
                {
                    singlePlayer = slmCtx.SinglePlayer
                                         .Where(s => s.IdUser == user.IdUser)
                                         .FirstOrDefault();

                    provider.Exsist = singlePlayer is null ? 0 : 1;
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.InsertError("Home", "SinglePlayerGame", "CheckGame", ex);
            }
        }

        private void SetGame()
        {
            try
            {
                List<Team> dictTeams = new List<Team>();
                dictTeams = CRUD.GetTeams();

                using (Entities slmCtx = new Entities())
                {
                    Teams teams = new Teams();
                    SLMContextDB.SinglePlayer singlePlayer = new SLMContextDB.SinglePlayer();

                    singlePlayer.IdUser = user.IdUser;
                    singlePlayer.IdTeam = (int)provider.TeamId;
                    singlePlayer.Season = 1;
                    singlePlayer.StartDate = DateTime.Now;
                    singlePlayer.Active = 1;

                    slmCtx.SinglePlayer.Add(singlePlayer);
                    slmCtx.SaveChanges();


                    for (int i = 0; i < dictTeams.Count(); i++)
                    {
                        teams.IdDictTeams = dictTeams[i].TeamId;
                        teams.IdCountries = dictTeams[i].CountryId;
                        teams.IdDictFormations = dictTeams[i].Formation;
                        teams.IdUser = user.IdUser;
                        teams.Name = dictTeams[i].Name;
                        teams.City = dictTeams[i].City;
                        teams.Pressing = dictTeams[i].Pressing;
                        teams.Aggression = dictTeams[i].Aggression;
                        teams.AttackLevel = dictTeams[i].AttackLevel;
                        teams.Played = 0;
                        teams.Won = 0;
                        teams.Drawn = 0;
                        teams.Lost = 0;
                        teams.GoalsFor = 0;
                        teams.GoalsAgainst = 0;
                        teams.Points = 0;
                        teams.Active = 1;

                        slmCtx.Teams.Add(teams);
                        slmCtx.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.InsertError("Home", "SinglePlayerGame", "SetGame", ex);
                provider.ErrorMessage = ex.ToString();
            }

        }

        private void RemoveGame()
        {
            try
            {
                using (Entities slmCtx = new Entities())
                {
                    SLMContextDB.SinglePlayer remove = slmCtx.SinglePlayer
                                                             .Where(s => s.IdUser == user.IdUser)
                                                             .FirstOrDefault();

                    if (!(remove is null))
                    {
                        slmCtx.SinglePlayer.Remove(remove);

                        List<Teams> teams = slmCtx.Teams
                                             .Where(t => t.IdUser == user.IdUser)
                                             .ToList();

                        slmCtx.Teams.RemoveRange(teams);
                        slmCtx.SaveChanges();
                        provider.ErrorMessage = "0";
                    }
                    else
                    {
                        provider.ErrorMessage = "1";
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.InsertError("Home", "SinglePlayerGame", "RemoveGame", ex);
                provider.ErrorMessage = "2";
            }
        }

        private void SetUser()
        {
            context = HttpContext.Current;
            user = (UsersM)context.Session["User"];
        }

        private void Menu()
        {
            switch (provider.Status)
            {
                case 1:
                    CheckGame();
                    break;
                case 2:
                    SetGame();
                    break;
                case 3:
                    RemoveGame();
                    break;
            }
        }
    }
}