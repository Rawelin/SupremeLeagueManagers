using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SupremeLeagueManager.Models.Match
{
    public class MatchStatistics
    {
        public bool LiveMatch { get; set; }
        public int HomeGoals { get; set; }
        public int AwayGoals { get; set; }
        public int HomeShots { get; set; }
        public int AwayShots { get; set; }
        public int HomeShotsOnTarget { get; set; }
        public int AwayShotsOnTarget { get; set; }
        public int HomeShotsOffTarget { get; set; }
        public int AwayShotsOffTarget { get; set; }
        public int MatchLength { get; set; }
        public int Counter { get; set; }
        public double ProgressBarShot { get; set; }
        public double ProgressBarShotOnTarget { get; set; }
        public double ProgressBarShotOffTarget { get; set; }
        public List<Scorer> HomeScorers { get; set; }
        public List<Scorer> AwayScorers { get; set; }

        public string IntervalId { get; set; }

        public MatchStatistics()
        {
            ProgressBarShot = 50;
            ProgressBarShotOnTarget = 50;
            ProgressBarShotOffTarget = 50;
            IntervalId = null;
            HomeScorers = new List<Scorer>();
            AwayScorers = new List<Scorer>();
        }
    }
}
