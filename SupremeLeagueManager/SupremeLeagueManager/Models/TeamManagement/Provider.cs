using SupremeLeagueManager.Models.SinglePlayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SupremeLeagueManager.Models.TeamTest
{
    public class Provider
    {
        public int Exsist { get; set; }
        public int? TeamId { get; set; }
        public int? FormationId { get; set; }
        public int Player1 { get; set; }
        public int Player2 { get; set; }
        public int Status { get; set; }
        public Player PlayerOne { get; set;}
        public Player PlayerTwo { get; set;}
        public SliderObject SliderObject { get; set; }
        public SinglePlayerM SinglePlayer { get; set; }
        public string ErrorMessage { get; set; }
    }
}