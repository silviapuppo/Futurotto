using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise09;

namespace TestBlock04
{
    [TestClass]
    public class TestExercise09
    {
        [TestMethod]
        public void TestTimeToString()
        {
            Time moment = new Time(15, 30);

            Assert.AreEqual("15:30", moment.ToString());

        }

        [TestMethod]
        public void TestTimeSumDiff()
        {
            Time moment1 = new Time(15, 30);
            Time moment2 = new Time(17, 45);

            Assert.AreEqual("9:15", (moment1 + moment2).ToString());
            Assert.AreEqual("21:45", (moment1 - moment2).ToString());

        }

        [TestMethod]
        public void TestTimeConversion()
        {
            Time moment1 = new Time(15, 30);
            int moment2 = 700;

            Assert.AreEqual(930, (int)moment1);
            Assert.AreEqual("11:40", ((Time)moment2).ToString());

        }

    }
}
