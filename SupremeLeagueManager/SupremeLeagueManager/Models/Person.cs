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
        public PersonNationality Nationality { get; set; }
        public int Age { get; set; }

        public Person() { }

        public string GetFullName()
        {
            return Name + ' ' + Surname; 
        }

        public enum PersonNationality { Argentina = 1, Belgium, Brazil, Colombia, Croatia, France, Germany, Serbia, Spain, Uruguay, Wales};
    }
}