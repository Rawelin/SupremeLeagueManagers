﻿using SLMContextDB;
using SupremeLeagueManager.Models.Global;
using SupremeLeagueManager.Models.Global_Models;
using SupremeLeagueManager.Models.TeamManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SupremeLeagueManager.Models.TeamTest
{
    public class CreateTeams
    {
        private TeamManagementVM TeamManagementVM = new TeamManagementVM();

        public CreateTeams()
        {
            SetTeams();
        }

        public TeamManagementVM GetTeams()
        {
            return TeamManagementVM;
        }
        private void SetTeams()
        {
            try
            {
                TeamManagementVM.Teams = CRUD.GetTeamsPlayers();
            }
            catch (Exception ex)
            {
                ErrorHandling.InsertError("TeamManagement", "CreateTeams", "SetTeams", ex);
                TeamManagementVM.ErrorMessage = ex.ToString();
            }
        }
    }
}