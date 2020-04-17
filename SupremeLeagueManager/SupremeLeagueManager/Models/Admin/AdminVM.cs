using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using SupremeLeagueManager.Models.Global;

namespace SupremeLeagueManager.Models.Admin
{
    public class AdminVM
    {
        public List<ListM> dictTeams = new List<ListM>();
        public List<dictTeamsPlayersM> teamsPlayersAll = new List<dictTeamsPlayersM>();

        dictTeamsPlayersM teamPlayer = new dictTeamsPlayersM();

        public AdminVM()
        {
            dictTeams = GlobalCRUD.GetDictTeams();
            teamsPlayersAll = GlobalCRUD.GetTeamsPlayers();
        }
    }
}