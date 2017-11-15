﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise03;

namespace TestBlock03
{
    [TestClass]
    public class TestExercise03
    {
        [TestMethod]
        public void TestReplaceEqualLetters()
        {
            string str = "IIIIIbbbbOOOOObbbbb";
            Class3.ReplaceEqualLetters(str);

            StringAssert.Equals("IbOb", str);
        }

        [TestMethod]
        public void TestReplaceEqualLettersLastDifferent()
        {
            string str = "IIIIIbbbbOOOOObbbbbC";
            Class3.ReplaceEqualLetters(str);

            StringAssert.Equals("IbObC", str);
        }

        [TestMethod]
        public void TestReplaceEqualLettersDifferentCase()
        {
            string str = "IIIIIiiiIIIibbBBBbbOOOOOoobbbbbC";
            Class3.ReplaceEqualLetters(str);

            StringAssert.Equals("IiIibBbOobC", str);
        }
    }
}
