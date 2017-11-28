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
            SimpleList<int> numbers = new SimpleList<int>();

            numbers.ListAdd(1);
            numbers.ListAdd(2);

            Assert.AreEqual(2, numbers.Count);
            Assert.AreEqual(1, numbers.Start.Value);
            Assert.AreEqual(2, numbers.Start.Next.Value);
        }

        [TestMethod]
        public void TestListRemoveAt()
        {
            SimpleList<int> numbers = new SimpleList<int>();

            numbers.ListAdd(1);
            numbers.ListAdd(2);
            numbers.ListAdd(3);
            numbers.ListRemoveAt(1);

            Assert.AreEqual(2, numbers.Count);
            Assert.AreEqual(1, numbers.Start.Value);
            Assert.AreEqual(3, numbers.Start.Next.Value);
        }

        [TestMethod]
        public void TestListRemoveFisrt()
        { 
            SimpleList<int> chars = new SimpleList<int>();

            chars.ListAdd(1);
            chars.ListAdd(2);
            chars.ListAdd(3);
            chars.ListRemoveAt(0);

            Assert.AreEqual(2, chars.Count);
            Assert.AreEqual(2, chars.Start.Value);
            Assert.AreEqual(3, chars.Start.Next.Value);
        }


        [TestMethod]
        public void TestListToArray()
        {
            SimpleList<char> chars = new SimpleList<char>();
            char[] expected = { 'a', 'b', 'c' };

            chars.ListAdd('a');
            chars.ListAdd('b');
            chars.ListAdd('c');

            CollectionAssert.AreEqual(expected, chars.ListToArray());
            Assert.AreEqual(3, chars.Count);
        }

        [TestMethod]
        public void TestArrayToList()
        {
            double[] values = { 0.1, 5.88, 23.666 };
            SimpleList<double> numbers = SimpleList<double>.ArrayToList(values);

            Assert.AreEqual(3, numbers.Count);
            Assert.AreEqual(0.1, numbers.Start.Value);
            Assert.AreEqual(5.88, numbers.Start.Next.Value);
            Assert.AreEqual(23.666, numbers.Start.Next.Next.Value);
        }

        [TestMethod]
        public void TestListReverse()
        {
            SimpleList<int> numbers = new SimpleList<int>();

            numbers.ListAdd(1);
            numbers.ListAdd(2);
            numbers.ListAdd(3);
            numbers.ListReverse();

            Assert.AreEqual(3, numbers.Count);
            Assert.AreEqual(3, numbers.Start.Value);
            Assert.AreEqual(2, numbers.Start.Next.Value);
            Assert.AreEqual(1, numbers.Start.Next.Next.Value);
        }



    }


}
