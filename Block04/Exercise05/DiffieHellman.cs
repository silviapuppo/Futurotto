using System;
using System.Numerics;

namespace Exercise05
{
    public class DiffieHellman
    {
        public string Name { get; set; }
        public int P { get; set; }
        public int G { get; set; }
        public int PrivateKey { get; set; }
        public BigInteger PublicKey { get; set; } = new BigInteger();
        public BigInteger SecretKey { get; set; } = new BigInteger();

        public DiffieHellman(string name, int p, int g)
        {
            Name = name;
            P = p;
            G = g;
        }

        public void GeneratePublicKey(Random rnd)
        {
            PrivateKey = rnd.Next(1, P);
            PublicKey = BigInteger.Pow(G, PrivateKey) % P;
        }

        public void GetSecretKey(DiffieHellman other)
        {
            SecretKey = BigInteger.Pow(other.PublicKey, PrivateKey) % P;
        }
    }
}
