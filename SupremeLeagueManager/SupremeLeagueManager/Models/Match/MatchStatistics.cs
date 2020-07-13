using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SupremeLeagueManager.Models.Match
{
    public class MatchStatistics
    {
        public int HomeGoals { get; set; }
        public int AwayGoals { get; set; }
        public int HomeShots { get; set; }
        public int AwayShots { get; set; }
        public int HomeShotsOnTarget { get; set; }
        public int AwayShotsOnTarget { get; set; }
        public int MatchLength { get; set; }
        public int Counter { get; set; }
        public double ProgressBarShot { get; set; }

        public MatchStatistics()
        {
            ProgressBarShot = 50;
        }
    }
}
