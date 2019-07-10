using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TTtutorial.Filters;

namespace TTtutorial.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //throw new Exception("This is unhandled exception");
            TempData["name"] = "Test name";
            TempData["age"] = 30;
            TempData["myData"] = "Test data";
            return View();
        }

        public ActionResult About()
        {
            //checked temp and view data with debugger
            string userName;
            int userAge;

            if (TempData.ContainsKey("name"))
                userName = TempData["name"].ToString();

            if (TempData.ContainsKey("age"))
                userAge = int.Parse(TempData["age"].ToString());

            // do something with userName or userAge here 

            return View();
        }

        public ActionResult Contact()
        {
            //checked temp and view data with debugger
            string data;

            if (TempData["myData"] != null)
                data = TempData["myData"] as string;

            return View();
        }
    }
}