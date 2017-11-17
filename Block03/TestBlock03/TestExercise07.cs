using System;
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise07;

namespace TestBlock03
{
    [TestClass]
    public class TestExercise07
    {
        [TestMethod]
        public void TestDownloadFile()
        {
            string url = "https://i.ytimg.com/vi/KUdxShTNWTc/maxresdefault.jpg";
            string fileName = "IbbObb";
            FileDownloader.DownloadFile(url, fileName);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestDownloadFileNull()
        {
            string url = null;
            string fileName = null;
            FileDownloader.DownloadFile(url, fileName);
        }

        [TestMethod]
        [ExpectedException(typeof(WebException))]
        public void TestDownloadFileWrong()
        {
            string url = "sgdfgs.vfdbàa.com";
            string fileName = "IbbObb";
            FileDownloader.DownloadFile(url, fileName);
        }

    }
}
