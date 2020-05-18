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
        public List<List<Tuple<Team, Team>>> allFixtures = new List<List<Tuple<Team, Team>>>();
        public List<Team> teams = new List<Team>();

        public Fixture()
        {
            SetTeams();
            RoundRobin();
        }

        public List<List<Tuple<Team, Team>>> GetAllFixtures()
        {
            return allFixtures;
        }

        private void SetTeams()
        {
            try
            {
                teams = CRUD.GetTeams();
            }
            catch (Exception ex)
            {
                ErrorHandling.InsertError("League", "Fixture", "SetTeams", ex);
            }
        }

        private void RoundRobin()
        {
            List<int> revolverL1 = new List<int>() {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17};
            List<int> revolverR1 = new List<int>() {7, 6, 5, 4, 3, 2, 1, 0, 17, 16, 15, 14, 13, 12, 11, 10, 9};
            List<int> revolverL2 = new List<int>() {2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 0};
            List<int> revolverR2 = new List<int>() {10, 11, 12, 13, 14, 15, 16, 17, 0, 1, 2, 3, 4, 5, 6, 7, 8};

            int i, j, k;
            int leftSide = 0;
            int rightSide = (teams.Count / 2) - 1;

            try
            {
                for (int f = 0; f < teams.Count / 2; f++)
                {
                    List<Tuple<Team, Team>> fixture = new List<Tuple<Team, Team>>(); 
                    for (i = leftSide, j = rightSide, k = 0; ; i++, j++, k++)
                    {
                        if(f %2 == 0)
                        {
                            fixture.Add(Tuple.Create(teams[revolverL1[i]], teams[revolverR1[j]]));
                        }
                        else
                        {
                            fixture.Add(Tuple.Create(teams[revolverR1[j]],teams[revolverL1[i]]));
                        }
                       
                        if (k == (teams.Count / 2) -1)
                        {
                            leftSide++;
                            rightSide--;
                            break;
                        }
                    }
                    allFixtures.Add(fixture);
                }

                leftSide = 0;
                rightSide = (teams.Count / 2) - 1;

                for (int f = (teams.Count / 2); f < teams.Count - 1; f++)
                {
                    List<Tuple<Team, Team>> fixture = new List<Tuple<Team, Team>>();
                    for (i = leftSide, j = rightSide, k = 0; ; i++, j++, k++)
                    {
                        if (f % 2 == 0)
                        {
                            fixture.Add(Tuple.Create(teams[revolverR2[j]], teams[revolverL2[i]]));
                        }
                        else
                        {
                            fixture.Add(Tuple.Create(teams[revolverL2[i]], teams[revolverR2[j]]));
                        }
                        if (k == (teams.Count / 2) - 1)
                        {
                            leftSide++;
                            rightSide--;
                            break;
                        }
                    }
                    allFixtures.Add(fixture);
                }
            }
            catch (Exception ex)
            {
                ErrorHandling.InsertError("League", "Fixture", "RoundRobin", ex);
            }
        }
    }
}