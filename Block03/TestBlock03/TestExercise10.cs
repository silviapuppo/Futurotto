using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise10;

namespace TestBlock03
{
    [TestClass]
    public class TestExercise10
    {
        [TestMethod]
        public void TestFindEmails()
        {
            string str = "Please contact us by phone (+001 222 222 222) or by email at example@gmail.com or at test.user@yahoo.co.uk. " +
                "This is not email: test@test. This also: @gmail.com. Neither this:" + "a @a.b.";
            string[] mails = { "example@gmail.com", "test.user@yahoo.co.uk" };

            CollectionAssert.AreEqual(mails, Class10.FindEmails(str));
            Assert.AreEqual(2, Class10.FindEmails(str).Length);
        }

        [TestMethod]
        public void TestFindOurEmails()
        {
            string str = "Our emails are silvia.puppo.97@outlook.it or silvia.puppo.97@gmail.com " +
                "and gabriele.filaferro@gmail.com or gabrigengio@gmail.com";

            string[] mails = { "silvia.puppo.97@outlook.it", "silvia.puppo.97@gmail.com", "gabriele.filaferro@gmail.com", "gabrigengio@gmail.com" };

            CollectionAssert.AreEqual(mails, Class10.FindEmails(str));
            Assert.AreEqual(4, Class10.FindEmails(str).Length);
        }

        [TestMethod]
        public void TestFindSomeEmails()
        {
            string str = "Our emails are silvia..pu97@outlook.it or sipuppo.97@gmail.com " +
                "and gabri.fila@gmail.com or gabrigengio@gmail.co.uk";

            string[] mails = { "silvia..pu97@outlook.it", "sipuppo.97@gmail.com", "gabri.fila@gmail.com", "gabrigengio@gmail.co.uk" };

            CollectionAssert.AreEqual(mails, Class10.FindEmails(str));
            Assert.AreNotEqual(2, Class10.FindEmails(str).Length);
        }


    }
}
