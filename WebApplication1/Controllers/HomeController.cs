using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<int> yearList = new List<int>();
            int sYear = 2500 - 543;
            int eYear = 2600 - 543;

           
            for (int year = sYear; year <= eYear; year++)
            {
                DateTime startYear = new DateTime(year, 1, 1);
                DateTime endtYear = new DateTime(year, 1, 31);

               
          
                int fri = Enumerable.Range(0,31).Where(x => startYear.AddDays(x).DayOfWeek == DayOfWeek.Friday).Count();
                int sat = Enumerable.Range(0,31).Where(x => startYear.AddDays(x).DayOfWeek == DayOfWeek.Saturday).Count();
                int sun = Enumerable.Range(0,31).Where(x => startYear.AddDays(x).DayOfWeek == DayOfWeek.Sunday).Count();

                if (fri == 5 && sat == 5 && sun == 5)
                {
                    yearList.Add(year + 543);
                    Console.WriteLine(year);
                }
              

            }

            ViewBag.Year = yearList;
            
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}