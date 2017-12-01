using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise04;

namespace TestBlock04
{
    [TestClass]
    public class TestExercise04
    {
        [TestMethod]
        public void TestMyComplexZeroOperations()
        {
            MyComplex zero = new MyComplex();
            MyComplex first = new MyComplex(2, 3);

            Assert.AreEqual(0, zero.Real);
            Assert.AreEqual(0, zero.Imag);
            Assert.AreEqual(2, first.Real);
            Assert.AreEqual(3, first.Imag);
        }

        [TestMethod]
        public void TestMyComplexFirstOperations()
        {
            MyComplex first = new MyComplex(2, 3);

            first.SetValue(3, 4);

            Assert.AreEqual("3 +4i", first.ToString());
        }

        [TestMethod]
        public void TestMyComplexSecondOperations()
        {
            MyComplex real = new MyComplex(2, 0);
            MyComplex imag = new MyComplex(0, 2);
            MyComplex first = new MyComplex(2, 3);
            MyComplex second = new MyComplex(2, 3);

            Assert.IsTrue(real.IsReal());
            Assert.IsTrue(imag.IsImaginary());
            Assert.IsTrue(first.Equals(2, 3));
            Assert.IsTrue(first.Equals(second));
        }

        [TestMethod]
        public void TestMyComplexThirdOperations()
        {
            MyComplex first = new MyComplex(2, 2);
            MyComplex second = new MyComplex(0, 0);
            MyComplex third = new MyComplex(-2, -2);


            Assert.AreEqual(Math.Sqrt(8), first.Magnitude());
            Assert.AreEqual(Math.PI / 4, first.Argument());
            Assert.AreEqual(double.NaN, second.Argument());
            Assert.AreEqual(-Math.PI * 3/ 4, third.Argument());
            Assert.AreEqual("2 -2i", first.Conjugate().ToString());
        }

        [TestMethod]
        public void TestMyComplexFourthOperations()
        {
            MyComplex zero = new MyComplex(0, 0);
            MyComplex first = new MyComplex(3, 3);
            MyComplex second = new MyComplex(2, 2);
            MyComplex third = new MyComplex(3, 3);
            
            Assert.AreEqual("5 +5i", first.Add(second).ToString());
            Assert.AreEqual("3 +3i", first.Sub(second).ToString());
            Assert.AreEqual("0 +12i", first.Multiply(second).ToString());
            Assert.AreEqual("0 +1,5i", third.Divide(second).ToString());
            Assert.AreEqual("NaN +NaNi", second.Divide(zero).ToString());
        }

    }
}
