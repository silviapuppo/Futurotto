using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise06;

namespace TestBlock04
{
    [TestClass]
    public class TestExercise06
    {
        [TestMethod]
        public void TestMyPolinomialDegree()
        {
            MyPolynomial pol1 = new MyPolynomial(1, 1);
            MyPolynomial pol2 = new MyPolynomial(2, 2, 2);
            MyPolynomial pol4 = new MyPolynomial(4, 4, 4, 4, 4);

            Assert.AreEqual(1, pol1.GetDegree());
            Assert.AreEqual(2, pol2.GetDegree());
            Assert.AreEqual(4, pol4.GetDegree());
        }

        [TestMethod]
        public void TestMyPolinomial()
        {
            MyPolynomial pol1 = new MyPolynomial(1, 1);
            MyPolynomial pol2 = new MyPolynomial(2, 2, 2);
            MyPolynomial pol4 = new MyPolynomial(4, 4, 4, 0, 0);

            Assert.AreEqual("+2x +2 ", pol1.Add(pol1).ToString());
            Assert.AreEqual("+2x^2 +3x +3 ", pol1.Add(pol2).ToString());
            Assert.AreEqual("+4x^2 +5x +5 ", pol1.Add(pol4).ToString());
        }

        [TestMethod]
        public void TestMyPolinomialMultiply()
        {
            MyPolynomial pol1 = new MyPolynomial(1, 1);
            MyPolynomial pol2 = new MyPolynomial(2, 2, 2);
            MyPolynomial pol4 = new MyPolynomial(0, 0, 4, 4, 4);

            Assert.AreEqual("+1x^2 +2x +1 ", pol1.Multiply(pol1).ToString());
            Assert.AreEqual("+2x^3 +4x^2 +4x +2 ", pol1.Multiply(pol2).ToString());
            Assert.AreEqual("+4x^5 +8x^4 +8x^3 +4x^2 ", pol1.Multiply(pol4).ToString());
        }


    }
}
