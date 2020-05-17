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
        public List<Team> teams = new List<Team>();


        public Fixture()
        {
            SetTeams();
            RoundRobin();
            SetFixtures();
            //SetFixture();
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
                teams = CRUD.GetTeams();
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
                for (int i = 0; i < teams.Count; i++)
                {
                    for (int j = i + 1; j < teams.Count(); j++)
                    {
                        if ((teams[i].TeamId + teams[j].TeamId) % 2 == 0)
                        {
                            pairs.Add(Tuple.Create(teams[j], teams[i]));
                        }
                        else
                        {
                            pairs.Add(Tuple.Create(teams[i], teams[j]));
                        }

                    }
                }

                //pairs = pairs.OrderBy(p => p.Item1.TeamId).ToList();

                //for (int i = 0; i < pairs.Count; i++)
                //{
                //    Debug.Write(pairs[i].Item1.TeamId);
                //    Debug.Write("-");
                //    Debug.Write(pairs[i].Item2.TeamId);
                //    Debug.Write("     ");
                //}
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
                fixture.Add(Tuple.Create(teams[17], teams[9]));
                fixture.Add(Tuple.Create(teams[10], teams[8]));
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
                fixture.Add(Tuple.Create(teams[1], teams[17]));
                fixture.Add(Tuple.Create(teams[2], teams[0]));
                fixture.Add(Tuple.Create(teams[3], teams[16]));
                fixture.Add(Tuple.Create(teams[4], teams[15]));
                fixture.Add(Tuple.Create(teams[5], teams[14]));
                fixture.Add(Tuple.Create(teams[6], teams[13]));
                fixture.Add(Tuple.Create(teams[7], teams[12]));
                fixture.Add(Tuple.Create(teams[8], teams[11]));
                fixture.Add(Tuple.Create(teams[9], teams[10]));

                allFixtures.Add(fixture);
                //4
                fixture = new List<Tuple<Team, Team>>();
                fixture.Add(Tuple.Create(teams[17], teams[10]));
                fixture.Add(Tuple.Create(teams[11], teams[9]));
                fixture.Add(Tuple.Create(teams[12], teams[8]));
                fixture.Add(Tuple.Create(teams[13], teams[7]));
                fixture.Add(Tuple.Create(teams[14], teams[6]));
                fixture.Add(Tuple.Create(teams[15], teams[5]));
                fixture.Add(Tuple.Create(teams[16], teams[4]));
                fixture.Add(Tuple.Create(teams[0], teams[3]));
                fixture.Add(Tuple.Create(teams[1], teams[2]));

                allFixtures.Add(fixture);
                //5
                fixture = new List<Tuple<Team, Team>>();
                fixture.Add(Tuple.Create(teams[2], teams[17]));
                fixture.Add(Tuple.Create(teams[3], teams[1]));
                fixture.Add(Tuple.Create(teams[4], teams[0]));
                fixture.Add(Tuple.Create(teams[5], teams[16]));
                fixture.Add(Tuple.Create(teams[6], teams[15]));
                fixture.Add(Tuple.Create(teams[7], teams[14]));
                fixture.Add(Tuple.Create(teams[8], teams[13]));
                fixture.Add(Tuple.Create(teams[9], teams[12]));
                fixture.Add(Tuple.Create(teams[10], teams[11]));

                allFixtures.Add(fixture);
                //6
                fixture = new List<Tuple<Team, Team>>();
                fixture.Add(Tuple.Create(teams[17], teams[11]));
                fixture.Add(Tuple.Create(teams[12], teams[10]));
                fixture.Add(Tuple.Create(teams[13], teams[9]));
                fixture.Add(Tuple.Create(teams[14], teams[8]));
                fixture.Add(Tuple.Create(teams[15], teams[7]));
                fixture.Add(Tuple.Create(teams[16], teams[6]));
                fixture.Add(Tuple.Create(teams[0], teams[5]));
                fixture.Add(Tuple.Create(teams[1], teams[4]));
                fixture.Add(Tuple.Create(teams[2], teams[3]));

                allFixtures.Add(fixture);
                //7
                fixture = new List<Tuple<Team, Team>>();
                fixture.Add(Tuple.Create(teams[3], teams[17]));
                fixture.Add(Tuple.Create(teams[4], teams[2]));
                fixture.Add(Tuple.Create(teams[5], teams[1]));
                fixture.Add(Tuple.Create(teams[6], teams[0]));
                fixture.Add(Tuple.Create(teams[7], teams[16]));
                fixture.Add(Tuple.Create(teams[8], teams[15]));
                fixture.Add(Tuple.Create(teams[9], teams[14]));
                fixture.Add(Tuple.Create(teams[10], teams[13]));
                fixture.Add(Tuple.Create(teams[11], teams[12]));

                allFixtures.Add(fixture);
                //8
                fixture = new List<Tuple<Team, Team>>();
                fixture.Add(Tuple.Create(teams[17], teams[12]));
                fixture.Add(Tuple.Create(teams[13], teams[11]));
                fixture.Add(Tuple.Create(teams[14], teams[10]));
                fixture.Add(Tuple.Create(teams[15], teams[9]));
                fixture.Add(Tuple.Create(teams[16], teams[8]));
                fixture.Add(Tuple.Create(teams[0], teams[7]));
                fixture.Add(Tuple.Create(teams[1], teams[6]));
                fixture.Add(Tuple.Create(teams[2], teams[5]));
                fixture.Add(Tuple.Create(teams[3], teams[4]));

                allFixtures.Add(fixture);
                //9
                fixture = new List<Tuple<Team, Team>>();
                fixture.Add(Tuple.Create(teams[4], teams[17]));
                fixture.Add(Tuple.Create(teams[5], teams[3]));
                fixture.Add(Tuple.Create(teams[6], teams[2]));
                fixture.Add(Tuple.Create(teams[7], teams[1]));
                fixture.Add(Tuple.Create(teams[8], teams[0]));
                fixture.Add(Tuple.Create(teams[9], teams[16]));
                fixture.Add(Tuple.Create(teams[10], teams[15]));
                fixture.Add(Tuple.Create(teams[11], teams[14]));
                fixture.Add(Tuple.Create(teams[12], teams[13]));


                allFixtures.Add(fixture);
                //10
                fixture = new List<Tuple<Team, Team>>();
                fixture.Add(Tuple.Create(teams[17], teams[13]));
                fixture.Add(Tuple.Create(teams[14], teams[12]));
                fixture.Add(Tuple.Create(teams[15], teams[11]));
                fixture.Add(Tuple.Create(teams[16], teams[10]));
                fixture.Add(Tuple.Create(teams[0], teams[9]));
                fixture.Add(Tuple.Create(teams[1], teams[8]));
                fixture.Add(Tuple.Create(teams[2], teams[7]));
                fixture.Add(Tuple.Create(teams[3], teams[6]));
                fixture.Add(Tuple.Create(teams[4], teams[5]));

                allFixtures.Add(fixture);
                //11
                fixture = new List<Tuple<Team, Team>>();
                fixture.Add(Tuple.Create(teams[5], teams[17]));
                fixture.Add(Tuple.Create(teams[6], teams[4]));
                fixture.Add(Tuple.Create(teams[7], teams[3]));
                fixture.Add(Tuple.Create(teams[8], teams[2]));
                fixture.Add(Tuple.Create(teams[9], teams[1]));
                fixture.Add(Tuple.Create(teams[10], teams[0]));
                fixture.Add(Tuple.Create(teams[11], teams[16]));
                fixture.Add(Tuple.Create(teams[12], teams[15]));
                fixture.Add(Tuple.Create(teams[13], teams[14]));

                allFixtures.Add(fixture);
                //12
                fixture = new List<Tuple<Team, Team>>();
                fixture.Add(Tuple.Create(teams[17], teams[14]));
                fixture.Add(Tuple.Create(teams[15], teams[13]));
                fixture.Add(Tuple.Create(teams[16], teams[12]));
                fixture.Add(Tuple.Create(teams[0], teams[11]));
                fixture.Add(Tuple.Create(teams[1], teams[10]));
                fixture.Add(Tuple.Create(teams[2], teams[9]));
                fixture.Add(Tuple.Create(teams[3], teams[8]));
                fixture.Add(Tuple.Create(teams[4], teams[7]));
                fixture.Add(Tuple.Create(teams[5], teams[6]));

                allFixtures.Add(fixture);
                //13
                fixture = new List<Tuple<Team, Team>>();
                fixture.Add(Tuple.Create(teams[6], teams[17]));
                fixture.Add(Tuple.Create(teams[7], teams[5]));
                fixture.Add(Tuple.Create(teams[8], teams[4]));
                fixture.Add(Tuple.Create(teams[9], teams[3]));
                fixture.Add(Tuple.Create(teams[10], teams[2]));
                fixture.Add(Tuple.Create(teams[11], teams[1]));
                fixture.Add(Tuple.Create(teams[12], teams[0]));
                fixture.Add(Tuple.Create(teams[13], teams[16]));
                fixture.Add(Tuple.Create(teams[14], teams[15]));

                allFixtures.Add(fixture);
                //14
                fixture = new List<Tuple<Team, Team>>();
                fixture.Add(Tuple.Create(teams[17], teams[15]));
                fixture.Add(Tuple.Create(teams[16], teams[14]));
                fixture.Add(Tuple.Create(teams[0], teams[13]));
                fixture.Add(Tuple.Create(teams[1], teams[12]));
                fixture.Add(Tuple.Create(teams[2], teams[11]));
                fixture.Add(Tuple.Create(teams[3], teams[10]));
                fixture.Add(Tuple.Create(teams[4], teams[9]));
                fixture.Add(Tuple.Create(teams[5], teams[8]));
                fixture.Add(Tuple.Create(teams[6], teams[7]));

                allFixtures.Add(fixture);
                //15
                fixture = new List<Tuple<Team, Team>>();
                fixture.Add(Tuple.Create(teams[7], teams[17]));
                fixture.Add(Tuple.Create(teams[8], teams[6]));
                fixture.Add(Tuple.Create(teams[9], teams[5]));
                fixture.Add(Tuple.Create(teams[10], teams[4]));
                fixture.Add(Tuple.Create(teams[11], teams[3]));
                fixture.Add(Tuple.Create(teams[12], teams[2]));
                fixture.Add(Tuple.Create(teams[13], teams[1]));
                fixture.Add(Tuple.Create(teams[14], teams[0]));
                fixture.Add(Tuple.Create(teams[15], teams[16]));

                allFixtures.Add(fixture);
                //16
                fixture = new List<Tuple<Team, Team>>();
                fixture.Add(Tuple.Create(teams[17], teams[16]));
                fixture.Add(Tuple.Create(teams[0], teams[15]));
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


            }
            catch (Exception ex)
            {
                ErrorHandling.InsertError("League", "Fixture", "SetFixtures", ex);
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

                            if (pairsTmp.Count() % (teams.Count / 2) == 0)
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