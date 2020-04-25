﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SupremeLeagueManager.Models.TeamTest
{
    public class Provider
    {
        public int? TeamId { get; set; }
        public int? FormationId { get; set; }
        public int Player1 { get; set; }
        public int Player2 { get; set; }
        public int Status { get; set; }
    }
}