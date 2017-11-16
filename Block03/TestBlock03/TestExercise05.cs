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

            for (int i = 1; i <= 10; i++)
            {
                Assert.AreEqual("Cat" + i, catFamily[i -1].Name);
                Assert.AreEqual("Red", catFamily[i -1].Color);
            }
        }

    }
}
