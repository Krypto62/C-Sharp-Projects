using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationMVC.Models;

namespace WebApplicationMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //int num = 5;

            User user = new User();
            user.Id = 1;
            user.FirstName = "Scott";
            user.LastName = "Fowler";
            user.Age = 55;

            return View(user); //pass user to the View

            //return View(num);

            //string text = "Hello";
            //System.IO.File.WriteAllText(@"C:\Users\scfow\logs\log2.txt", text);

            //Random rnd = new Random(10);
            //int num = rnd.Next();
            ////ViewBag.RandomNumber = num;
            //if (num > 20000)
            //{
            //    return View("About");
            //}

            //return Content("Hello");

            //List<string> names = new List<string>
            //{
            //    "Scott",
            //    "Morgan",
            //    "Karli"
            //};

            //return View(names); //passes the names list to the View
        }

        public ActionResult About()
        {
                //ViewBag.Message = "Your application description page.";
            //throw new Exception("Invalid Page");
            return View();
        }

        public ActionResult Contact(int id=0)
        {
            //ViewBag.Message = "Hello!!!";
            ViewBag.Message = id;

            return View();
        }
    }
}