using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Model03_02.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            ViewData["data1"] = DateTime.Now;
            ViewBag.data2 = DateTime.Now;
            return View();
        }

        public ActionResult Index1()
        {

            ViewData["data1"] = DateTime.Now;
            ViewBag.data2 = DateTime.Now;
            return View("Index");
        }
    }
}