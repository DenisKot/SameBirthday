using System.Net;

namespace SameBirthday.Utils
{
    public static class FileExist
    {
        public static bool UrlExists(string url)
        {
            bool result = false;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Timeout = 100; // miliseconds
            webRequest.Method = "HEAD";

            HttpWebResponse response = null;

            try
            {
                response = (HttpWebResponse)webRequest.GetResponse();
                result = true;
            }
            catch (WebException webException)
            {
            }
            finally
            {
                response?.Close();
            }

            return result;
        }
    }
}