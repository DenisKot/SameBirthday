using System.Linq;
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SameBirthday.Data;

namespace SameBirthday.Test
{
    [TestClass]
    public class UrlTest
    {
        [TestMethod]
        public void UrlExisting()
        {
            using (var context = new DatabaseContext())
            {
                var list = context.Persons.ToList();

                foreach (var item in list)
                {
                    if (!string.IsNullOrEmpty(item.Url))
                    {
                        var exists = this.Check(item.Url);
                        Assert.AreEqual(true, exists);
                    }
                }
            }
        }

        public bool Check(string url)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = WebRequestMethods.Http.Head;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                return response.StatusCode == HttpStatusCode.OK;
            }
            catch (WebException)
            {
                return false;
            }
        }
    }
}
