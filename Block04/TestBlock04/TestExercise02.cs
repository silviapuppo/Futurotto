using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise02;

namespace TestBlock04
{
    [TestClass]
    public class TestExercise02
    {
        [TestMethod]
        public void TestListAdd()
        {
            SimpleList<int> numbers = new SimpleList<int>(null);

            numbers.ListAdd(1);
            numbers.ListAdd(2);

            Assert.AreEqual(2, numbers.Count);
            Assert.AreEqual(1, numbers.Start.Value);
            Assert.AreEqual(2, numbers.Start.Next.Value);
        }

        [TestMethod]
        public void TestListRemoveAt()
        {
            SimpleList<int> numbers = new SimpleList<int>(null);

            numbers.ListAdd(1);
            numbers.ListAdd(2);
            numbers.ListAdd(3);
            numbers.ListRemoveAt(2);

            Assert.AreEqual(2, numbers.Count);
            Assert.AreEqual(1, numbers.Start.Value);
            Assert.AreEqual(3, numbers.Start.Next.Value);
        }


        [TestMethod]
        public void TestListToArray()
        {
            SimpleList<char> numbers = new SimpleList<char>(null);
            char[] expected = { 'a', 'b', 'c' };

            numbers.ListAdd('a');
            numbers.ListAdd('b');
            numbers.ListAdd('c');

            CollectionAssert.AreEqual(expected, numbers.ListToArray());
            Assert.AreEqual(3, numbers.Count);
        }

    }


}
