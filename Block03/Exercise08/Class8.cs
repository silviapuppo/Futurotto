using System;
using System.Text;

namespace Exercise08
{
    public class Class8
    {
        public static int FindSubstringOccurrence(string str, string sub)
        {
            string strLow = new StringBuilder(str).ToString().ToLower();
            string subLow = new StringBuilder(sub).ToString().ToLower();

            int index = strLow.IndexOf(subLow);
            int occurence = 0;

            while (index != -1)
            {
                occurence++;
                index = strLow.IndexOf(subLow, index + 1);
            }

            return occurence;
        }
    }
}
