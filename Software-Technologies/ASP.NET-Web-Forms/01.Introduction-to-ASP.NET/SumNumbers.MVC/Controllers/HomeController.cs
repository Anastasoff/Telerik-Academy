using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SumNumbers.MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        public ActionResult Sum(string firstNumber, string secondNumber)
        {
            double result = double.Parse(firstNumber) + double.Parse(secondNumber);
            this.ViewBag.Result = result;

            return View("Index");
        }
    }
}