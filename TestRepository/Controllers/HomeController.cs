using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestRepository.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
           string test = "Hello";
           
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            string test = "test";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
