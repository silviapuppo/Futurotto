using System;
using System.Text.RegularExpressions;

namespace Exercise10
{
    public class Class10
    {
        public static string[] FindEmails(string str)
        {
            string[] mails = new string[2];
            string pattern = "";
            Match m = Regex.Match(str,pattern);
            int i = 0;

            while (m.Success)
            {
                mails[i] = m.Value;
                i++;
            }

            return mails;
        }
    }
}