using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise06;

namespace TestBlock03
{
    [TestClass]
    public class TestExercise06
    {
        [TestMethod]
        public void TestFileParseSuccess()
        {
            string path = @"C:\Users\gabri\Documents\ProvaSuccess.txt";
            Class6.ReadFile(path);
        }

        [TestMethod]
        [ExpectedException(typeof(FileParseException))]
        public void TestFileParseFail()
        {
            string path = @"C:\Users\gabri\Documents\ProvaFail.txt";
            Class6.ReadFile(path);
        }

    }
}
