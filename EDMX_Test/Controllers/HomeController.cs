using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EDMX_Test.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var dbContext = new PlutoDbContext();
            var courses = dbContext.GetCourses();
            //var t = "";

            //foreach (var item in courses)
            //{
            //    t += "<li>" + item.Title + "</li>";
            //}

            //ViewBag.MSG = t;
            return View(dbContext.Courses.ToList());
        }
    }
}