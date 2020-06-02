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
            //RoundRobin();
            SetFixtures();
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
            List<int> revolverL1 = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 };
            List<int> revolverR1 = new List<int>() { 7, 6, 5, 4, 3, 2, 1, 0, 17, 16, 15, 14, 13, 12, 11, 10, 9 };
            //List<int> revolverL2 = new List<int>() {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 0 };
            //List<int> revolverR2 = new List<int>() { 9,10, 11, 12, 13, 14, 15, 16, 17, 16, 15, 14, 13, 12, 11, 10, 9};

            List<int> revolverL2 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 0, 1, 2, 3, 4, 5, 6, 7, 8, 0 };
            List<int> revolverR2 = new List<int>() { 16, 15, 14, 13, 12, 11, 10, 9, 17, 16, 15, 14, 13, 12, 11, 10, 9 };

            List<int> revolverL3 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 0, 1, 2, 3, 4, 5, 6, 7, 8, 0 };
            List<int> revolverR3 = new List<int>() { 16, 15, 14, 13, 12, 11, 10, 9, 17, 16, 15, 14, 13, 12, 11, 10, 9 };

            //List<int> revolverL1 = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 };
            //List<int> revolverR1 = new List<int>() { 7, 6, 5, 4, 3, 2, 1, 0, 17, 16, 15, 14, 13, 12, 11, 10, 9 };

            //List<int> revolverL2 = new List<int>() { 17, 10, 11, 12, 13, 14, 15, 16, 0, 1, 2, 3, 4, 5, 6, 7,8, 9 };
            //List<int> revolverR2 = new List<int>() { 17, 16, 15, 14, 13, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };

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
                        if (f % 2 == 0)
                        {
                            fixture.Add(Tuple.Create(teams[revolverL1[i]], teams[revolverR1[j]]));
                        }
                        else
                        {
                            fixture.Add(Tuple.Create(teams[revolverR1[j]], teams[revolverL1[i]]));
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
                            //revolverL2[leftSide + 1] = revolverL2[leftSide];

                            leftSide++;
                            rightSide--;
                            break;
                        }
                    }
                    allFixtures.Add(fixture);

                }

                List<List<Tuple<Team, Team>>> rematches = new List<List<Tuple<Team, Team>>>();

                for (int x = 0; x < allFixtures.Count; x++)
                {
                    List<Tuple<Team, Team>> fixture = new List<Tuple<Team, Team>>();
                    for (int y = 0; y < allFixtures[x].Count(); y++)
                    {
                        fixture.Add(Tuple.Create(allFixtures[x][y].Item2, allFixtures[x][y].Item1));

                        if (y == (teams.Count() / 2) - 1)
                        {
                            rematches.Add(fixture);
                        }
                    }
                }

                allFixtures.AddRange(rematches);
            }
            catch (Exception ex)
            {
                ErrorHandling.InsertError("League", "Fixture", "RoundRobin", ex);
            }
        }

        private void SetFixtures()
        {
            try
            {
                List<Tuple<Team, Team>> fixture;
                fixture = new List<Tuple<Team, Team>>();
                //1
                fixture.Add(Tuple.Create(teams[0], teams[17]));
                fixture.Add(Tuple.Create(teams[1], teams[16]));
                fixture.Add(Tuple.Create(teams[2], teams[15]));
                fixture.Add(Tuple.Create(teams[3], teams[14]));
                fixture.Add(Tuple.Create(teams[4], teams[13]));
                fixture.Add(Tuple.Create(teams[5], teams[12]));
                fixture.Add(Tuple.Create(teams[6], teams[11]));
                fixture.Add(Tuple.Create(teams[7], teams[10]));
                fixture.Add(Tuple.Create(teams[8], teams[9]));

                allFixtures.Add(fixture);
                //2
                fixture = new List<Tuple<Team, Team>>();
                fixture.Add(Tuple.Create(teams[10], teams[8]));
                fixture.Add(Tuple.Create(teams[17], teams[9]));
                fixture.Add(Tuple.Create(teams[11], teams[7]));
                fixture.Add(Tuple.Create(teams[12], teams[6]));
                fixture.Add(Tuple.Create(teams[13], teams[5]));
                fixture.Add(Tuple.Create(teams[14], teams[4]));
                fixture.Add(Tuple.Create(teams[15], teams[3]));
                fixture.Add(Tuple.Create(teams[16], teams[2]));
                fixture.Add(Tuple.Create(teams[0], teams[1]));

                allFixtures.Add(fixture);
                //3
                fixture = new List<Tuple<Team, Team>>();
                fixture.Add(Tuple.Create(teams[2], teams[0]));
                fixture.Add(Tuple.Create(teams[3], teams[16]));
                fixture.Add(Tuple.Create(teams[1], teams[17]));
                fixture.Add(Tuple.Create(teams[4], teams[15]));
                fixture.Add(Tuple.Create(teams[5], teams[14]));
                fixture.Add(Tuple.Create(teams[6], teams[13]));
                fixture.Add(Tuple.Create(teams[7], teams[12]));
                fixture.Add(Tuple.Create(teams[8], teams[11]));
                fixture.Add(Tuple.Create(teams[9], teams[10]));

                allFixtures.Add(fixture);
                //4
                fixture = new List<Tuple<Team, Team>>();
                fixture.Add(Tuple.Create(teams[11], teams[9]));
                fixture.Add(Tuple.Create(teams[12], teams[8]));
                fixture.Add(Tuple.Create(teams[13], teams[7]));
                fixture.Add(Tuple.Create(teams[17], teams[10]));
                fixture.Add(Tuple.Create(teams[14], teams[6]));
                fixture.Add(Tuple.Create(teams[15], teams[5]));
                fixture.Add(Tuple.Create(teams[16], teams[4]));
                fixture.Add(Tuple.Create(teams[0], teams[3]));
                fixture.Add(Tuple.Create(teams[1], teams[2]));

                allFixtures.Add(fixture);
                //5
                fixture = new List<Tuple<Team, Team>>();
                fixture.Add(Tuple.Create(teams[3], teams[1]));
                fixture.Add(Tuple.Create(teams[4], teams[0]));
                fixture.Add(Tuple.Create(teams[5], teams[16]));
                fixture.Add(Tuple.Create(teams[6], teams[15]));
                fixture.Add(Tuple.Create(teams[2], teams[17]));
                fixture.Add(Tuple.Create(teams[7], teams[14]));
                fixture.Add(Tuple.Create(teams[8], teams[13]));
                fixture.Add(Tuple.Create(teams[9], teams[12]));
                fixture.Add(Tuple.Create(teams[10], teams[11]));

                allFixtures.Add(fixture);
                //6
                fixture = new List<Tuple<Team, Team>>();
                fixture.Add(Tuple.Create(teams[12], teams[10]));
                fixture.Add(Tuple.Create(teams[13], teams[9]));
                fixture.Add(Tuple.Create(teams[14], teams[8]));
                fixture.Add(Tuple.Create(teams[15], teams[7]));
                fixture.Add(Tuple.Create(teams[16], teams[6]));
                fixture.Add(Tuple.Create(teams[17], teams[11]));
                fixture.Add(Tuple.Create(teams[0], teams[5]));
                fixture.Add(Tuple.Create(teams[1], teams[4]));
                fixture.Add(Tuple.Create(teams[2], teams[3]));

                allFixtures.Add(fixture);
                //7
                fixture = new List<Tuple<Team, Team>>();
                fixture.Add(Tuple.Create(teams[4], teams[2]));
                fixture.Add(Tuple.Create(teams[5], teams[1]));
                fixture.Add(Tuple.Create(teams[6], teams[0]));
                fixture.Add(Tuple.Create(teams[7], teams[16]));
                fixture.Add(Tuple.Create(teams[8], teams[15]));
                fixture.Add(Tuple.Create(teams[9], teams[14]));
                fixture.Add(Tuple.Create(teams[3], teams[17]));
                fixture.Add(Tuple.Create(teams[10], teams[13]));
                fixture.Add(Tuple.Create(teams[11], teams[12]));

                allFixtures.Add(fixture);
                //8
                fixture = new List<Tuple<Team, Team>>();
                fixture.Add(Tuple.Create(teams[13], teams[11]));
                fixture.Add(Tuple.Create(teams[14], teams[10]));
                fixture.Add(Tuple.Create(teams[15], teams[9]));
                fixture.Add(Tuple.Create(teams[16], teams[8]));
                fixture.Add(Tuple.Create(teams[0], teams[7]));
                fixture.Add(Tuple.Create(teams[1], teams[6]));
                fixture.Add(Tuple.Create(teams[2], teams[5]));
                fixture.Add(Tuple.Create(teams[17], teams[12]));
                fixture.Add(Tuple.Create(teams[3], teams[4]));

                allFixtures.Add(fixture);
                //9
                fixture = new List<Tuple<Team, Team>>();
                fixture.Add(Tuple.Create(teams[5], teams[3]));
                fixture.Add(Tuple.Create(teams[6], teams[2]));
                fixture.Add(Tuple.Create(teams[7], teams[1]));
                fixture.Add(Tuple.Create(teams[8], teams[0]));
                fixture.Add(Tuple.Create(teams[9], teams[16]));
                fixture.Add(Tuple.Create(teams[10], teams[15]));
                fixture.Add(Tuple.Create(teams[11], teams[14]));
                fixture.Add(Tuple.Create(teams[12], teams[13]));
                fixture.Add(Tuple.Create(teams[4], teams[17]));

                allFixtures.Add(fixture);
                //10
                fixture = new List<Tuple<Team, Team>>();
                fixture.Add(Tuple.Create(teams[14], teams[12]));
                fixture.Add(Tuple.Create(teams[15], teams[11]));
                fixture.Add(Tuple.Create(teams[16], teams[10]));
                fixture.Add(Tuple.Create(teams[0], teams[9]));
                fixture.Add(Tuple.Create(teams[1], teams[8]));
                fixture.Add(Tuple.Create(teams[2], teams[7]));
                fixture.Add(Tuple.Create(teams[3], teams[6]));
                fixture.Add(Tuple.Create(teams[17], teams[13]));
                fixture.Add(Tuple.Create(teams[4], teams[5]));

                allFixtures.Add(fixture);
                //11
                fixture = new List<Tuple<Team, Team>>();
                
                fixture.Add(Tuple.Create(teams[6], teams[4]));
                fixture.Add(Tuple.Create(teams[7], teams[3]));
                fixture.Add(Tuple.Create(teams[8], teams[2]));
                fixture.Add(Tuple.Create(teams[9], teams[1]));
                fixture.Add(Tuple.Create(teams[10], teams[0]));
                fixture.Add(Tuple.Create(teams[11], teams[16]));
                fixture.Add(Tuple.Create(teams[5], teams[17]));
                fixture.Add(Tuple.Create(teams[12], teams[15]));
                fixture.Add(Tuple.Create(teams[13], teams[14]));

                allFixtures.Add(fixture);
                //12
                fixture = new List<Tuple<Team, Team>>();
                fixture.Add(Tuple.Create(teams[15], teams[13]));
                fixture.Add(Tuple.Create(teams[16], teams[12]));
                fixture.Add(Tuple.Create(teams[0], teams[11]));
                fixture.Add(Tuple.Create(teams[1], teams[10]));
                fixture.Add(Tuple.Create(teams[2], teams[9]));
                fixture.Add(Tuple.Create(teams[17], teams[14]));
                fixture.Add(Tuple.Create(teams[3], teams[8]));
                fixture.Add(Tuple.Create(teams[4], teams[7]));
                fixture.Add(Tuple.Create(teams[5], teams[6]));

                allFixtures.Add(fixture);
                //13
                fixture = new List<Tuple<Team, Team>>();
                fixture.Add(Tuple.Create(teams[7], teams[5]));
                fixture.Add(Tuple.Create(teams[8], teams[4]));
                fixture.Add(Tuple.Create(teams[9], teams[3]));
                fixture.Add(Tuple.Create(teams[10], teams[2]));
                fixture.Add(Tuple.Create(teams[6], teams[17]));
                fixture.Add(Tuple.Create(teams[11], teams[1]));
                fixture.Add(Tuple.Create(teams[12], teams[0]));
                fixture.Add(Tuple.Create(teams[13], teams[16]));
                fixture.Add(Tuple.Create(teams[14], teams[15]));

                allFixtures.Add(fixture);
                //14
                fixture = new List<Tuple<Team, Team>>();
                fixture.Add(Tuple.Create(teams[16], teams[14]));
                fixture.Add(Tuple.Create(teams[0], teams[13]));
                fixture.Add(Tuple.Create(teams[1], teams[12]));
                fixture.Add(Tuple.Create(teams[17], teams[15])); 
                fixture.Add(Tuple.Create(teams[2], teams[11]));
                fixture.Add(Tuple.Create(teams[3], teams[10]));
                fixture.Add(Tuple.Create(teams[4], teams[9]));
                fixture.Add(Tuple.Create(teams[5], teams[8]));
                fixture.Add(Tuple.Create(teams[6], teams[7]));

                allFixtures.Add(fixture);
                //15
                fixture = new List<Tuple<Team, Team>>();
                fixture.Add(Tuple.Create(teams[8], teams[6]));
                fixture.Add(Tuple.Create(teams[9], teams[5]));
                fixture.Add(Tuple.Create(teams[7], teams[17]));
                fixture.Add(Tuple.Create(teams[10], teams[4]));
                fixture.Add(Tuple.Create(teams[11], teams[3]));
                fixture.Add(Tuple.Create(teams[12], teams[2]));
                fixture.Add(Tuple.Create(teams[13], teams[1]));
                fixture.Add(Tuple.Create(teams[14], teams[0]));
                fixture.Add(Tuple.Create(teams[15], teams[16]));

                allFixtures.Add(fixture);
                //16
                fixture = new List<Tuple<Team, Team>>();
                fixture.Add(Tuple.Create(teams[0], teams[15]));
                fixture.Add(Tuple.Create(teams[17], teams[16]));
                fixture.Add(Tuple.Create(teams[1], teams[14]));
                fixture.Add(Tuple.Create(teams[2], teams[13]));
                fixture.Add(Tuple.Create(teams[3], teams[12]));
                fixture.Add(Tuple.Create(teams[4], teams[11]));
                fixture.Add(Tuple.Create(teams[5], teams[10]));
                fixture.Add(Tuple.Create(teams[6], teams[9]));
                fixture.Add(Tuple.Create(teams[7], teams[8]));

                allFixtures.Add(fixture);
                //17
                fixture = new List<Tuple<Team, Team>>();
                fixture.Add(Tuple.Create(teams[8], teams[17]));
                fixture.Add(Tuple.Create(teams[9], teams[7]));
                fixture.Add(Tuple.Create(teams[10], teams[6]));
                fixture.Add(Tuple.Create(teams[11], teams[5]));
                fixture.Add(Tuple.Create(teams[12], teams[4]));
                fixture.Add(Tuple.Create(teams[13], teams[3]));
                fixture.Add(Tuple.Create(teams[14], teams[2]));
                fixture.Add(Tuple.Create(teams[15], teams[1]));
                fixture.Add(Tuple.Create(teams[16], teams[0]));

                allFixtures.Add(fixture);

                List<List<Tuple<Team, Team>>> rematches = new List<List<Tuple<Team, Team>>>();

                for (int x = 0; x < allFixtures.Count; x++)
                {
                    List<Tuple<Team, Team>> tmpFixture = new List<Tuple<Team, Team>>();
                    for (int y = 0; y < allFixtures[x].Count(); y++)
                    {
                        tmpFixture.Add(Tuple.Create(allFixtures[x][y].Item2, allFixtures[x][y].Item1));

                        if (y == (teams.Count() / 2) - 1)
                        {
                            rematches.Add(tmpFixture);
                        }
                    }
                }

                allFixtures.AddRange(rematches);

            }
            catch (Exception ex)
            {
                ErrorHandling.InsertError("League", "Fixture", "SetFixtures", ex);
            }
        }
    }
}