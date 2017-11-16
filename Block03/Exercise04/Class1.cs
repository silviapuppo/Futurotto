using System;

namespace Exercise04
{
    public class Class1
    {
        public static string[] GetStringSubsets(string[] arrayStr, int k)
        {
            int x = BinomCoefficient(arrayStr.Length, k);
            string[] subSets = new string[x];
            int y = arrayStr.Length - 1;
            k = k - 1;

            for (int i = x - 1; i >= 0; i--)
            {
                while (y > 0)
                {
                    subSets[i] = Rec(arrayStr, k, y);
                    y--;
                }
            }
            return subSets;

        }

        private static string Rec(string[] arrayStr, int k, int y)
        {
            if (k == 0)
            {
                return arrayStr[y];
            }
            else
            {
                return arrayStr[y] + Rec(arrayStr, k - 1, y - 1);
            }

        }

        private static int BinomCoefficient(int n, int k)
        {
            if (k > n) { return 0; }
            if (n == k) { return 1; } // only one way to chose when n == k
            if (k > n - k) { k = n - k; } // Everything is symmetric around n-k, so it is quicker to iterate over a smaller k than a larger one.
            int c = 1;
            for (int i = 1; i <= k; i++)
            {
                c *= n--;
                c /= i;
            }
            return c;
        }

    }
}
