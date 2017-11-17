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
            string path = @"..\..\..\Exercise06\TextParseSuccess.txt";
            FileParser.ReadFile(path);
        }

        [TestMethod]
        [ExpectedException(typeof(FileParseException))]
        public void TestFileParseFail()
        {
            string path = @"..\..\..\Exercise06\TextParseFail.txt";
            FileParser.ReadFile(path);
        }

    }
}
