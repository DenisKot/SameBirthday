using System.Linq;
using System.Web.Mvc;
using SameBirthday.Data;
using SameBirthday.Utils;

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

                this.ViewBag.Title = $"Известные люди родившиеся {day} {DateFormer.GetMonthTitle(month)}";

                using (var context = new DatabaseContext())
                {
                    var list = context.Persons.Where(x => x.Day == day && x.Month == month).OrderBy(x => x.Priority).ToList();
                    this.ViewBag.List = list;
                }

                this.ViewBag.Day = day;
                this.ViewBag.Month = month;
            }
            else
            {
                this.ViewBag.Title = "SameBirthday - Узнай кто родился с тобою в один день!";

                using (var context = new DatabaseContext())
                {
                    var list = context.Persons.OrderByDescending(x => x.Index).ToList();
                    this.ViewBag.List = list;
                }

                this.ViewBag.Day = 1;
                this.ViewBag.Month = 1;
            }

            return View();
        }
    }
}