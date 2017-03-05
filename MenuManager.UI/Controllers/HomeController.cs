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
            var model = new MenuViewModel();
            model.Feature_Line = new FoodLine { Food_line_title = "test feature" };
            model.Gluteen_Free_Line = new FoodLine { Food_line_title = "test Gluteen"};
            model.Chef_Line = new FoodLine { Food_line_title = "test Chef"};

            model.Feature_Line.Foods = new List<Food>();
            model.Gluteen_Free_Line.Foods = new List<Food>();
            model.Chef_Line.Foods = new List<Food>();

            model.Feature_Line.Foods.Add(new Food { Food_name = "food1" });
            model.Gluteen_Free_Line.Foods.Add(new Food { Food_name = "food2" });
            model.Chef_Line.Foods.Add(new Food { Food_name = "food3" });

            return View(model);
        }

        [HttpGet]
        public ActionResult EditMenu()
        {
            ViewBag.Message = "Your application edit menu page.";

            return View();
        }

        [HttpPost]
        public ActionResult GetMenu()
        {
            ViewBag.Message = "Your application get menu page.";

            return View();
        }

        [HttpPost]
        public ActionResult PostMenu(MenuViewModel menuModel)
        {
            if (ModelState.IsValid)
            {
                var menu = menuModel;
            }

            return new RedirectResult("/Home");
        }

        [HttpPost]
        public PartialViewResult GetBlankFoodField(string item_name)
        {
            return PartialView("_FoodLineItemPartialView", new FoodViewModel { item_name = item_name });
        }
    }
}