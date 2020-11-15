﻿using SLMContextDB;
using SupremeLeagueManager.Models.Global;
using SupremeLeagueManager.Models.SignIn;
using SupremeLeagueManager.Models.SinglePlayer.Models;
using SupremeLeagueManager.Models.TeamManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SupremeLeagueManager.Models.SinglePlayer
{
    public class Table
    {
        private TebleVM tableVM = new TebleVM();
        private HttpContext context;
        private UsersM user;

        public Table()
        {
            context = HttpContext.Current;
            user = (UsersM)context.Session["User"];
            SetTable();
        }

        public TebleVM GetTable()
        {
            return tableVM;
        }

        public void SetTable()
        {
            try
            {
                using (Entities slmCtx = new Entities())
                {
                    tableVM.Table = TeamManagement.CRUD.GetTeamsSinglePlayer(user.IdUser)
                                                       .OrderByDescending(t => t.Points)
                                                       .ThenByDescending(t => t.GoalsFor - t.GoalsAgainst)
                                                       .ThenByDescending(t => t.GoalsFor)
                                                       .ThenByDescending(t => t.Won)
                                                       .ToList();
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.InsertError("SinglePlayer", "Table", "SetTable", ex);
                tableVM.ErrorMessage = ex.ToString();
            }
        }
    }
}