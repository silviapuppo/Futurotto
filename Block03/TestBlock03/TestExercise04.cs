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

            string[] result = Class1.GetStringSubsets(arrayStr, k);

            StringAssert.Equals("fun rock", result[0]);
            StringAssert.Equals("fun test", result[1]);
            
        }
    }
}
