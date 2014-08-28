using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Mvc;
using TandaOne.Models;

namespace TandaOne.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            var controller = RouteData.Values["controller"];
            var action = RouteData.Values["action"];
            var id = RouteData.Values["is"];

            var message = String.Format("{0}::{1} {2}", controller, action, id);

            ViewBag.Message = message;

            return View();


           
        }

        //public ActionResult TandaOne()
        //{
        //    //var model = new TandaOneModel();


        //    //model.EmployeeId = 1;
        //    //model.FirstName = "Anabela";
        //    //model.Surname = "Ribeiro";
        //    //model.Date = new DateTime().ToLocalTime();
        //    //model.ArrivalTime = new TimeSpan();
        //    //model.DepartureTime = new TimeSpan();


        //    //return View(model);
        //}

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
