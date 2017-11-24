using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise10;

namespace TestBlock04
{
    [TestClass]
    public class TestExercise10
    {
        [TestMethod]
        public void TestEmployee()
        {
            Employee[] office = new Employee[4];

            office[0] = new HourlyWorker("Mario", 230, 7.10);
            office[1] = new HourlyWorker("Giovanna", 150, 6.60);
            office[2] = new SalaryWorker("Piero", 15000);
            office[3] = new SalaryWorker("Pina", 60000);

            Assert.AreEqual(1633, office[0].CalcPaidCheck());
            Assert.AreEqual(990, office[1].CalcPaidCheck());
            Assert.AreEqual(1250, office[2].CalcPaidCheck());
            Assert.AreEqual(5000, office[3].CalcPaidCheck());

        }

        [TestMethod]
        public void TestEmployeeZero()
        {
            Employee[] poorOffice = new Employee[2];

            poorOffice[0] = new Employee("Mario");
            poorOffice[1] = new HourlyWorker("Giovanna", 0, 6.60);

            Assert.AreEqual(0, poorOffice[0].CalcPaidCheck());
            Assert.AreEqual(0, poorOffice[1].CalcPaidCheck());


        }
    }
}
