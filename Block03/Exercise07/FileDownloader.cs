using System;
using System.Net;

namespace Exercise07
{
    public class FileDownloader
    {
        public static void DownloadFile(string url, string fileName)
        {
            try
            {
                WebClient file = new WebClient();
                file.DownloadFile(url, fileName);
            }
            catch (ArgumentNullException)
            {
                if (url == null)
                {
                    throw new ArgumentNullException("Null Url", url);
                }
                if (fileName == null)
                {
                    throw new ArgumentNullException("Null file name", fileName);
                }

            }
            catch (WebException)
            {
                throw new WebException("Addres or file name not valid");
            }
        }
    }
}
