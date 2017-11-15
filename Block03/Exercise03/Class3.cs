using System;
using System.Text;

namespace Exercise03
{
    public class Class3
    {
        public static void ReplaceEqualLetters(string str)
        {
            StringBuilder strRep = new StringBuilder();
            int i;

            for (i = 0; i < str.Length - 1; i++)
            {
                if (str[i] != str[i + 1])
                {
                    strRep.Append(str[i]);
                }
            }

            if (str[i] != str[i - 1])
            {
                strRep.Append(str[i]);
            }

            str = strRep.ToString();
        }
    }
}