using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SupremeLeagueManager
{
    public class Test
    {
        private string Name;
        private double Number;

        public Test() { }
      
        public string GetName ()
        {
            return Name = "Supreme League Manager";
        }

        public double Sum(double p1, double p2)
        {
            Number = p1 + p2;

            return Number;
        }

    }
}