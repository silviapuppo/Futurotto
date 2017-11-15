using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise09;

namespace TestBlock03
{
    [TestClass]
    public class TestExercise09
    {
        [TestMethod]
        public void TestTurnUpperCase()
        {
            string str = "We are living in a <upcase>yellow submarine</upcase>";
            string result = "We are living in a YELLOW SUBMARINE";

            Class9.TurnUpperCase(str);

            StringAssert.Equals(result, str);
        }

        [TestMethod]
        public void TestTurnUpperCaseMultiple()
        {
            string str = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else";
            string result = "We are living in a YELLOW SUBMARINE. We don't have ANYTHING else";

            Class9.TurnUpperCase(str);

            StringAssert.Equals(result, str);
        }
    }
}