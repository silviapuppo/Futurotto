using System;

namespace Exercise04
{
    public class SubsetsGenerator
    {
        public static string[] GetStringSubsets(string[] arrayStr, int k)
        {
            int x = BinomCoefficient(arrayStr.Length, k);
            string[] subSets = new string[x];
            int y = arrayStr.Length;
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
            else if ()
            {

            }
            else
            {
                return arrayStr[y] + Rec(arrayStr, k - 1, y - 1);
            }

        }

        private static int BinomCoefficient(int n, int k)
        {
            if (k > n)
            {
                return 0;
            }

            if (n == k)
            {
                return 1;
            }

            if (k > n - k)
            {
                k = n - k;
            }

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
