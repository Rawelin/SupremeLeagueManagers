using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SupremeLeagueManager.Models
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Nationality { get; set; }
        public int Age { get; set; }

        public Person() { }

        public string GetFullName()
        {
            return Name + ' ' + Surname; 
        }
    }
}