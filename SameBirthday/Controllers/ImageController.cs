using System.Linq;
using System.Web.Mvc;
using SameBirthday.Data;
using SameBirthday.Models;

namespace SameBirthday.Controllers
{
    public class ImageController : Controller
    {
        public ActionResult Show(int id)
        {
            Person person = null;

            using (var context = new DatabaseContext())
            {
                person = context.Persons.FirstOrDefault(x => x.Id == id);
            }

            if (person == null)
                return null;

            return File(person.Image, "image/jpg");
        }
    }
}