using System;
using System.Text.RegularExpressions;

namespace Exercise10
{
    public class Class10
    {
        public static string[] FindEmails(string str)
        {
            string pattern = @"([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,3})";
            int length = 0;
            int i = 0;

            foreach (Match m in Regex.Matches(str, pattern))
            {
                length++;
            }

            string[] mails = new string[length];

            foreach (Match m in Regex.Matches(str, pattern))
            {
                mails[i] = m.Value;
                i++;
            }

            return mails;
        }
    }
}