using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise01;

namespace TestBlock03
{
    [TestClass]
    public class TestExercise01
    {
        [TestMethod]
        public void TestCountWorkDaysTill()
        {
            DateTime startDate = new DateTime(2017, 11, 13);
            DateTime endDate = new DateTime(2017, 11, 21);
            
            Assert.AreEqual(6, Class1.CountWorkDaysTill(startDate, endDate));
        }

        [TestMethod]
        public void TestCountWorkDaysTillHoliday()
        {
            DateTime startDate = new DateTime(2017, 11, 13);
            DateTime endDate = new DateTime(2017, 12, 27);

            Assert.AreEqual(29, Class1.CountWorkDaysTill(startDate, endDate));
        }

        [TestMethod]
        public void TestCountWorkDaysTillOtherYear()
        {
            DateTime startDate = new DateTime(2017, 11, 13);
            DateTime endDate = new DateTime(2018, 01, 01);

            Assert.AreEqual(31, Class1.CountWorkDaysTill(startDate, endDate));
        }

        [TestMethod]
        public void TestCountWorkDaysHolyMonday()
        {
            DateTime startDate = new DateTime(2018, 03, 26);
            DateTime endDate = new DateTime(2018, 04, 04);

            Assert.AreEqual(6, Class1.CountWorkDaysTill(startDate, endDate));
        }


    }
}
