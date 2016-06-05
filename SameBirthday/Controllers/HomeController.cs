using System.Linq;
using System.Web.Mvc;
using SameBirthday.Data;

namespace SameBirthday.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            if (Request.QueryString["Day"] != null && Request.QueryString["Month"] != null)
            {
                int day = int.Parse(Request.QueryString["Day"]);
                int month = int.Parse(Request.QueryString["Month"]);

                using (var context = new DatabaseContext())
                {
                    var list = context.Persons.Where(x => x.Day == day && x.Month == month).ToList();
                    this.ViewBag.List = list;
                }
            }
            else
            {
                using (var context = new DatabaseContext())
                {
                    var list = context.Persons.ToList();
                    this.ViewBag.List = list;
                }
            }

            return View();
        }
    }
}