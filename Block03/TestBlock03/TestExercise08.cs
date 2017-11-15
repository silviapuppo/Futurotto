using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise08;

namespace TestBlock03
{
    [TestClass]
    public class TestExercise08
    {
        [TestMethod]
        public void TestFindSubstringOccurrence()
        {
            string str = "I felt happy because I saw the others were happy " +
                "and because I knew I should feel happy, but I wasn’t really happy.";

            Assert.AreEqual(4, Class8.FindSubstringOccurrence(str, "happy"));
        }

        [TestMethod]
        public void TestFindSubstringOccurrenceInside()
        {
            string str = "I was inside an insidious side of a mountain with sid";

            Assert.AreEqual(3, Class8.FindSubstringOccurrence(str, "in"));
            Assert.AreEqual(4, Class8.FindSubstringOccurrence(str, "sid"));
        }

        [TestMethod]
        public void TestFindSubstringOccurrenceDifferentCase()
        {
            string str = "I was inSide an Insidious side of a mountaIn with SID";

            Assert.AreEqual(3, Class8.FindSubstringOccurrence(str, "in"));
            Assert.AreEqual(4, Class8.FindSubstringOccurrence(str, "SID"));
        }
    }
}
