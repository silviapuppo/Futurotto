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
            
        }
    }
}
