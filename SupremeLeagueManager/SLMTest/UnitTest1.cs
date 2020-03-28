using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SupremeLeagueManager;

namespace SLMTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Test test = new Test();
            Assert.AreEqual(test.GetName(), "Supreme League Manager");
        }

        [TestMethod]
        public void TestMethod2()
        {
            Test test2 = new Test();
            Assert.AreEqual(test2.Sum(2, 2), 4);
        }
    }
}
