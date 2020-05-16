using SupremeLeagueManager.Models.Global;
using SupremeLeagueManager.Models.TeamManagement;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace SupremeLeagueManager.Models.League
{
    public class Fixture
    {
        public List<Tuple<Team, Team>> pairs = new List<Tuple<Team, Team>>();
        public List<Tuple<Team, Team>> pairsTmp = new List<Tuple<Team, Team>>();
        public List<Tuple<Team, Team>> allPairs = new List<Tuple<Team, Team>>();
        public List<List<Tuple<Team, Team>>> allFixtures = new List<List<Tuple<Team, Team>>>();
        public List<Team> teamsA = new List<Team>();


        public Fixture()
        {
            SetTeams();
            RoundRobin();
            SetFixture();
        }

        public List<Tuple<Team, Team>> GetAllPairs()
        {
            return allPairs;
        }

        public List<List<Tuple<Team, Team>>> GetAllFixtures()
        {
            return allFixtures;
        }

        private void SetTeams()
        {
            try
            {
                teamsA = CRUD.GetTeams();
            }
            catch (Exception ex)
            {
                ErrorHandling.InsertError("League", "Fixture", "SetTeams", ex);
            }
        }

        private void RoundRobin()
        {
            try
            {
                for (int i = 0; i < teamsA.Count; i++)
                {
                    for (int j = i + 1; j < teamsA.Count(); j++)
                    {
                        pairs.Add(Tuple.Create(teamsA[i], teamsA[j]));
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.InsertError("League", "Fixture", "RoundRobin", ex);
            }
        }
        private void SetFixture()
        {
            try
            {
                for (int i = 0; i <= 17; i++)
                {
                    pairsTmp.Add(pairs.First());

                    if (i == 17)
                    {
                        allPairs.AddRange(pairs);
                        allFixtures.Add(new List<Tuple<Team, Team>>(pairs));
                        break;
                    }

                    for (int j = 0; j < pairs.Count(); j++)
                    {
                        bool exist = true;
                        for (int k = 0; k < pairsTmp.Count; k++)
                        {
                            //Debug.Write(pairsTmp[k].Item1.TeamId);
                            //Debug.Write(" ");
                            //Debug.Write(pairsTmp[k].Item2.TeamId);
                            //Debug.WriteLine(" F ");
                            //Debug.Write(pairs[j].Item1.TeamId);
                            //Debug.Write(" ");
                            //Debug.WriteLine(pairs[j].Item2.TeamId);
                            //Debug.WriteLine("-------");

                            if (pairsTmp[k].Item1.TeamId != pairs[j].Item1.TeamId && pairsTmp[k].Item1.TeamId != pairs[j].Item2.TeamId &&
                                pairsTmp[k].Item2.TeamId != pairs[j].Item1.TeamId && pairsTmp[k].Item2.TeamId != pairs[j].Item2.TeamId)
                            {
                                exist = false; 
                            }
                            else
                            {
                                exist = true;
                            }
                        }

                        if (exist == false)
                        {
                            pairsTmp.Add(pairs[j]);
                            pairs.Remove(pairs[j]);

                            if (pairsTmp.Count() % (teamsA.Count / 2) == 0)
                            {
                                //pairsTmp = pairsTmp.OrderBy(p => Guid.NewGuid()).ToList();
                                allPairs.AddRange(pairsTmp);
                                allFixtures.Add(new List<Tuple<Team, Team>>(pairsTmp));
                                pairsTmp.Clear();
                                pairs.Remove(pairs.First());
                            }
                        }
                    }
                }
                if (allFixtures.Count == 17) { }
            }
            catch (Exception ex)
            {
                ErrorHandling.InsertError("League", "Fixture", "SetFixture", ex);
            }
        }
    }
}