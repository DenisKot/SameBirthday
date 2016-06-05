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
                string day = Request.QueryString["Day"];
                string month = Request.QueryString["Month"];

                var context = new DatabaseContext();
                var list = context.Persons.ToList();

                this.ViewBag.List = list;
            }

            return View();
        }
    }
}