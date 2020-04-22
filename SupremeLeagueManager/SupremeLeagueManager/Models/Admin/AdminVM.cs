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
        public List<ListM> dictCountries = new List<ListM>();
        public List<ListM> dictPositions = new List<ListM>();
        public List<ListM> dictPositionsShortName = new List<ListM>();

        public dictTeamsPlayersM teamPlayer = new dictTeamsPlayersM();

        public AdminVM()
        {
            dictTeams = GlobalCRUD.GetDictTeams();
            dictCountries = GlobalCRUD.GetCountries();
            dictPositions = GlobalCRUD.GetPositions();
            dictPositionsShortName = GlobalCRUD.GetPositionsShortName();
        }
    }
}