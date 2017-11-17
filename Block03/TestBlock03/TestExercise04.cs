using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise04;

namespace TestBlock03
{
    [TestClass]
    public class TestExercise04
    {
        [TestMethod]
        public void TestGetStringSubsets()
        {
            string[] arrayStr = { "test", "rock", "fun" };
            
            int k = 2;

            string[] result = SubsetsGenerator.GetStringSubsets(arrayStr, k);

            Assert.AreEqual("fun rock", result[0]);
            Assert.AreEqual("fun test", result[1]);
            
        }
    }
}
