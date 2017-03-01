using MenuManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MenuManager.UI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult EditMenu()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [HttpPost]
        public ActionResult GetMenu()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [HttpPost]
        [ActionName(name:"PostMenu")]
        public ActionResult PostMenu(MenuViewModel menu)
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
    }
}