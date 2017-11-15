using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise05;
using CreatingAndUsingObjects;

namespace TestBlock03
{
    [TestClass]
    public class TestExercise05
    {
        [TestMethod]
        public void TestCreateTenCats()
        {
            Cat[] catFamily = Class5.CreateTenCats();

            Assert.AreEqual(10, catFamily.Length);

            for (int i = 0; i < 10; i++)
            {
                StringAssert.Equals("Ponci", catFamily[i].Name);
                StringAssert.Equals("Red", catFamily[i].Color);
            }
        }
    }
}
