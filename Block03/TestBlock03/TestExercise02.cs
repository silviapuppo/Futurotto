using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise02;

namespace TestBlock03
{
    [TestClass]
    public class TestExercise02
    {
        [TestMethod]
        public void TestSumLongInt()
        {
            int[] array1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] array2 = { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            int[] sum = { 0, 1, 1, 1, 1, 1, 1, 1, 1, 1 };

            CollectionAssert.AreEqual(sum, LongIntAdder.SumLongInt(array1, array2));
        }

        [TestMethod]
        public void TestSum20000Digits()
        {
            int[] array1 = new int[20000];
            int[] array2 = new int[20000];
            int[] result = new int[20001];

            for (int i = 0; i < 20000; i++)
            {
                array1[i] = 3;
                array2[i] = 5;
                result[i] = 8;
            }
            result[20000] = 0;

            CollectionAssert.AreEqual(result, LongIntAdder.SumLongInt(array1, array2));
        }

        [TestMethod]
        public void TestSumLongIntDifferentDigits()
        {
            int[] array1 = { 3, 2, 1, 2 };
            int[] array2 = { 3, 5, 9 };
            int[] sum = { 6, 7, 0, 3, 0 };

            CollectionAssert.AreEqual(sum, LongIntAdder.SumLongInt(array1, array2));
        }
    }
}
