using MapTest.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MapTest.Controllers
{
    public class HomeController : Controller
    {
        private MapData2 Mapdb = new MapData2();
        public ActionResult Index()
        {
            Mapdb = new MapData2();
            return View(Mapdb.Test2.ToList());
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