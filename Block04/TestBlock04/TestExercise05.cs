using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise05;
using System.Numerics;
namespace TestBlock04
{
    [TestClass]
    public class TestExercise05
    {
        [TestMethod]
        public void TestDiffieHellman()
        {
            DiffieHellman Alice = new DiffieHellman("Alice", 17, 34);
            DiffieHellman Bob = new DiffieHellman("Bob", 17, 34);
            Random rnd = new Random();

            Alice.GeneratePublicKey(rnd);
            Bob.GeneratePublicKey(rnd);

            Alice.GetSecretKey(Bob);
            Bob.GetSecretKey(Alice);

            Assert.IsTrue(BigInteger.Equals(Alice.SecretKey, Bob.SecretKey));
        }
    }
}
