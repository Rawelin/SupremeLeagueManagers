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
        public DateTime DOB { get; set; }

        public Person() { }

        public string GetFullName()
        {
            return Name + ' ' + Surname; 
        }

        public string GetNationalityFlag()
        {
            string flagName = Nationality + ".png";
            return flagName.Replace(" ", "");
        }

        public enum PersonNationality { Argentina = 10, Belgium = 20, Brazil = 30 , Colombia = 107, Croatia = 39,
                                        France = 61, Germany = 149, Serbia = 190 , Spain = 82, Uruguay = 223 , Wales  = 250};
    }
}