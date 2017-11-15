using System;

namespace Exercise09
{
    public class Class9
    {
        public static void TurnUpperCase(string str)
        {
            int startIndex = str.IndexOf("<upcase>");
            int endIndex = str.IndexOf("</upcase>");
            string sub;

            while (startIndex != -1)
            {
                str.Remove(startIndex, 8);
                sub = str.Substring(startIndex, endIndex - startIndex);
                str = str.Replace(sub, sub.ToUpper());
                str.Remove(endIndex, 9);
                startIndex = str.IndexOf("<upcase>", startIndex + 1);
                endIndex = str.IndexOf("</upcase>", startIndex + 1);
            }
        }
    }
}
