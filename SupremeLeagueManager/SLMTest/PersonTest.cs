using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SupremeLeagueManager.Models;

namespace SLMTest
{
    [TestClass]
    public class PersonTest
    {
        [TestMethod]
        public void GetFulnameTest()
        {
            Person person = new Person();
            person.Name = "Jurgen";
            person.Surname = "Klop";
            Assert.AreEqual(person.GetFullName(), "Jurgen Klop");
        }

        [TestMethod]
        public void GetNationalityFlag()
        {
            Person person = new Person();
            person.Nationality = Person.PersonNationality.Spain;

            Assert.AreEqual(person.GetNationalityFlag(), "Spain.png");

        }
    }
}
