using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace travhotel.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            //ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            //ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult LoginAdmin()
        {
            return View();
        }
        public ActionResult LoginTraveler()
        {
            return View();
        }
        public ActionResult LoginOwner()
        {
            return View();
        }
        public ActionResult RegisterAdmin()
        {
            return View();
        }
        public ActionResult RegisterTraveler()
        {
            return View();
        }
        public ActionResult RegisterOwner()
        {
            return View();
        }
    }
}