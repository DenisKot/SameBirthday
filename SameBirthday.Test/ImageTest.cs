using System;
using System.IO;
using System.Linq;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SameBirthday.Data;

namespace SameBirthday.Test
{
    [TestClass]
    public class ImageTest
    {
        [TestMethod]
        public void ImageExisting()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            string imgPath = Path.GetFullPath(Path.Combine(path, @"..\..\..\"));
            imgPath = imgPath.Replace("\\", "/");

            using (var context = new DatabaseContext())
            {
                var list = context.Persons.ToList();

                foreach (var item in list)
                {
                    var filepath = $"{imgPath}SameBirthday/Resorces/Items/{item.Index}.jpg";
                    var exists = File.Exists(filepath);
                    Assert.AreEqual(true, exists);
                }
            }
        }
    }
}
