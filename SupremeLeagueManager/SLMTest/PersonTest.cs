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
    }
}
