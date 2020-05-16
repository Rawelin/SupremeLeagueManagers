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
        public List<Tuple<Team, Team>> pairs2 = new List<Tuple<Team, Team>>();
        public List<Tuple<Team, Team>> pairFixtures = new List<Tuple<Team, Team>>();

        public List<Team> teamsA = new List<Team>();
        public List<Team> teamsB = new List<Team>();

        public Fixture()
        {
            SetTeams();
            SetFixture();
        }

        private void SetFixture()
        {
            try
            {
                for (int i = 0; i < teamsA.Count; i++)
                {
                    for (int j = 0; j < teamsB.Count() - 1; j++)
                    {
                        pairs.Add(Tuple.Create(teamsA[i], teamsB[j + 1]));
                    }
                    teamsB.RemoveAt(0);
                }

                
                
                for (int i = 0; i < 17; i++)
                {
                    pairs2.Add(pairs.First());
                   
                   
                    for (int j = 0; j < pairs.Count(); j++)
                    {
                        
                        bool exist = true;
                        for (int k = 0; k < pairs2.Count; k++)
                        {
                            Debug.Write(pairs2[k].Item1.TeamId);
                            Debug.Write(" ");
                            Debug.Write(pairs2[k].Item2.TeamId);
                            Debug.WriteLine(" F ");
                            Debug.Write(pairs[j].Item1.TeamId);
                            Debug.Write(" ");
                            Debug.WriteLine(pairs[j].Item2.TeamId);
                            Debug.WriteLine("-------");

                            if (pairs2[k].Item1.TeamId != pairs[j].Item1.TeamId && pairs2[k].Item1.TeamId != pairs[j].Item2.TeamId &&
                                pairs2[k].Item2.TeamId != pairs[j].Item1.TeamId && pairs2[k].Item2.TeamId != pairs[j].Item2.TeamId)
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
                            pairs2.Add(pairs[j]);
                            pairs.Remove(pairs[j]);
                            exist = false;

                            if (pairs2.Count() % 9 == 0)
                            {
                                pairFixtures.AddRange(pairs2);
                                pairs2.Clear();
                                pairs.Remove(pairs.First());
                            }
                        }
                    }
                }


                //pairs2.Add(pairs[0]);

                //Debug.Write(pairs2[0].Item1.City);
                //Debug.Write("-");
                //Debug.Write(pairs2[0].Item2.City);
                //Debug.WriteLine("");

                //int fixture = 1;


                //for (int i = 0; i < pairs2.Count + 1;)
                //{
                //    for (int j = 0; j < pairs.Count; j++)
                //    {
                //        if (pairs2[i].Item1.TeamId != pairs[j].Item1.TeamId && pairs2[i].Item2.TeamId != pairs[j].Item2.TeamId &&
                //            pairs2[i].Item2.TeamId != pairs[j].Item1.TeamId && pairs2[i].Item1.TeamId != pairs[j].Item2.TeamId)
                //        {

                //            //var exist = pairs2.Where(f => f.Item1.TeamId != pairs[j].Item1.TeamId &&
                //            //                              f.Item2.TeamId != pairs[j].Item2.TeamId &&
                //            //                              f.Item2.TeamId != pairs[j].Item1.TeamId &&
                //            //                              f.Item1.TeamId != pairs[j].Item2.TeamId).First();

                //            var check = pairs2.Where(f => f != pairs[j]).First();
                //        if (!(check is null))
                //            {
                //                pairs2.Add(pairs[j]);
                //                pairs.RemoveAt(j);
                //                i++;

                //                Debug.Write(pairs2[i].Item1.Name);
                //                Debug.Write(" ");
                //                Debug.Write(pairs2[i].Item1.City);
                //                Debug.Write(" - ");
                //                Debug.Write(pairs2[i].Item2.Name);
                //                Debug.Write(" ");
                //                Debug.Write(pairs2[i].Item2.City);
                //                Debug.WriteLine("");

                //                exist = false;
                //                    fixture++; 
                //                    Debug.Write(fixture);
                //                    Debug.WriteLine("");
                //                // add pairs2 to pairFixtures
                //                pairFixtures.AddRange(pairs2);
                //                // clear pairs2
                //                pairs2.Clear(); 

                //                }

                //            }


                //        }
                //        if (fixture == 18)
                //        {
                //            break;
                //        }
                //    }
                //}
            }
            catch (Exception ex)
            {
                Debug.Write(ex.ToString());
            }
        }

        private void SetTeams()
        {
            try
            {
                teamsA = CRUD.GetTeams();
                teamsB = CRUD.GetTeams();
            }
            catch (Exception)
            {

            }
        }
    }
}